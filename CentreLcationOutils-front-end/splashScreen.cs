using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CentreLcationOutils_front_end {
    public partial class splashScreen : Form
    {
        Timer tmr;
        public splashScreen()
        {
            InitializeComponent();
        }
            //Use timer class
        
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
      tmr = new Timer();
     //set time interval 3 sec
     tmr.Interval = 3000;
     //starts the timer
     tmr.Start();
     tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
         //after 3 sec stop the timer
            progressBar1.Increment(5);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                tmr.Stop();
                //display mainform
               // AccueilForm accueil = new AccueilForm();
                //accueil.Show();
                //hide this form
                this.Hide();

            }
        }
        }
}