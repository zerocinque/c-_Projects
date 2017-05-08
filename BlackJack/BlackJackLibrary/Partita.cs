namespace BlackJackLibrary
{
    public class Partita
    {
        private const byte numCarteIniziali = 2;
        public Giocatore[] Players { get; set; }
        public Banco Dealer { get; set; }
        public Mazzo Deck { get; set; }
        public int Vincitore { get; set; }
        
        //coostruttori
        public Partita()
        {
            new Partita(1, 7);
        }
        public Partita(int numeroGiocatori)
        {
            new Partita(numeroGiocatori, 7);
        }
        public Partita(int numeroGiocatori, int numeroMazzi)
        {
            Players = new Giocatore[numeroGiocatori];
            for (int i = 0; i < Players.Length; i++)
                Players[i] = new Giocatore(TypeG.PLAYER);
            Dealer = new Banco(TypeG.DEALER);
            Deck = new Mazzo(numeroMazzi);
            Vincitore = -2;
        }

        //funzione che distribuisce le due carte iniziali
        public bool distribuzioneCarte()///da rivedere completamente
        {
            for (int i = 0; i < numCarteIniziali; i++)
            {
                foreach (Giocatore g in Players)
                {
                    Carta c = Deck.pesca();
                    g.Giochi[0].Carte.Add(c);
                    g.Giochi[0].Punteggio += c.Score;
                }
                Carta cD = Deck.pesca();
                Dealer.Giochi[0].Carte.Add(cD);
                Dealer.Giochi[0].Punteggio += cD.Score;
            }

            for(int i = 0; i<Players.Length; i++)
            {
                if (Players[i].Giochi[0].isBlackJack())
                {
                    Vincitore = i;
                    return true;
                }
            }
            return false;
        }/// da riedere completamente.

        public void giocata(int indexGiocatore)//giocate giocatore
        {
            // forse è inutile
        }
        
        public void giocata()//giocata dealer
        {
            if (Dealer.Giochi[0].Carte[0].isAce() && Dealer.Giochi[0].Carte[1].isAce())
            {
                Dealer.split(Dealer.Giochi[0]);
                Dealer.Giochi[0].refreshScore(TypeG.DEALER);
                Dealer.Giochi[1].refreshScore(TypeG.DEALER);
            }
            else if (Dealer.Giochi[0].Carte[0].isAce())
            {
                Dealer.Giochi[0].Carte[0].setAceScore(Dealer.chooseAceScore(Dealer.Giochi[0]));
                Dealer.Giochi[0].refreshScore(TypeG.DEALER);
            }
            else if (Dealer.Giochi[0].Carte[1].isAce())
            {
                Dealer.Giochi[0].Carte[1].setAceScore(Dealer.chooseAceScore(Dealer.Giochi[0]));
                Dealer.Giochi[0].refreshScore(TypeG.DEALER);
            }
            do
            {
                foreach (Gioco g in Dealer.Giochi)
                {
                    g.refreshScore(TypeG.DEALER);
                    if (g.isSplitable())
                    {
                        Dealer.split(g);
                        g.refreshScore(TypeG.DEALER);
                    }
                    if (g.Punteggio < Dealer.LimitePunteggio)
                    {
                        g.Carte.Add(Deck.pesca());
                        g.refreshScore(TypeG.DEALER);
                    }
                        
                    if (g.isBlackJack())
                        Vincitore = -1;
                }
            } while (true);
        }

        public void winner()
        {
            int max=0;
            int winner = -2;

            for(int i=0; i<Players.Length; i++)
            {
                foreach(Gioco g in Players[i].Giochi)
                {
                    if (g.Punteggio > max)
                    {
                        winner = i;
                        max = g.Punteggio;
                    }
                }
            }
            foreach(Gioco g in Dealer.Giochi)
            {
                if (g.Punteggio > max)
                {
                    winner = -1;
                    max = g.Punteggio;
                }
            }
            Vincitore = winner;
        }
    }
}
