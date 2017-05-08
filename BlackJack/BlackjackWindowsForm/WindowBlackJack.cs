using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJackLibrary;

namespace BlackjackWindowsForm
{
    public partial class WindowBlackJack : Form
    {
        public WindowBlackJack()
        {
            InitializeComponent();
        }

        private void WindowBlackJack_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\BlackJackLibrary\Resurces\icon.ico");
            
        }
    }
}
