using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrisLibrary
{
    delegate void SetTextCallBack(string text);

    public class MyClockLabel : System.Windows.Forms.Label
    {
        private DateTime dateTime;
        private Thread t;
        public bool Flag { get; private set; }

        public void Start()
        {
            t = new Thread(run);
            t.Start();
        }

        private void run()
        {
            Flag = true;
            while (Flag)
            {
                dateTime = DateTime.Now;
                setText(dateTime.ToString("hh:mm:ss"));
                Thread.Sleep(1000);
            } 
        }

        private void setText(string text)
        {
            if(this.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(setText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Text = text;
            }
        }

        public void Stop()
        {
            Flag = false;
            while (t.IsAlive)
                Thread.Sleep(10);
            t.Interrupt();
        }
    }
}
