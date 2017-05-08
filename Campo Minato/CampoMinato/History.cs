using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CampoMinato
{
    public class History
    {
        public string Game_level { get; set; }
        public long Time_taken { get; set; }
        public int Mines_found { get; set; }
        public int Total_number_of_mine { get; set; }
        public int Number_of_moves { get; set; }
        public bool Win { get; set; }


        public History() { }

        public History(Difficulty diff, int mines_found, int num_moves, bool win)
        {
            Game_level = diff.ToString();
            Mines_found = mines_found;
            Number_of_moves = num_moves;
            Win = win;
        }

        public History(Difficulty diff, long time_taken, int mines_found, int total_number_of_mine, int num_moves, bool win)
        {
            Time_taken = time_taken;
            Total_number_of_mine = total_number_of_mine;
            Game_level = diff.ToString();
            Mines_found = mines_found;
            Number_of_moves = num_moves;
            Win = win;
            //new History(diff, mines_found, num_moves, win);
        }

        static public string jsonRead()
        {
            string jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\CampoMinato\history\history.json";
            string jsonText = string.Empty;

            if(!File.Exists(jsonFilePath))
                throw new FileNotExistsException();
            else
            {
                using(TextReader tr = new StreamReader(jsonFilePath))
                {
                    jsonText = tr.ReadToEnd();
                    tr.Dispose();
                }
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<History> storico = js.Deserialize<List<History>>(jsonText);

                jsonText = string.Empty;
                foreach(History h in storico)
                    jsonText = string.Concat(jsonText, h.ToString());

            }

            return jsonText;
        }

        public override string ToString()
        {
            return string.Format("Difficoltà: {0}\r\nTempo impiegato: {1} secondi\r\nMine Trovate: {2}\r\nNumero totale di mine: {3}\r\nNumero di mosse: {4}\r\n{5}\r\n\r\n", Game_level, Time_taken, Mines_found, Total_number_of_mine, Number_of_moves, Win?"VITTORIA":"SCONFITTA");
        }

    }
}
