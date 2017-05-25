using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrisLibrary;

namespace Tris
{
    public partial class Game : Form
    {
        Casella[,] griglia;
        public TrisLibrary.Tris Tris { get; set; }

        private const int ALTEZZ_INIZ = 60;
        private const int MISURA = 100;
        private bool flag;
        public bool Player { get; set;}

        public string Player1 { get; set; }
        public string Player2 { get; set; }


        public Game()
        {
            InitializeComponent();
            griglia = new Casella[3,3];
            Tris = new TrisLibrary.Tris();
            myClockLabel.Start();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            if (!flag)
            {
                flag = true;
                myTimerLabel1.Start();
            }

            Button clickedButton = (Button)sender;

            string str = string.Copy(clickedButton.Name);
            string[] partstr = str.Split('_');
            int i = int.Parse(partstr[0]);
            int j = int.Parse(partstr[1]);

            Tris.Table[i, j] = Player ? -1 : 1;
            bool v = Tris.isVictory();

            if (v)
            {
                myTimerLabel1.Stop();
                disattivaBottoni();
                string message = string.Format("{0} ha vinto\n{1} vuoi la rivincita?", Player ? Player1 : Player2, Player ? Player2 : Player1);
                DialogResult dr = MessageBox.Show(message, "rivincita", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.No:
                        this.Close();
                        break;
                    case DialogResult.Yes:
                        refreshPartita();
                        break;
                }
            }
                

        }

        private void disattivaBottoni()
        {
            foreach (Casella c in griglia)
                c.Enabled = false;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            myClockLabel.Stop();
            myTimerLabel1.MyDispose();
            this.Dispose();
        }

        private void showCaselle()
        {
            for (int i = 0; i < griglia.GetLength(0); i++)
            {
                for (int j = 0; j < griglia.GetLength(1); j++)
                {
                    griglia[i, j] = new Casella(this, i + "_" + j, MISURA);
                    griglia[i, j].Top = ALTEZZ_INIZ + 3 + (MISURA + 5) * i;
                    griglia[i, j].Left = 3 + (MISURA + 5) * j;

                    griglia[i, j].MouseClick += Game_MouseClick;

                    this.Controls.Add(griglia[i, j]);
                }
            }
        }
        private void refreshPartita()
        {
            foreach (Casella c in griglia)
                Controls.Remove(c);

            griglia = new Casella[3, 3];
            Tris = new TrisLibrary.Tris();
            showCaselle();
            flag = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (textControl())
            {
                saveName();

                playButton.Hide();

                showCaselle();
            }
            else
                MessageBox.Show("inserire i nomi dei giocatori");
        }

        private void saveName()
        {
            Player1 = player1Text.Text;
            Player2 = player2Text.Text;

            player1Text.Enabled = false;
            player2Text.Enabled = false;
        }

        private bool textControl()
        {
            if (player1Text.Text.Equals(string.Empty) && player2Text.Text.Equals(string.Empty))
                return false;

            return true;
        }
    }
}
