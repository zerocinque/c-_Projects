using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLibrary
{
    public abstract class Persona
    {
        public List<Gioco> Giochi { get; set; }
        public TypeG TypePlayer { get; }

        //unico costruttore
        public Persona(TypeG typePlayer)
        {
            Giochi = new List<Gioco>(5);
            Giochi.Add(new Gioco());
            TypePlayer = typePlayer;
        }

        /**   PROBLEMA DEGLI ASSI
         * controllo su più carte solo all'inizio della giocata di ogni giocatore
         * --->quindi solo sulle prime due carte della prima lista
         * --->successivamente si fa il controllo e la scelta appena si pesca la carta
         * 
         * per il dealer invece si controlla subito la seconda carta scoperta --> per eventuali assicurazioni da parte dei giocatori
         * ma la scelta del valore la fa quando scopre la seconda carta
         * e di conseguenza il controllo sulla seconda carta la si fa quando la si scopre
         * 
         * quindi avremo i metodi isAce() e setAceScore() in carta
         * i metodi initialAceControl() in Banco e Giocatore
         */
        
        //overload metodo split
        public virtual void split(int i) {
            int n = Giochi.Count;
            Giochi.Add(new Gioco());
            Giochi[n].Carte.Add(Giochi[i].Carte.First());
            Giochi[i].Carte.RemoveAt(0);
            if (this is Giocatore)
                Giochi[n].Puntata = Giochi[i].Puntata;            
        }
        public virtual void split(Gioco g)
        {
            int n = Giochi.Count;
            Giochi.Add(new Gioco());
            Giochi[n].Carte.Add(g.Carte.First());
            g.Carte.RemoveAt(0);
            if (this is Giocatore)
                Giochi[n].Puntata = g.Puntata;
        }


        //metodi abstract
        //public abstract int giocata(); implementata in partita
        public abstract bool initialAceControl();
    }
}
