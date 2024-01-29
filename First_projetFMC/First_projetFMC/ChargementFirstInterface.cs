using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_projetFMC
{
    public partial class ChargementFirstInterface : Form
    {
        System.Timers.Timer timer;
        
        public ChargementFirstInterface()
        {
            InitializeComponent();
        }

        private void CercleChargement_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ChargementFirstInterface_Load(object sender, EventArgs e)
        {
           
            timer = new System.Timers.Timer();
            timer.Start();
            timer.Interval = 50;
            timer.Elapsed += OnTimeEvent;     
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>

            {
                CercleChargement.Value += 1;
                if (CercleChargement.Value == 99)//A chaque 100 tiers on incrémente le séconde en 1
                {
                    FormChoix choix = new FormChoix();
                    choix.Show();
                    timer.Stop();
                    this.Hide();   
                }
            }));
        }
    }
}
