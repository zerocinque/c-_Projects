using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class Gioco
    {
        public long? Puntata { get; set; }
        public List<Carta> Carte { get; set; }
        public short Punteggio { get; set; }

        public Gioco()
        {
            Carte = new List<Carta>(5);
            Punteggio = 0;
        }
         
        /**funzione che controlla se un giocatore ha fatto blackjack
         * @return true se si è fatto blackjack
         * @return false se NON si è fatto blackjack
         */
        public bool isBlackJack()
        {
            return Punteggio == 21;
        }

        public bool isSplitable()
        {
            if (Carte.Count == 2 && Carte[0] == Carte[1] && Carte[0].Score==10)
                return true;
            else
                return false;
        }
        public void refreshScore(TypeG tipeg)
        {
            Punteggio = 0;
            foreach (Carta c in Carte)
                Punteggio += c.Score;
            if (Punteggio > 21 && tipeg == TypeG.DEALER)
                throw new DealerPointsOutOfRangeException();
            else if (Punteggio > 21 && tipeg == TypeG.PLAYER)
                throw new PlayerPointsOutOfRangeException();
        }


    }
}
