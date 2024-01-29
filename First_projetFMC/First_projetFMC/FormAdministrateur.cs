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
    public partial class FormAdministrateur : Form
    {
        private ClassPersonnel Employees;
        public FormAdministrateur()
        {
            InitializeComponent();
        }
        //CHARGEMENT DE LA FORM ADMINISTRATEUR
        private void FormAdministrateur_Load_1(object sender, EventArgs e)
        {
            PanelParent.Hide();
            userAccueil1.Visible = true;
            userAffichage1.Hide();
            userHistorique1.Hide();
            userMotdepasse1.Hide();

            // Initialiser les valeurs du ComboBox (ComboPrincipale)
            ComboPrincipale.Items.AddRange(new string[] { "Pasteurs de la FMC", "Pionniers FMC", "Administrateur et département de la FMC",
            "Personnel de Bureau FMC"});
        }

        //bouton afficher l'accueil de la form Administrateur
        private void BtnAccueil_Click_1(object sender, EventArgs e)
        {
            PanelParent.Hide();//cacher le panel
            userAccueil1.Visible = true;
            userAffichage1.Hide();
            userHistorique1.Hide();
            userMotdepasse1.Hide();
        }
        //bouton pour ouvrir la formAjout
        private void BtnAjoutFormPanel_Click(object sender, EventArgs e)
        {
            PanelParent.BringToFront();
            PanelParent.Show();
            userAccueil1.Hide();
            userAffichage1.Hide();
            userHistorique1.Hide();
            userMotdepasse1.Hide();
        }

        //bouton pour afficher UserAffichage
        private void BtnControlerAffichage_Click_1(object sender, EventArgs e)
        {
            PanelParent.Hide();//cacher le panel
            userAffichage1.BringToFront();
            userAffichage1.Show();
            userAccueil1.Hide();
            userHistorique1.Hide();
            userMotdepasse1.Hide();
        }

        //bouton pour ouvrir l'userControl Historique
        private void BtnHistoriqueAdmin_Click(object sender, EventArgs e)
        {
            PanelParent.Hide();//cacher le panel
            userHistorique1.BringToFront();
            userHistorique1.Show();
            userAffichage1.Hide();
            userAccueil1.Hide();
            userMotdepasse1.Hide();
        }

        ////bouton pour ouvrir l'userControl gESTION mot de passe
        private void BtnGestionLogin_Click(object sender, EventArgs e)
        {
            PanelParent.Hide();//cacher le panel
            userMotdepasse1.BringToFront();
            userMotdepasse1.Show();
            userAffichage1.Hide();
            userAccueil1.Hide();
            userHistorique1.Hide();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            Employees = new ClassPersonnel();
            // Vérifier si l'élément sélectionné est "Pasteur de la FMC"
            if (ComboPrincipale.Text == "Pasteurs de la FMC" || ComboPrincipale.Text == "Pionniers FMC")
            {
                if (string.IsNullOrWhiteSpace(TextBoxDistrict.Text))
                {
                    MessageBox.Show("Veuillez remplir le District", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(ComboFonctionSecondaire.Text) || string.IsNullOrWhiteSpace(TextboxFonction.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs avant de continuer.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //Vérification pour éviter les champs vides
            if (string.IsNullOrWhiteSpace(TextBoxNamePersonnel.Text) ||
                string.IsNullOrWhiteSpace(TextBoxPrenoms.Text) ||
                string.IsNullOrWhiteSpace(ComboPrincipale.Text) ||
                string.IsNullOrWhiteSpace(TextBoxTelephone.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de continuer.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else//
            {
                // Stockage des noms dans des variables
                string nom = TextBoxNamePersonnel.Text;
                string prenoms = TextBoxPrenoms.Text;
                string fonctionPrincipale = ComboPrincipale.Text;
                string fonctionSecondaire = ComboFonctionSecondaire.Text;
                string fonctionGenerale = TextboxFonction.Text;
                string district = TextBoxDistrict.Text;
                string telephone = TextBoxTelephone.Text;
                string email = TextBoxEmail.Text;
                string datty = DateTimePEmbauche.Value.ToString("yyyy-MM-dd");
                Employees.CreateEmployeeItem(nom, prenoms, fonctionPrincipale, fonctionSecondaire, fonctionGenerale, district, telephone, email, PictureBoxImage.Image, datty);
                MessageBox.Show("Enregistrement avec succès !");
            }

            TextBoxNamePersonnel.Clear();
            TextBoxPrenoms.Clear();
            ComboPrincipale.Text = null;
            ComboFonctionSecondaire.Text = null;
            TextboxFonction.Clear();
            TextBoxDistrict.Clear();
            TextBoxTelephone.Clear();
            TextBoxEmail.Clear();
            PictureBoxImage.Image = null;
        }


        //Bouton pour importer du photo
        private void btnImporterPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers image (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Afficher l'image dans le PictureBox
                Image image = Image.FromFile(imagePath);
                PictureBoxImage.Image = image;
            }
        }

        //FOnction pour le combobox principale (spécification)
        private void ComboPrincipale_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboPrincipale.Text == "Personnel de Bureau FMC")
            {
                ComboFonctionSecondaire.Items.Clear();
                ComboFonctionSecondaire.Items.AddRange(new string[] { "Sécurité",
                "Vaguemestre",
                "Verificateur",
                "Personnel Radio OASIS",
                "Service Fiduciaire",
                "Caissier",
                "Comptable",
                "Femme de Menage",
                "Résponsable",
                "Sécrétaire",
                "Jardinier"});
                // Masquer le contrôle ComboFonctionSecondaire
                ComboFonctionSecondaire.Enabled = true;
                TextBoxDistrict.Text = "";
            }

            if (ComboPrincipale.Text == "Administrateur et département de la FMC")
            {
                ComboFonctionSecondaire.Items.Clear();
                ComboFonctionSecondaire.Items.AddRange(new string[] { "Admnistrateur Général",
                    "Département plein Temps",
                    "Département Benevoles",
                    });
                // Masquer le contrôle ComboFonctionSecondaire
                ComboFonctionSecondaire.Enabled = true;
                TextBoxDistrict.Text = "";
            }
            // Vérifier si l'élément sélectionné est "Pasteur de la FMC"
            if (ComboPrincipale.Text == "Pasteurs de la FMC" || ComboPrincipale.Text == "Pionniers FMC")
            {



                // Masquer le contrôle ComboFonctionSecondaire
                ComboFonctionSecondaire.Enabled = false;

                // Masquer le contrôle TextboxFonction
                TextboxFonction.Enabled = false;
                TextBoxDistrict.Enabled = true;
                ComboFonctionSecondaire.Text = null;
                TextboxFonction.Text = "";
            }
            else
            {
                // Afficher le contrôle ComboFonctionSecondaire
                ComboFonctionSecondaire.Enabled = true;
                ComboFonctionSecondaire.BackColor = Color.LightGray;
                // Afficher le contrôle TextboxFonction
                TextboxFonction.Enabled = true;
                TextBoxDistrict.Enabled = false;
                TextboxFonction.BackColor = Color.LightGray;

            }
        }

        //Fonction deconnecter
        private void retourDeconnexion_Click(object sender, EventArgs e)
        {
            LoginAdmin admin = new LoginAdmin();
            admin.Close();
            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Confirmation de déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier si l'utilisateur a cliqué sur "Oui"
            if (result == DialogResult.Yes)
            {
                // Créer une nouvelle instance de FormChoix
                FormChoix fo = new FormChoix();

                // Afficher la nouvelle fenêtre FormChoix
                fo.Show();

                // Cacher la fenêtre actuelle (this)
                this.Hide();
            }
        }

        //Picture BOx pour fermer le logiciel Totalement
        private void FermerTotalementLogiciel_Click(object sender, EventArgs e)
        {
            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Voulez-vous fermer ce logiciel Totalement", "Confirmation de déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            // Vérifier si l'utilisateur a cliqué sur "Oui"
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
