using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrisLibrary;

namespace ConsoleApplication1
{
    class TestConsole
    {
        static void Main(string[] args)
        {
            Tris tris = new Tris();
            //MyTimer mt = new MyTimer();
            MyClock mc = new MyClock();

            mc.MyStart();


            tris.Table[0,2] = 1;
            tris.Table[0,1] = 1;
            tris.Table[0,0] = 1;

            Console.WriteLine(tris.isVictory());
            Console.ReadKey();
            mc.Stop();

        }
    }
}
