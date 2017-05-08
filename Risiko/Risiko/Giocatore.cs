using System.Collections.Generic;

namespace Risiko {
    class Giocatore {
        public string NomeG {get; set; }
        public Colore ColoreG {get; set; }
        public int NumStati {get; set; }
        public int NumTruppe {get; set; }
        public List<int> StatiGiocatore { get; set; }
        public Obbiettivo ObbiettivoG { get; }
        public List<int> Bonus { get; set; }

        public Giocatore(string nome, Colore colore, int numStati, int numTruppe, List<int> statiGiocatore, Obbiettivo obbiettivoGioc) {
            this.NomeG = nome;
            this.ColoreG = colore;
            this.NumStati = numStati;
            this.NumTruppe = numTruppe;
            this.StatiGiocatore = statiGiocatore;
            this.ObbiettivoG = obbiettivoGioc;
            Bonus = new List<int>();
        }

        //vittoria
        //perdi stato
        //acquisisci stato
        //attacca/difendi
        //sposta truppe
        //riscuoti bonus



        /*  CAZZO CAZZO CAZZO
         *  //  problema    ->   disposizione iniziale truppe
         *  //  problema    ->   serve classe con numero di truppe correnti in determinato stato
         *  CAZZO CAZZO CAZZO
         */

    }
}
