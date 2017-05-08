using System;
using System.Collections.Generic;

namespace Risiko {
    class MazzoObbiettivi {
        List<Obbiettivo> obbiettivi;

        public MazzoObbiettivi(string pathFile) {
            //obbiettivi = new Obbiettivo[numObbiettivi];
            //bisogna leggerli da file
        }

        public void mescola() {
            mescola(80);
        }

        public Obbiettivo pescaObbiettivo() {
            Obbiettivo tmp = obbiettivi[0];
            obbiettivi.RemoveAt(0);

            return tmp;
        }

        public void mescola(int numeroScambi) {
            Random rand = new Random();

            int c1, c2;

            for (int i = 0; i < numeroScambi; i++) {
                c1 = rand.Next(obbiettivi.Count);
                do {
                    c2 = rand.Next(obbiettivi.Count);
                } while (c1 == c2);

                Obbiettivo tmp = new Obbiettivo();
                tmp = obbiettivi[c1];
                obbiettivi[c1] = obbiettivi[c2];
                obbiettivi[c2] = tmp;
            }
        }

    }
}
