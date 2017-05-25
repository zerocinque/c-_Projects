using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tris
{
    public partial class TrisWindowMaster : Form
    {
        Game g;

        public TrisWindowMaster()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\TrisLibrary\Resurces\icon3.ico");
        }

        private void singlePlayerMenuItem_Click(object sender, EventArgs e)
        {
            if (g != null)
                g.Close();
            g = new Game();
            g.MdiParent = this;
            g.Show();
        }

        private void multiplayerMenuItem_Click(object sender, EventArgs e)
        {
            if (g != null)
                g.Close();
            g = new Game();
            g.MdiParent = this;
            g.Show();
        }
    }
}
