using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class GameForm : Form
    {

        public string result;
        public static string fResult; // static result 

        public GameForm()
        {
            InitializeComponent();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int numberOfHorses = int.Parse(txtNumberOfHorses.Text);
            int startX = 10;
            int startY = 60;

            Random r = new Random();
            int minSpeed = 5;
            int maxSpeed = 10;
            int minInterval = 200;
            int maxInterval = 600;

            

            for (int i = 0; i < numberOfHorses; i++)
            {
                int speed = r.Next(minSpeed, maxSpeed);
                int interval = r.Next(minInterval, maxInterval);

                Horse h = new Horse(this, pnlFinishLine, interval, speed);
                h.Left = startX;
                h.Top = startY;
                h.Width = 30;
                h.Height = 20;
                h.Text = i.ToString();
                h.IsStarted = true; // enabling the timer 
                this.Controls.Add(h);
                startY += 30; 
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(result); //printing instance result
            //MessageBox.Show(fResult);   // printing static fResult
            MessageBox.Show(Horse.hResult); // printing static hResult
        }
    }
}
