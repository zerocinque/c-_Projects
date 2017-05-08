using System;
using System.Xml.Serialization;

namespace BlackJackLibrary
{
    [Serializable()]
    [XmlRoot("games")]
    public class Games
    {
        [XmlElement("game")]
        public Game[] GamesHistorical;
        
        public Games()
        {
            GamesHistorical = new Game[1];
        }

        public void resizeGames(int newSize)
        {
            Array.Resize(ref GamesHistorical, newSize);
        }
    }
}
