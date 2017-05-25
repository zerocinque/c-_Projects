using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tris
{
    public class Casella : Button
    {
        //public bool Player { get; set;}
        private Game g;
        public Casella(Game g) : base()
        {
            this.MouseClick += Casella_MouseClick;
            this.FlatStyle = FlatStyle.Flat;
            this.g = g;
        }
        public Casella(Game g, string name, int misura) : this(g)
        {
            this.Name = name;
            this.Height = misura;
            this.Width = misura;
        }

        private void Casella_MouseClick(object sender, MouseEventArgs e)
        {
            this.Enabled = false;
            string path;

            path = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\TrisLibrary\Resurces\" + (g.Player ? "O" : "X") + ".png";
            BackgroundImage = Image.FromFile(path);
            g.Player = !g.Player;
        }

    }
}
