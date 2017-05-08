using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public class Banco : Persona
    {
        public byte LimitePunteggio { get; }

        public Banco(TypeG typePlayer) : base(typePlayer)
        {
            LimitePunteggio = 16;
        }

        /*public override int giocata()
        {
            if(Giochi[0].Carte[0].isAce() && Giochi[0].Carte[1].isAce())
            {
                Giochi[0].Carte[0].setAceScore(1);
                Giochi[0].Carte[1].setAceScore(1);
                Giochi[0].refreshScore();
            }
            else if (Giochi[0].Carte[0].isAce())
            {
                Giochi[0].Carte[0].setAceScore(chooseAceScore(Giochi[0]));
                Giochi[0].refreshScore();
            }
            else if (Giochi[0].Carte[1].isAce())
            {
                Giochi[0].Carte[1].setAceScore(chooseAceScore(Giochi[0]));
                Giochi[0].refreshScore();
            }
            do
            {
                foreach(Gioco g in Giochi)
                {
                    if (g.isSplitable())
                        split(g);
                    g.refreshScore();
                    if(g.Punteggio<limitePunteggio)
                        g.Carte.Add()
                    if (g.isBlackJack())
                        return -1;



                }
            }
        }*/

        public byte chooseAceScore(Gioco g)
        {
            if (g.Punteggio < 11)
                return 11;
            else
                return 1;
        }

        public override bool initialAceControl()
        {
            if(Giochi[0].Carte[1].Value == Valore.ASSO)
            {
                Giochi[0].Punteggio = 0;
                return true;
            }
            return false;
        }
    }
}
