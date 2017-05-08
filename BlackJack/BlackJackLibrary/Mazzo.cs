using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class Mazzo
    {
        const byte numCartePerMazzo = 52;
        //private List<Carta> mazzo;
        private Carta[] mazzo;
        private int indice;

        public Mazzo()
        {
            mazzo = new Carta[numCartePerMazzo];
            costruisciMazzo(7);
        }
        public Mazzo(int numeromazzi)
        {
            mazzo = new Carta[numCartePerMazzo * numeromazzi];
            costruisciMazzo(numeromazzi);
        }

        private void costruisciMazzo(int numeromazzi)
        {
            int k = 0;
            indice = 0;
            for(int i=0; i<numeromazzi; i++)
            {
                foreach(Seme s in Enum.GetValues(typeof(Seme)))
                {
                    foreach(Valore v in Enum.GetValues(typeof(Valore)))
                    {
                        mazzo[k++] = new Carta(s, v);
                    }
                }
            }
        }

        public void mescola()
        {
            mescola(250);
        }
        public void mescola(int numeroScambi)
        {
            Random rand = new Random();

            int p1;
            int p2;

            for (int i = 0; i < numeroScambi; i++)
            {
                p1 = rand.Next(mazzo.Length);
                do
                {
                    p2 = rand.Next(mazzo.Length);
                } while (p1 == p2);

                Carta tmp = mazzo[p1];
                mazzo[p1] = mazzo[p2];
                mazzo[p2] = tmp;
            }
        }
        public Carta pesca()
        {
            if (indice >= mazzo.Length)
            {
                mescola(150);
                indice = 0;
            }
            return mazzo[indice++];
        }

    }
}
