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
    public partial class Administrateurs : Form
    {
        public Administrateurs()
        {
            InitializeComponent();
        }

        private ClassPersonnel Employees;

        //Bouton pour afficher la form Affichage pour l'Admin
        private void BtnControlerAffichage_Click(object sender, EventArgs e)
        {          
            userAffichage1.BringToFront();
            userAffichage1.Show();
            userHistorique1.Hide();
            PanelParent.Visible = false;
        }

        //Bouton pour afficher la form Ajout de l'utilisateur (pour l'Administrateur)
        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            PanelParent.Visible = true;
            userAffichage1.Hide();
            userHistorique1.Hide();
        }

        //Bouton pour afficher la form Historique pour l'Admin
        private void BtnHistoriqueAdmin_Click(object sender, EventArgs e)
        {
            userHistorique1.BringToFront();
            userHistorique1.Show();
            userAffichage1.Hide();
            PanelParent.Hide();
        }

        UserAffichage userAffichage;
        //Chargement de la form Administrateur
        private void Administrateurs_Load(object sender, EventArgs e)
        {
            userAffichage = new UserAffichage();
            PanelParent.Hide();
            userAffichage.Hide();
            //userHistorique1.Hide();
      

            // Initialiser les valeurs du ComboBox (ComboPrincipale)
            ComboPrincipale.Items.AddRange(new string[] { "Pasteurs de la FMC", "Pionniers FMC", "Administrateur et département de la FMC",
            "Personnel de Bureau FMC"});

                
        }

        private void BtnAcceuilAdmin_Click_1(object sender, EventArgs e)
        {
            PanelParent.Visible=false;
            userHistorique1.Hide();
            userAffichage1.Hide();
        }

        //Fonction pour importer la photo dans le poste du travail
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

        //Fonction pour le bouton (Enregistrer) dans la base de donnée
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
                string.IsNullOrWhiteSpace(TextBoxTelephone.Text) ||
                string.IsNullOrWhiteSpace(TextBoxEmail.Text) )
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
            ComboPrincipale.Text = "";
            ComboFonctionSecondaire.Text = "";
            TextboxFonction.Clear();
            TextBoxDistrict.Clear();
            TextBoxTelephone.Clear();
            TextBoxEmail.Clear();
            PictureBoxImage.Image = null;
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
            }
            // Vérifier si l'élément sélectionné est "Pasteur de la FMC"
            if (ComboPrincipale.Text == "Pasteurs de la FMC" || ComboPrincipale.Text == "Pionniers FMC")
            {

               

                // Masquer le contrôle ComboFonctionSecondaire
                ComboFonctionSecondaire.Enabled = false;

                // Masquer le contrôle TextboxFonction
                TextboxFonction.Enabled = false;
                TextBoxDistrict.Enabled = true;
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

        private void retourDeconnexion_Click(object sender, EventArgs e)
        {
            FormChoix fo = new FormChoix();
            fo.Show();
            this.Hide();
        }

    }
}
