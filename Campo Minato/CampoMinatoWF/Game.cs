﻿using CampoMinato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinatoWF
{
    public partial class Game : Form
    {
        //costanti
        private const int INITIALLEFT = 7;
        private const int INITIALTOP = 47;
        private const int DIV = 1;
        private const int MISURA = 30;

        //attributi
        private CampoMinato.Table table;
        Button[,] campo;
        private Difficulty diff;
        private bool isPlayng;
        private CampoMinato.Timer timer;
        private Thread count;

        public Game(Difficulty diff)
        {
            InitializeComponent();
            this.diff = diff;
            table = new Table(diff);
            campo = new Button[table.Rows, table.Columns];
            isPlayng = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows; i++)
            {
                for (int j = 0; j < table.Columns; j++)
                {
                    campo[i,j] = new Button();
                    campo[i, j].BackColor = Color.Gray;

                    campo[i, j].Width = MISURA;
                    campo[i, j].Height = MISURA;

                    campo[i, j].Left = INITIALLEFT + (MISURA + DIV)* j;
                    campo[i, j].Top = INITIALTOP + (MISURA + DIV) * i;
                    campo[i, j].Name = "campo_" + i + "_" + j;

                    campo[i, j].Font = new Font(campo[i, j].Font, FontStyle.Bold);

                    campo[i, j].MouseUp += Game_MouseUp;
                    

                    this.Controls.Add(campo[i, j]);
                }
            }

            CampoMinato.Timer TXTTime = new CampoMinato.Timer();
            TXTTime.Location = new System.Drawing.Point(173, 12);
            TXTTime.Name = "TXTTime";
            this.Controls.Add(TXTTime);

            //timer = new CampoMinato.Timer();
            count = new Thread(TXTTime.conta);


            TXTBomb.Text = table.Bombs.ToString();
            
            Application.DoEvents();
            
            //startTimer();
            
        }

        private void Game_MouseUp(object sender, MouseEventArgs e)
        {
            #region inizializzazione variabili
            Button clickedButton = (Button)sender;
            
            string str = string.Copy(clickedButton.Name);
            string[] partstr = str.Split('_');
            Coordinates point = new Coordinates();
            point.Row = int.Parse(partstr[1]);
            point.Column = int.Parse(partstr[2]);
            #endregion

            if (table.User[point.Row, point.Column] == 2) { return; }//se casella gia stata cliccata non fa nulla

            table.Number_of_moves++;

            if (!isPlayng)
            {
                isPlayng = true;
                count.Start();

            }

            switch (e.Button)
            {
                case MouseButtons.Left:
                    clickedButton.FlatStyle = FlatStyle.Flat;

                    int n = table.getNumberBomb(point);
                    if (n == 0)
                    {
                        table.findNullPoint(point);
                        showNullPoint();
                    }
                    else
                    {
                        table.newClick(point);

                        if (table.isBomb(point))
                        {
                            #region cliccato su bomba
                            MessageBox.Show("BOOM!! Hai perso!");
                            count.Abort();
                            isPlayng = false;
                            table.Time_taken = timer.Tempo;
                            table.showAllBombs();
                            table.Mines_found = 0;
                            for (int i = 0; i < table.Rows; i++)
                            {
                                for (int j = 0; j < table.Columns; j++)
                                {
                                    campo[i, j].FlatStyle = FlatStyle.Flat;
                                    campo[i, j].Enabled = false;
                                    if (table.User[i, j] == -1)
                                        table.Mines_found++;

                                    rivelaCasella(i, j);
                                }
                            }
                            table.saveJsonHistory();
                            #endregion
                        }
                        else
                        {
                            #region cliccato su casella libera

                            clickChange(clickedButton, n);

                            #endregion
                        }
                    }
                    break;

                case MouseButtons.Right:
                    #region messo/tolto bandiera
                    if (table.User[point.Row, point.Column] == 0 && table.Bombs > 0)
                    {
                        table.User[point.Row, point.Column] = 1;
                        clickedButton.BackgroundImage = Image.FromFile(@"C:\Users\Utente\Desktop\ITS\.NET C#\CampoMinato\CampoMinato\img\flag_red.png");
                        table.Bombs--;
                        bombRefresh();
                    }
                    else if(table.User[point.Row, point.Column] == 1)
                    {
                        table.User[point.Row, point.Column] = 0;
                        clickedButton.BackgroundImage = null;
                        table.Bombs++;
                        bombRefresh();
                    }
                    #endregion
                    break;
            }
            #region vittoria?
            
            if (table.isVictory())
            {
                isPlayng = false;
                count.Abort();
                table.Time_taken = timer.Tempo;
                foreach (Button b in campo)
                {
                    b.Enabled = false;
                }
                MessageBox.Show("CONGRATULAZIONI!!!! Hai vinto!!!");
                table.saveJsonHistory();
            }
            #endregion

        }

        private void rivelaCasella(int i, int j)
        {
            if (table.User[i, j] == -1)
            {
                campo[i, j].ForeColor = Color.Red;
            }
            else if (table.User[i, j] == -2)
            {
                campo[i, j].ForeColor = Color.DarkRed;
                campo[i, j].BackgroundImage = Image.FromFile(@"C:\Users\Utente\Desktop\ITS\.NET C#\CampoMinato\CampoMinato\img\bomb1.png");
            }
            else if (table.User[i, j] == -3)
            {
                campo[i, j].ForeColor = Color.DarkRed;
                campo[i, j].Image = Image.FromFile(@"C:\Users\Utente\Desktop\ITS\.NET C#\CampoMinato\CampoMinato\img\bomb1.png");
            }
            else if (table.User[i, j] == 1)
            {
                campo[i, j].BackgroundImage = null;
                campo[i, j].Image = Image.FromFile(@"C:\Users\Utente\Desktop\ITS\.NET C#\CampoMinato\CampoMinato\img\flag_red.png");
            }
        }

        private void clickChange(Button button, int n)
        {
            button.BackColor = Color.LightGray;

            switch (n)
            {
                case 1:
                    button.ForeColor = Color.Blue;
                    button.Text = n.ToString();
                    break;
                case 2:
                    button.ForeColor = Color.Green;
                    button.Text = n.ToString();
                    break;
                case 3:
                    button.ForeColor = Color.Red;
                    button.Text = n.ToString();
                    break;
                case 4:
                    button.ForeColor = Color.Purple;
                    button.Text = n.ToString();
                    break;
                case 5:
                    button.ForeColor = Color.Brown;
                    button.Text = n.ToString();
                    break;
                case 6:
                    button.ForeColor = Color.Yellow;
                    button.Text = n.ToString();
                    break;
                case 7:
                    button.ForeColor = Color.Orange;
                    button.Text = n.ToString();
                    break;
                case 8:
                    button.ForeColor = Color.Black;
                    button.Text = n.ToString();
                    break;
                case 9:
                    button.ForeColor = Color.Beige;
                    button.Text = n.ToString();
                    break;
            }
        }

        private void showNullPoint()
        {
            for(int i=0; i<table.Rows; i++)
            {
                for(int j=0; j<table.Columns; j++)
                {
                    if(table.User[i, j] == 3)
                    {
                        table.User[i, j] = 2;
                        clickChange(campo[i, j], table.getNumberBomb(new Coordinates(i, j)));
                    }
                }
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            var win = new Game(diff);
            win.Show();
            this.Close();
        }
        private void bombRefresh()
        {
            TXTBomb.Text = table.Bombs.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (timer != null)
            //{
                /*string txt = string.Empty;
                int sec = timer.Tempo % 60;
                int min = (timer.Tempo / 60) % 60;
                int hour = (timer.Tempo / 3600) % 60;
                TXTTime.Text = string.Format("{0}:{1}:{2}", sec, min, hour); */
                //TXTTime.Text = timer.Tempo.ToString();
            //}
        }
    }
}



/* 
 * timer
 * roba dei file
 */ 