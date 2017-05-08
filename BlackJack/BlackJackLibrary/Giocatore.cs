using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackLibrary
{
    public class Giocatore:Persona
    {
        public Giocatore(TypeG typePlayer) : base(typePlayer) {
            Giochi[0].Puntata = 0;
        }
        public Giocatore(TypeG typePlayer, long puntata) : base(typePlayer)
        {
            Giochi[0].Puntata = puntata;
        }


        public void insurance() { }

        public void doubleDown(int i) { Giochi[i].Puntata *= 2; }
        public void doubleDown(Gioco g) { g.Puntata *= 2; }

        //public override int giocata() { }

        public override bool initialAceControl()
        {
            return false;
        }
    }
}