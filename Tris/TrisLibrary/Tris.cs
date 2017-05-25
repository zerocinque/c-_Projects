using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrisLibrary
{
    public class Tris
    {
        public int[,] Table { get; set;}

        public Tris()
        {
            Table = new int[3,3];
            Table.Initialize();
        }

        public bool isVictory()
        {
            int[] rows = new int[3];
            rows.Initialize();
            int[] columns = new int[3];
            columns.Initialize();
            int[] diagonals = new int[3];
            diagonals.Initialize();

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    rows[i] += Table[i,j];
                    columns[j] += Table[i,j];
                    if(i==j)
                        diagonals[0] += Table[i,j];
                    if(i+j==2)
                        diagonals[1] += Table[i,j];
                }
            }
            
            for(int i=0; i<3; i++)
            {
                rows[i] +=  rows[i]<0 ? 6 : 0;
                columns[i] +=  columns[i]<0 ? 6 : 0;
                diagonals[i] +=  diagonals[i]<0 ? 6 : 0;
                if(rows[i] == 3 || columns[i] == 3 || diagonals[i] == 3)
                    return true;
            }

            return false;
        }

        
    }
}
