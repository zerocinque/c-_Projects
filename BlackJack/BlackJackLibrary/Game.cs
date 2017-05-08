using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlackJackLibrary
{
    [Serializable()]
     public class Game
    {
        [XmlAttribute("started")]
        public DateTime DateStarted {get;set; }
        [XmlAttribute("end")]
        public DateTime DateEnded {get;set; }
        [XmlElement("playerPoints")]
        public int PlayerPoints {get;set; }
        [XmlElement("dealerPoints")]
        public int DealerPoints {get;set; }
        [XmlElement("winner")]
        public TypeG Winner;

        public override string ToString()
        {
            return string.Format("Date started: {0}\r\nDate ended: {1}\r\nPlayer points: {2}\r\nDeraler points: {3}\r\nWinner: {4}\r\n", DateStarted, DateEnded, PlayerPoints, DealerPoints, Winner.ToString());
        }
    }
}
