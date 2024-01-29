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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private ClassLogin dataConnection;
        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNameAdmin_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxNameAdmin.Text == "Votre nom")
            {
                TextBoxNameAdmin.Text = "";
                TextBoxNameAdmin.ForeColor = Color.Silver;
            }
        }

        private void TextBoxNameAdmin_MouseLeave(object sender, EventArgs e)
        {
            if (TextBoxNameAdmin.Text == "")
            {
                TextBoxNameAdmin.Text = "Votre nom";
                TextBoxNameAdmin.ForeColor = Color.Silver;
            }
        }

        private void TextBoxMdpAdmin_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxMdpAdmin.Text == "Mot de passe")
            {
                TextBoxMdpAdmin.Text = "";
                TextBoxMdpAdmin.ForeColor = Color.Silver;
            }
        }

        private void TextBoxMdpAdmin_MouseLeave(object sender, EventArgs e)
        {
            if (TextBoxMdpAdmin.Text == "")
            {
                TextBoxMdpAdmin.Text = "Mot de passe";
                TextBoxMdpAdmin.ForeColor = Color.Silver;
            }
        }

        //Bouton pour rediriger vers la form Administrateur
        private void SeConnectAdministrateur_Click(object sender, EventArgs e)
        {
            string nom = TextBoxNameAdmin.Text;
            string PassWord = TextBoxMdpAdmin.Text;
            dataConnection = new ClassLogin();
            dataConnection.SeConnecterNantenaina(nom, PassWord);
            bool DisoMdp = ClassLogin.NoMdp;
            if (DisoMdp == true)
            {
                LblIncorrecte.Text = "Authentification incorrect";
                return;
            }
            this.Close();
        }

        private void BtnAnnulerAdmin_Click(object sender, EventArgs e)
        {
            FormChoix formchoix = new FormChoix();
            formchoix.Show();
            this.Show();
        }
    }
}
