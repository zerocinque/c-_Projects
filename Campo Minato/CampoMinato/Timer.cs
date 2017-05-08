using System.Threading;
using System.Windows.Forms;

namespace CampoMinato
{
    public class Timer:TextBox
    {
        public int Tempo { get; set; }
        //private Label label;

        public Timer(/*Label label*/)
        {
            //this.label = label;
            this.Tempo = 0;
        }

        public void conta()
        {
            while (true)
            {
                //Tempo++;
                Text = (Tempo++).ToString();
                Thread.Sleep(1000);
            }
        }
    }
}
