using System;
using System.Collections.Generic;
using System.IO;
namespace Risiko {
    public class Mappa {

        public Continente[] Continenti {get; set; }
        public List<Carta> Stati {get; set;}
                
        public Mappa(int numStati, int numContinenti) {
            Continenti = new Continente[numContinenti];
            Stati = new List<Carta>();
            Stati.Add(new Carta(Bonus.Jolly, numStati));
            Stati.Add(new Carta(Bonus.Jolly, numStati+1));
        }

        /*public List<int>[] StatiGiocatori(int numGiocatori) {
            List<int>[] statiG = new List<int>[numGiocatori];
            int[] statiMappa = new int[Stati.Count];

            for(int i=0; i<Stati.Count; i++) {
                statiMappa[i] = i;
            }
            for(int i=0; i<150; i++) {
                int s1, s2;
                Random rand = new Random();

                s1 = rand.Next(Stati.Count);
                do {
                    s2 = rand.Next(Stati.Count);
                } while (s1 == s2);

                int tmp = statiMappa[s1];
                statiMappa[s1] = statiMappa[s2];
                statiMappa[s2] = tmp;

            }

            for(int i=0, j=0; i< statiMappa.Length; i++, j++) {
                if (j >= numGiocatori) {
                    j = 0;
                }
                statiG[j].Add(statiMappa[i]);
            }


            return statiG;
        }*/

    }
}
