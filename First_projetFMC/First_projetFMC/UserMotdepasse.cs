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
    public partial class UserMotdepasse : UserControl
    {
        public UserMotdepasse()
        {
            InitializeComponent();
        }

        ClassLogin Login;

        void RafraichirLog()
        {
            Login = new ClassLogin();
            DataTable LoginData = Login.ReadAllItems();

            // Lier les données au DataGridView pour les afficher
            dataGridViewMotdePasse.DataSource = LoginData;
            // Ajuster la largeur des colonnes pour remplir toute la largeur du DataGridView
            dataGridViewMotdePasse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Activer la barre de défilement vertical
            dataGridViewMotdePasse.ScrollBars = ScrollBars.Both;

            // Activer la barre de défilement vertical lorsque le contenu dépasse la hauteur de la zone d'affichage
            dataGridViewMotdePasse.ScrollBars |= (LoginData.Rows.Count > dataGridViewMotdePasse.DisplayedRowCount(false)) ? ScrollBars.Vertical : ScrollBars.None;

            // Personnaliser le style si nécessaire
            // Par exemple :
            dataGridViewMotdePasse.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewMotdePasse.DefaultCellStyle.BackColor = Color.White;
            dataGridViewMotdePasse.DefaultCellStyle.ForeColor = Color.Black;
        }

        //CHARGEMENT DE L'USER pour la gestion demot de passe
        private void UserMotdepasse_Load(object sender, EventArgs e)
        {
            PanelAjoutMotDePasse.Visible = false;
            PanelModificationMotDePasse.Visible = false;
            RafraichirLog();
        }

        //BOUTON POUR AJOUTER UNE NOUVELLE PERSONNE
        private void BtnEnregistrerMotDePasse_Click(object sender, EventArgs e)
        {

            string Nom = NomMotdePasse.Text;
            string PassWord = TextMotDePasse.Text;
            string Poste = TextTypePersonne.Text;
            Login = new ClassLogin();
            Login.CreateLoginItem(Nom, PassWord, Poste);
            RafraichirLog();
            PanelAjoutMotDePasse.Visible = false;
        }

        //BOUTON retour pour cacher le panel Ajout
        private void BtnFormMdp_Click(object sender, EventArgs e)
        {
            PanelAjoutMotDePasse.Visible = false;
            PanelModificationMotDePasse.Visible = false;
        }

        //BOUTON retour pour cacher le panel Modification
        private void BtnModifierMdpReturn_Click(object sender, EventArgs e)
        {
            PanelAjoutMotDePasse.Visible = false;
            PanelModificationMotDePasse.Visible = false;
        }

        //BOUTON POUR VALIDER LA MODIFICATION
        private void BtnValidationModifier_Click(object sender, EventArgs e)
        {
            Login=new ClassLogin();
            PanelModificationMotDePasse.Visible = false;

            Login.UpdateItem(selectedId, TextBoxNomMod.Text, TextBoxModDePasseMod.Text, TextTypeFonctionMod.Text);
            // Afficher un message de succès
            MessageBox.Show("Modification réussie");
            RafraichirLog();

        }


        int selectedId;
       //bOUTON POUR OUVRIR LE PANEL MODIFICATION
        private void BtnModifierMdp_Click(object sender, EventArgs e)
        {
            PanelAjoutMotDePasse.Visible=false;
            PanelModificationMotDePasse.Visible = true;

            Login = new ClassLogin();

            // Assurez-vous qu'un employé est sélectionné dans le DataGridView
            if (dataGridViewMotdePasse.SelectedRows.Count > 0)
            {
                // Obtenir l'ID de l'employé sélectionné
                //selectedEmployeeId = Convert.ToInt32(dataGridViewModification.SelectedRows[0].Cells["Id_empl"].Value);

                selectedId = Convert.ToInt32(dataGridViewMotdePasse.CurrentRow.Cells[0].Value.ToString());

                // Obtenir les nouvelles valeurs des champs de modification
                ClassAttributLogin employee = Login.getOneLogin(selectedId);
                TextBoxNomMod.Text = employee.NameLog;
                TextBoxModDePasseMod.Text = employee.LoginPrincip;
                TextTypeFonctionMod.Text = employee.TypeFunction;
            }
            else
            {
                MessageBox.Show("Sélectionnez un employé à modifier.");
            }
        }



        //bOUTON POUR OUVRIR LE PANEL AJOUTER
        private void BtnAjouterMotDePasse_Click(object sender, EventArgs e)
        {
            PanelAjoutMotDePasse.Visible = true;
            PanelModificationMotDePasse.Visible = false;
        }

        private void SupprBtn_Click(object sender, EventArgs e)
        {
            Login = new ClassLogin();
            var selectedLogId = Convert.ToInt32(dataGridViewMotdePasse.CurrentRow.Cells[0].Value.ToString());
            ClassAttributLogin Log = Login.getOneLogin(selectedLogId);
            DialogResult result = MessageBox.Show($"Voulez-vous vraiment supprimer {Log.NameLog} ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login.DeleteItem(selectedLogId);
                RafraichirLog();
            }
        }

        private void PanelModificationMotDePasse_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
