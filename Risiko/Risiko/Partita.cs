using System;
using System.Collections.Generic;
using System.IO;

namespace Risiko {
    class Partita {
        Mappa mappa;
        Giocatore[] giocatori;
        MazzoStatiBonus mazzoCarte;

        public void settaGiocatori(string[] nomiGiocatori, string pathObbiettivi) {
            MazzoObbiettivi obbiettivi = new MazzoObbiettivi(pathObbiettivi);

            if (nomiGiocatori.Length < 3 || nomiGiocatori.Length > 6)// controllo numero di giocatori
                throw new PlayersOutOfRangeException("Il numero di giocatori dev'essere tra 3 e 6.");

            giocatori = new Giocatore[nomiGiocatori.Length];
            int nTruppe = NumTruppe.numTroppeGioc(nomiGiocatori.Length);

            List<int>[] statiGioc = statiGiocatori(nomiGiocatori.Length);
            obbiettivi.mescola();

            //// assegnazione casuale colori giocatori
            Random rand = new Random();
            int[] colori = new int[nomiGiocatori.Length];
            for (int i = 0; i < nomiGiocatori.Length; i++) {
                bool flag = false;
                do {
                    int n = rand.Next(6);
                    foreach (int c in colori) {
                        if (c == n) {
                            flag = true;
                            break;
                        }
                        flag = false;
                    }
                    colori[i] = n;
                } while (!flag);
            }
            //// inizializzazione vettore di giocatori
            for (int i=0; i<giocatori.Length; i++) {
                Giocatore nuovoGiocatore = new Giocatore(nomiGiocatori[i], (Colore)colori[i], statiGioc[i].Count, nTruppe, statiGioc[i], obbiettivi.pescaObbiettivo());
                giocatori[i] = nuovoGiocatore;
            }
            controllaObbiettiviColoreGiocatore();
        }

        // controlla se sono presenti 
        public void controllaObbiettiviColoreGiocatore() {
            foreach (Giocatore g in giocatori) {
                if (g.ObbiettivoG.Id == 1) {
                    bool flag = false;
                    if (g.ColoreG != g.ObbiettivoG.Nemico)
                        foreach (Giocatore gc in giocatori)
                            if (g.ObbiettivoG.Nemico == gc.ColoreG) {
                                flag = true;
                                break;
                            }

                    if (!flag) {
                        g.ObbiettivoG.NumeroTerritori = 24;
                        g.ObbiettivoG.Id = 0;
                    }
                }
            }
        }



        private List<int>[] statiGiocatori(int numGiocatori) {
            List<int>[] statiG = new List<int>[numGiocatori];
            int[] statiMappa = new int[mappa.Stati.Count];

            for (int i = 0; i < statiMappa.Length; i++) {
                statiMappa[i] = i;
            }
            for (int i = 0; i < 150; i++) {
                int s1, s2;
                Random rand = new Random();

                s1 = rand.Next(statiMappa.Length);
                do {
                    s2 = rand.Next(statiMappa.Length);
                } while (s1 == s2);

                int tmp = statiMappa[s1];
                statiMappa[s1] = statiMappa[s2];
                statiMappa[s2] = tmp;

            }

            for (int i = 0, j = 0; i < statiMappa.Length; i++, j++) {
                if (j >= numGiocatori) {
                    j = 0;
                }
                statiG[j].Add(statiMappa[i]);
            }


            return statiG;
        }
        //@"C:\Users\Utente\Documents\Visual Studio 2015\Projects\Risiko\dati.txt" -> path mappa
        public Partita(string[] nomiGiocatori, string pathMappa, string pathObbiettivi) {
            using(StreamReader sr=new StreamReader(pathMappa)) {
                string line;
                line = sr.ReadLine();
                string[] partiNum = line.Split(' ');
                
                int nCont = int.Parse(partiNum[0]);
                int nStati = int.Parse(partiNum[1]);
                int nObbiettivi = int.Parse(partiNum[2]);

                mappa = new Mappa(nCont, nStati);
                mazzoCarte = new MazzoStatiBonus(nStati);

                for(int i=0; i<mappa.Continenti.Length; i++) {
                    line = sr.ReadLine();
                    string[] partiContinente = line.Split(' ');
                    partiContinente[0].Replace('_', ' ');
                    int idContinente = int.Parse(partiContinente[1]);
                    int numStatiContinente = int.Parse(partiContinente[2]);
                    int numTruppeBonusContinente = int.Parse(partiContinente[3]);
                    mappa.Continenti[i] = new Continente(partiContinente[0], idContinente, numStatiContinente, numTruppeBonusContinente);

                    for (int j=0; j<mappa.Continenti[i].StatiContinente.Length; j++) {
                        line = sr.ReadLine();
                        string[] partiStato = line.Split(' ');
                        string nomeStato = partiStato[0].Replace('_', ' ');
                        int idStato = int.Parse(partiStato[1]);
                        Bonus bonusStato = (Bonus)int.Parse(partiStato[2]);
                        int numeroConfini = int.Parse(partiStato[3]);
                        List<int> statiConfinanti = new List<int>();
                        for (int k = 0; k < numeroConfini; k++) {
                            statiConfinanti.Add(int.Parse(partiStato[3 + k]));
                        }
                        Stato nuovoStato = new Stato(nomeStato, idStato, bonusStato, statiConfinanti);
                        mappa.Stati.Add(nuovoStato);

                        mappa.Continenti[i].StatiContinente[j] = idStato;
                    }

                    //iniziallizazio mazzoStatiBonus
                    mazzoCarte = new MazzoStatiBonus(nStati);


                    

                }

                // inizializza giocatori e mazzoObbiettivi da testo a parte
                settaGiocatori(nomiGiocatori, pathObbiettivi);
            }
        }
        
        


        
    }
}
