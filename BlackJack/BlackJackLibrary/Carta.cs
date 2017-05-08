using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class Carta
    {
        public Valore Value { get; set; }
        public Seme Seed { get; set; }
        public byte Score {
            get { return Score; }
            set
            {
                if ((byte)Value < 11 && value == (byte)Value)
                    Score = value;
                else if ((byte)Value > 10 && (byte)Value < 14 && value == 10)
                    Score = value;
                else if ((byte)Value == 1 && value == 11)
                    Score = value;
            }
        }

        public Carta(Seme seed, Valore value)
        {
            Value = value;
            Seed = seed;
            if ((byte)seed == 1)
                Score = 11;
            else if ((byte)seed < 11)
                Score = (byte)seed;
            else
                Score = 10;
        }

        public bool isAce()
        {
            return Value == Valore.ASSO;
        }
        public void setAceScore(byte score)
        {
            this.Score = score;
        }
    }
}
