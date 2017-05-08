using System;
using System.IO;
using System.Xml.Serialization;

namespace BlackJackLibrary
{
    class GameHistory
    {
        public string XmlFilePath {get; set; }

        public GameHistory()
        {
            new GameHistory(@"C:\Users\Utente\Desktop\ITS\.NET C#\BlackJack\BlackJack\history.xml");
        }
        public GameHistory(string path)
        {
            XmlFilePath = path;
        }

        public string xmlRead()
        {
            string xmlContent = string.Empty;
            if(!File.Exists(XmlFilePath))
                throw new FileDoesNotExistsException();
            else
            {
                Games games = null;
                XmlSerializer serializer = new XmlSerializer(typeof(Games));
                using( StreamReader sr = new StreamReader(XmlFilePath))
                {
                    games = (Games)serializer.Deserialize(sr);
                    sr.Dispose();
                }
                
                foreach(Game g in games.GamesHistorical)
                {
                    xmlContent = string.Concat(xmlContent, g.ToString());
                }
            }

            return xmlContent;
        }

        public void xmlWrite(Game g)
        {
            //string xmlContent = string.Empty;
            if(!File.Exists(XmlFilePath))
            {
                Games games = new Games();
                games.GamesHistorical[0] = g;
                XmlSerializer serialazer = new XmlSerializer(typeof(Games));

                using(TextWriter tw = new StreamWriter(XmlFilePath, false))
                {
                    serialazer.Serialize(tw, games);
                    tw.Dispose();
                }
            }
            else
            {
                Games games = null;
                XmlSerializer serializer = new XmlSerializer(typeof(Games));

                using (StreamReader sr = new StreamReader(XmlFilePath))
                {
                    games = (Games)serializer.Deserialize(sr);
                    sr.Dispose();
                }

                int oldLength = games.GamesHistorical.Length;
                Array.Resize(ref games.GamesHistorical, oldLength + 1);
                games.GamesHistorical[oldLength] = g;

                using (TextWriter tw = new StreamWriter(XmlFilePath, false))
                {
                    serializer.Serialize(tw, games);
                    tw.Dispose();
                }

            }
        }

    }
}
