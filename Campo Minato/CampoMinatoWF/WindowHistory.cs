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
            Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\CampoMinato\img\icon.ico");
        }

        private void WindowHistory_Load(object sender, EventArgs e)
        {
            try
            {
                txtStorico.Text = History.jsonRead();
            }
            catch (FileNotExistsException)
            {
                MessageBox.Show("Non ci sono partite salvate.");
                this.Close();
            }
        }
    }
}
