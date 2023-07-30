using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRacingGame
{
    public partial class Form2 : Form
    {
        int roadspeed = 12;
        int traficSpeed;

        public Form2()
        {
            InitializeComponent();
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            picRoadTrack1.Top += roadspeed;
            picRoadTrack2.Top += roadspeed;

            if (picRoadTrack1.Top > 519)
            {
                picRoadTrack1.Top = -519;
            }
            if(picRoadTrack2.Top > 519)
            {
                picRoadTrack2.Top = -300;
            }
        }
    }
}
