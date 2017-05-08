using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampoMinato;
using System.Windows.Forms;

namespace CampoMinatoWF
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
            CBDifficulty.DataSource = Enum.GetValues(typeof(Difficulty));
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Game game = new Game((Difficulty)CBDifficulty.SelectedItem);
            game.Show();
            this.Hide();
        }
    }
}
