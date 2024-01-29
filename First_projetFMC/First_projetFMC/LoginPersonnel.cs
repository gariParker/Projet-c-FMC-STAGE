using First_projetFMC.Class;
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
    public partial class LoginPersonnel : Form
    {
        public LoginPersonnel()
        {
            InitializeComponent();
        }

        private ClassLogin dataConnection;
        private void TextBoxNamePersonnel_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxNamePersonnel.Text == "Nom")
            {
                TextBoxNamePersonnel.Text = "";
                TextBoxNamePersonnel.ForeColor = Color.Silver;
            }
        }

        private void TextBoxNamePersonnel_MouseLeave(object sender, EventArgs e)
        {
            if (TextBoxNamePersonnel.Text == "")
            {
                TextBoxNamePersonnel.Text = "Nom";
                TextBoxNamePersonnel.ForeColor = Color.Silver;
            }
        }

        private void TextBoxMdpPersonnel_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxMdpPersonnel.Text == "Mot de passe")
            {
                TextBoxMdpPersonnel.Text = "";
                TextBoxMdpPersonnel.ForeColor = Color.Silver;
            }
        }

        private void TextBoxMdpPersonnel_MouseLeave(object sender, EventArgs e)
        {
            if (TextBoxMdpPersonnel.Text == "")
            {
                TextBoxMdpPersonnel.Text = "Mot de passe";
                TextBoxMdpPersonnel.ForeColor = Color.Silver;
            }
        }

        //Bouton pour rediriger vers la form choix
        private void BtnCancelPersonnel_Click(object sender, EventArgs e)
        {
            FormChoix formChoixPers = new FormChoix();
            formChoixPers.Show();
            this.Hide();
        }

        private void BtnSeconnectePersonnel_Click(object sender, EventArgs e)
        {
            string nom = TextBoxNamePersonnel.Text;
            string PassWord = TextBoxMdpPersonnel.Text;
            dataConnection = new ClassLogin();
            dataConnection.SeConnecterPublic(nom, PassWord);
            bool DisoMdp = ClassLogin.NoPublicMdp;
            if (DisoMdp == true)
            {
                LblIncorrect.Text = "Le mots de passe est incorrecte";
                return;
            }

            this.Close();
        }
    }
}
