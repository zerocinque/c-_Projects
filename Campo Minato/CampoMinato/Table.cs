using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CampoMinato
{
    public class Table:History
    {
        //attributi
        private Difficulty difficulty;
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Bombs { get; set; }
        public int NCasScoperte { get; set; }
        public int[,] Camp { get; set; }//vale:-1 se c'è la bomba
                                        //      n dove non ce' la bomba dove n è i numero di bombe a contatto di quella casella
        public int[,] User { get; set; }//vale: 0 se l'utente non ha cliccato
                                        //      1 se ha messo la bandierina
                                        //      2 se ha cliccato
                                        //      3 se "cliccato" tramite findNullPoint ma non ancora visualizzato che è stto cliccato
                                        //     -1 se c'era una bomba e ha messo la bandirina
                                        //     -2 se ha cliccato su qulla bomba
                                        //     -3 se c'era una bomba e non aveva cliccato sulla casella

        int[,] spost = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 } };

        //costruttore
        public Table(Difficulty diff):base(diff, 0, 0, false)
        {
            switch (diff)
            {
                case Difficulty.PRINCIPIANTE:
                    Rows = 9;
                    Columns = 9;
                    Bombs = 10;
                    break;
                case Difficulty.INTERMEDIO:
                    Rows = 16;
                    Columns = 16;
                    Bombs = 40;
                    break;
                case Difficulty.ESPERTO:
                    Rows = 16;
                    Columns = 30;
                    Bombs = 99;
                    break;
            }
            Camp = new int[Rows, Columns];
            User = new int[Rows, Columns];
            inizializeTableBomb();
            inizializeTableNumber();
            NCasScoperte = 0;
            base.Total_number_of_mine = Bombs;
            difficulty = diff;
        }

        #region metodi private
        private void inizializeTableNumber()
        {
            for(int i=0; i<Rows; i++)
            {
                for(int j=0; j<Columns; j++)
                {
                    if(!isBomb(new Coordinates(i, j)))
                    {
                        int n = 0;

                        for (int k = 0; k < spost.GetLength(0); k++)
                        {
                            if (isInRange(new Coordinates(i, j), k) && isBomb(new Coordinates(i + spost[k, 0], j + spost[k, 1])))
                            {
                                n++;
                            }
                        }
                        Camp[i, j] = n;
                    }
                }
            }
        }
        private bool isInRange(Coordinates point, int k)
        {
            int x = point.Row + spost[k, 0];
            int y = point.Column + spost[k, 1];
            return x >= 0 && y >= 0 && x < Rows && y < Columns;
        }
        private bool isInRange(Coordinates point)
        {
            int x = point.Row;
            int y = point.Column;
            return x >= 0 && y >= 0 && x < Rows && y < Columns;
        }
        private void inizializeTableBomb()
        {
            Random rand = new Random();
            for(int i=0; i<Bombs; i++)
            {
                Coordinates point = new Coordinates();
                do
                {
                    point.Row = rand.Next(Rows);
                    point.Column = rand.Next(Columns);
                } while (isBomb(point));
                setBomb(point);
            }
        }
        private void setBomb(Coordinates point)
        {
            Camp[point.Row, point.Column] = -1;
        }
        private void newClick(Coordinates point, int x)
        {
            User[point.Row, point.Column] = x;
            NCasScoperte++;
        }
        #endregion

        #region metodi public
        public bool isBomb(Coordinates point)
        {
            return Camp[point.Row, point.Column] == -1;
        }
        public int getNumberBomb(Coordinates point)
        {
            return Camp[point.Row, point.Column];
        }
        public void findNullPoint(Coordinates point)
        {
            if (User[point.Row, point.Column] == 2 || User[point.Row, point.Column] == 3 || User[point.Row, point.Column] == 1)
                return;

            newClick(point, 3);

            if (Camp[point.Row, point.Column] != 0)
                return;

            for(int i=0; i<spost.GetLength(0); i++)
            {
                var newpoint = point;
                newpoint.Row += spost[i, 0];
                newpoint.Column += spost[i, 1];
                if(isInRange(newpoint))
                    findNullPoint(newpoint);
            }

        }
        public void showAllBombs()
        {
            Coordinates point = new Coordinates();
            
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    point.Row = i;
                    point.Column = j;
                    if(isBomb(point) && User[i, j] == 2)//cliccato sulla bomba
                    {
                        User[i, j] = -2;
                    }
                    else if (isBomb(point) && User[i,j] == 0)//bomba non segnata con bandiera
                    {
                        User[i, j] = -3;
                    }
                    else if(isBomb(point) && User[i, j] == 1)//bomba segnata con bandiera
                    {
                        User[i, j] = -1;
                    }
                }
            }
        }
        public bool isVictory()
        {
            if (NCasScoperte == Camp.Length - Total_number_of_mine)
            {
                Win = true;
                return Win;
            }

            Win = true;
            for (int i=0; i<Rows && Win; i++)
            {
                for(int j=0; j<Columns && Win; j++)
                {
                    if (Camp[i, j] == -1 && User[i, j] != 1)
                        Win = false;
                }
            }

            if (Win)
                base.Mines_found = Total_number_of_mine;

            return Win;
        }
        public void newClick(Coordinates point)
        {
            User[point.Row, point.Column] = 2;
            NCasScoperte++;
        }
        public void saveJsonHistory()
        {
            string jsonFilePath = @"C:\Users\Utente\Desktop\ITS\.NET C#\CampoMinato\CampoMinato\history\history.json";
            string jsonText = string.Empty;
            if (!File.Exists(jsonFilePath))
            {
                //creare
                using(TextWriter tw = new StreamWriter(jsonFilePath, false))
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    History game = (History)this;
                    jsonText = js.Serialize(game);
                    tw.Write(jsonText);
                    tw.Flush();
                    tw.Dispose();
                }
            }
            else
            {
                //append
                using (TextReader tr = new StreamReader(jsonFilePath))
                {
                    jsonText = tr.ReadToEnd();
                    tr.Dispose();
                }
                //File.Delete(jsonFilePath);
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<History> storico = js.Deserialize<List<History>>(jsonText);
                History game = (History)this;
                storico.Add(game);

                jsonText = js.Serialize(storico);
                if (jsonText[0] != '[')
                    jsonText = string.Concat("[", jsonText);
                //jsonText = js.Serialize(game);
                using(TextWriter tw = new StreamWriter(jsonFilePath, true))
                {
                    tw.Write(jsonText);
                    tw.Flush();
                    tw.Dispose();
                }
            }
        }
        #endregion


    }
}
