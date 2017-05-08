using CampoMinato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinatoWF
{
    public partial class WindowHistory : Form
    {
        public WindowHistory()
        {
            InitializeComponent();
        }

        private void WindowHistory_Load(object sender, EventArgs e)
        {
            txtStorico.Text = History.jsonRead();
        }
    }
}
