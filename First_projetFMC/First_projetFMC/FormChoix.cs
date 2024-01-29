using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_projetFMC
{
    public partial class FormChoix : Form
    {
        public FormChoix()
        {
            InitializeComponent();
        }

        /// Fonction le login personnel(redirection)
        private void choixpers_Click(object sender, EventArgs e)
        {
            LoginPersonnel logper = new LoginPersonnel();
            logper.Show();
            this.Hide();

        }

        private void ChoixAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginadmin = new LoginAdmin();
            loginadmin.Show();
            this.Hide();
        }
    }
}
