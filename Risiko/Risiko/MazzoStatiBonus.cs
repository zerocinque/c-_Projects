using System;
using System.Collections.Generic;

namespace Risiko {
    class MazzoStatiBonus {
        List<int> Carte { get; set; }
        List<int> CarteScartate { get; set; }
        
        public MazzoStatiBonus(int numStati) {
            Carte = new List<int>(numStati+2);
            CarteScartate = new List<int>();

            for (int i = 0; i<Carte.Count; i++) {
                Carte[i] = i;
            }
        }

        public void mescola() {
            mescola(150);
        }

        public void mescola(int numeroScambi) {
            Random rand = new Random();

            int c1, c2;

            for(int i=0; i<numeroScambi; i++) {
                c1 = rand.Next(Carte.Count);
                do {
                    c2 = rand.Next(Carte.Count);
                } while (c1 == c2);

                int tmp = Carte[c1];
                Carte[c1] = Carte[c2];
                Carte[c2] = tmp;
            }
        }

        public int pescaCarta() {
            if (Carte.Count == 0) {
                foreach(int c in CarteScartate) 
                    Carte.Add(c);
                this.mescola();
                CarteScartate.Clear();
            }
            int tmp = Carte[0];
            Carte.Remove(0);
            return tmp;
        }

        public void scartaCarte(List<int> carteScartate) {
            foreach(int c in carteScartate) {
                CarteScartate.Add(c);
            }
        }
    }
}
