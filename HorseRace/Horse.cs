using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Namespace that contains all the Windows Forms controls
using System.Windows.Forms;

namespace HorseRace
{
    public class Horse : Button
    {

        public static string hResult;

        private Timer timer;

        private bool isFinished = false;
        private bool isStarted = false;
        private int interval = 100;
        private int displacement = 50;

        private Panel finishLine;

        private GameForm owner;

        public bool IsFinished { get => isFinished; set => isFinished = value; }
        public bool IsStarted
        {
            get
            {
                return isStarted;
            }
            set
            {
                isStarted = value;
                timer.Enabled = isStarted;
            }
        }

        public int Interval { get => interval; set => interval = value; }
        public int Displacement { get => displacement; set => displacement = value; }

        public Horse(GameForm f, Panel finishLine, int interval, int displacement)
        {
            this.owner = f;
            this.finishLine = finishLine;
            this.interval = interval;
            this.displacement = displacement;


            timer = new Timer();
            timer.Interval = this.interval;
            timer.Enabled = isStarted;
            timer.Tick += Timer_Tick;

           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Left += displacement;
            if (!IsFinished)
            {
                if (this.Left + this.Width > finishLine.Left)
                {
                    IsFinished = true;
                    timer.Stop();

                    // update the result;
                    //owner.result += this.Text + "\n";   // accessing instance result declard in GameForm
                    // GameForm.fResult += this.Text + "\n"; // accessing the static result declared in GameForm
                    hResult += this.Text + "\n"; // accessing the static hResult declared in Horse
                }
            }
        }
    }
}
