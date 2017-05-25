using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace TrisLibrary
{
    public class MyClock
    {
        public DateTime MyDateTime { get; set; }
        public bool Flag { get; private set; }

        private Thread t;

        public void MyStart()
        {
            t = new Thread(this.run);
            t.Start();
        }

        private void run()
        {
            Flag = true;
            while (Flag)
            {
                MyDateTime = DateTime.Now;
                Console.WriteLine(MyDateTime.ToString("hh:mm:ss"));
                Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            Flag = false;
        }

    }
}