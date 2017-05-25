using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrisLibrary
{
    delegate void SetTextCallback(string text);

    public class MyTimerLabel : System.Windows.Forms.Label
    {
        private Timer timer;
        private int x = 0;

        public void Start()
        {
            timer = new Timer(myCallBack, null, 0, 1000);
        }

        private void myCallBack(object state)
        {
            x++;
            SetText(this.ToString());
            //Console.WriteLine(x);
        }
        public void Stop()
        {
            x = 0;            
            SetText("00:00");
            MyDispose();
        }

        public void MyDispose()
        {
            timer.Dispose();
        }

        private void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Text = text;
            }
        }

        public override string ToString()
        {
            int s = x % 60;
            int m = x / 60;
            return string.Format("{0}:{1}", m.ToString("00"), s.ToString("00"));
        }
    }
}
