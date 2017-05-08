using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Game_level = diff.ToString();
            Time_taken = time_taken;
            Mines_found = mines_found;
            Total_number_of_mine = total_number_of_mine;
            Number_of_moves = num_moves;
            Win = win;
        }
        
    }
}
