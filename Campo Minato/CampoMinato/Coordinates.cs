using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinato
{
    public struct Coordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinates(int r, int c)
        {
            Row = r;
            Column = c;
        }
    }
}
