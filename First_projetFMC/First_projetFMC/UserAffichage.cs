using First_projetFMC.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace First_projetFMC
{
    public partial class UserAffichage : UserControl
    {
        private string connectionString = DatabaseConnexion.ConnexionString;
        private ClassPersonnel Employeess;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        ClassAttribut Personnel;
        //Instanciation de la class connection
        DatabaseConnexion dbcon = new DatabaseConnexion();


        public UserAffichage()
        {
            InitializeComponent();
        }
        //Recherche employees 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Employeess = new ClassPersonnel();
            // Récupérer les données de la base de données
            DataTable employeeData = Employeess.Rechercher(TextRechercheAffichage.Text);
            // Lier les données au DataGridView pour les afficher
            dataGridViewModification.DataSource = employeeData;
        }
        //Bouton pour faire la suppréssion
        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            Employeess = new ClassPersonnel();
            var selectedEmployeeId = Convert.ToInt32(dataGridViewModification.CurrentRow.Cells[0].Value.ToString());
            ClassAttribut empl=Employeess.getOneMenu(selectedEmployeeId);
            DialogResult result = MessageBox.Show($"Voulez-vous vraiment supprimer {empl.NameEmpl} ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Employeess.DeleteItem(selectedEmployeeId);
                RafraichirModification();
            }
        }
        //Fonction pour rafraichir le dataGridView
        public void RafraichirModification()
        {
            /*Employeess = new ClassPersonnel();
            // Récupérer les données de la base de données
            DataTable employeeData = Employeess.ReadAllItems();

            // Lier les données au DataGridView pour les afficher
            dataGridViewModification.DataSource = employeeData;

            // Ajuster la largeur des colonnes pour remplir toute la largeur du DataGridView
            dataGridViewModification.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Activer la barre de défilement vertical
            dataGridViewModification.ScrollBars = ScrollBars.Both;

            // Personnaliser le style si nécessaire
            // Par exemple :
            dataGridViewModification.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewModification.DefaultCellStyle.BackColor = Color.White;
            dataGridViewModification.DefaultCellStyle.ForeColor = Color.Black;*/

            Employeess = new ClassPersonnel();
            // Récupérer les données de la base de données
            DataTable employeeData = Employeess.ReadAllItems();

            // Lier les données au DataGridView pour les afficher
            dataGridViewModification.DataSource = employeeData;

            // Ajuster la largeur des colonnes pour remplir toute la largeur du DataGridView
            dataGridViewModification.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Activer la barre de défilement vertical
            dataGridViewModification.ScrollBars = ScrollBars.Both;

            // Activer la barre de défilement vertical lorsque le contenu dépasse la hauteur de la zone d'affichage
            dataGridViewModification.ScrollBars |= (employeeData.Rows.Count > dataGridViewModification.DisplayedRowCount(false)) ? ScrollBars.Vertical : ScrollBars.None;

            // Personnaliser le style si nécessaire
            // Par exemple :
            dataGridViewModification.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewModification.DefaultCellStyle.BackColor = Color.White;
            dataGridViewModification.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Chargement de l'UserAffichage
        private void UserAffichage_Load(object sender, EventArgs e)
        {
            PanelModification.Visible = false;
            LogoRafraichir.Visible = true;
            // Masquer le FlowLayoutPanel par défaut
            flowPanel1.Visible = false;

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

            RafraichirModification();
        }

        //Fonction pour cacher le panel dans la form mofication
        private void BtnRetourPanel_Click(object sender, EventArgs e)
        {
            PanelModification.Visible= false;
            LogoRafraichir.Visible = true;
            BtnImpressionTest2.Visible = true;
            BtnDetailsNantenaina.Visible = true;
        }
        public int selectedEmployeeId;

        public PictureBox PictureBoxLogAdventiste { get; }

        //Fonction pour le bouton modification
        private void BtnUpdateEmployees_Click(object sender, EventArgs e)
        {
            ClassPersonnel empl = new ClassPersonnel();
            BtnImpressionTest2.Visible = false;
            BtnDetailsNantenaina.Visible = false;
          
            // Assurez-vous qu'un employé est sélectionné dans le DataGridView
            if (dataGridViewModification.SelectedRows.Count > 0)
            {
                // Obtenir l'ID de l'employé sélectionné
                //selectedEmployeeId = Convert.ToInt32(dataGridViewModification.SelectedRows[0].Cells["Id_empl"].Value);

                selectedEmployeeId= Convert.ToInt32(dataGridViewModification.CurrentRow.Cells[0].Value.ToString());

                // Obtenir les nouvelles valeurs des champs de modification
                ClassAttribut employee = empl.getOneMenu(selectedEmployeeId);
                TextBoxNamePersonnel.Text = employee.NameEmpl;
                TextBoxPrenoms.Text = employee.FstName;
                ComboPrincipale.Text = employee.FunctionPrincipe;
                ComboFonctionSecondaire.Text = employee.FunctionSecond;
                TextboxFonction.Text = employee.Function;
                TextBoxDistrict.Text = employee.District;
                TextBoxTelephone.Text = employee.NumPhone;
                TextBoxEmail.Text = employee.EmailEmpl;
                PictureBoxImageMod2.Image = employee.Image; // Assurez-vous que l'image est correcte

                // Afficher les nouvelles valeurs dans le panneau
                PanelModification.Visible = true;
                //TextBoxPrenomPanel.Text = prenoms;
                // Continuez pour les autres champs...
            }
            else
            {
                MessageBox.Show("Sélectionnez un employé à modifier.");
            }
            LogoRafraichir.Visible = false;
        }

        //Bouton pour valider la modification
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            // Appeler la méthode UpdateItem pour mettre à jour les données dans la base de données
            Employeess = new ClassPersonnel();            // Vérifier si l'élément sélectionné est "Pasteur de la FMC"
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
            Employeess.UpdateItem(selectedEmployeeId, TextBoxNamePersonnel.Text, TextBoxPrenoms.Text, ComboPrincipale.Text, ComboFonctionSecondaire.Text, TextboxFonction.Text, TextBoxDistrict.Text, TextBoxTelephone.Text, TextBoxEmail.Text, PictureBoxImageMod2.Image);
            // Afficher un message de succès
            MessageBox.Show("Modification réussie");
            RafraichirModification();
        }

        //Bouton pour importer la photo dans la form modification
        private void btnImporterPhotoMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers image (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Afficher l'image dans le PictureBox
                Image image = Image.FromFile(imagePath);
                PictureBoxImageMod2.Image = image;
            }
        }

        private void PanelModification_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoRafraichir_Click(object sender, EventArgs e)
        {
            RafraichirModification();
        }

        //Fonction pour afficher la form impression
        private void BtnImpressionTest2_Click(object sender, EventArgs e)
        {
            //// Créer une instance de Word
            //Word.Application wordApp = new Word.Application();

            //// Créer un nouveau document Word
            //Word.Document doc = wordApp.Documents.Add();

            //// Insérer un tableau dans le document Word
            //Word.Table table = doc.Tables.Add(doc.Range(), dataGridViewModification.Rows.Count + 1, dataGridViewModification.Columns.Count);

            //// Appliquer des bordures à l'extérieur du tableau
            //table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;


            //// Remplir la première ligne du tableau avec les en-têtes des colonnes
            //for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
            //{
            //    table.Cell(1, col + 1).Range.Text = dataGridViewModification.Columns[col].HeaderText;
            //}

            //// Remplir les données du DataGridView dans le tableau
            //for (int row = 0; row < dataGridViewModification.Rows.Count; row++)
            //{
            //    for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
            //    {
            //        table.Cell(row + 2, col + 1).Range.Text = dataGridViewModification.Rows[row].Cells[col].Value.ToString();
            //    }
            //}

            //// Enregistrer le document Word (vous pouvez personnaliser le chemin)
            //string filePath = @"C:\Doc2.docx";
            //doc.SaveAs2(filePath);

            //// Fermer Word
            //wordApp.Quit();

            //MessageBox.Show("Le contenu du DataGridView a été copié dans le document Word.");

            // Créer une instance de Word
            /*Word.Application wordApp = new Word.Application();

            try
            {
                // Créer un nouveau document Word
                Word.Document doc = wordApp.Documents.Add();

                // Insérer un tableau dans le document Word
                Word.Table table = doc.Tables.Add(doc.Range(), dataGridViewModification.Rows.Count + 1, dataGridViewModification.Columns.Count);

                // Appliquer des bordures à l'extérieur du tableau
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                // Remplir la première ligne du tableau avec les en-têtes des colonnes
                for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
                {
                    table.Cell(1, col + 1).Range.Text = dataGridViewModification.Columns[col].HeaderText;
                }

                // Remplir les données du DataGridView dans le tableau
                for (int row = 0; row < dataGridViewModification.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
                    {
                        table.Cell(row + 2, col + 1).Range.Text = dataGridViewModification.Rows[row].Cells[col].Value.ToString();
                    }
                }

                // Enregistrer le document Word
                string filePath = @"C:\Doc2.docx";
                doc.SaveAs2(filePath);

                // Ouvrir le document Word
                wordApp.Visible = true;

                MessageBox.Show("Le contenu du DataGridView a été copié dans le document Word et ouvert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);*/


            //Le mety teo 



            // Créer une instance de Word
            /*Word.Application wordApp = new Word.Application();

            try
            {
                // Créer un nouveau document Word
                Word.Document doc = wordApp.Documents.Add();

                // Insérer un tableau dans le document Word
                Word.Table table = doc.Tables.Add(doc.Range(), dataGridViewModification.Rows.Count + 1, dataGridViewModification.Columns.Count);

                // Appliquer des bordures à l'extérieur et à l'intérieur du tableau
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                // Remplir la première ligne du tableau avec les en-têtes des colonnes
                for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
                {
                    table.Cell(1, col + 1).Range.Text = dataGridViewModification.Columns[col].HeaderText;
                }

                // Remplir les données du DataGridView dans le tableau
                for (int row = 0; row < dataGridViewModification.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
                    {
                        table.Cell(row + 2, col + 1).Range.Text = dataGridViewModification.Rows[row].Cells[col].Value.ToString();
                    }
                }

                // Ajuster la taille du tableau pour qu'elle s'adapte à la page
                table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);

                // Enregistrer le document Word
                string filePath = @"C:\Doc2.docx";
                doc.SaveAs2(filePath);

                // Ouvrir le document Word
                wordApp.Visible = true;

                MessageBox.Show("Le contenu du DataGridView a été copié dans le document Word et ouvert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                // Fermer Word
                //wordApp.Quit();
            }*/

            // Créer une instance de Word
            Word.Application wordApp = new Word.Application();

            try
            {
                // Créer un nouveau document Word
                Word.Document doc = wordApp.Documents.Add();

                // Insérer un tableau dans le document Word
                Word.Table table = doc.Tables.Add(doc.Range(), dataGridViewModification.Rows.Count + 1, dataGridViewModification.Columns.Count);

                // Appliquer des bordures à l'extérieur et à l'intérieur du tableau
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                // Remplir la première ligne du tableau avec les en-têtes des colonnes
                for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
                {
                    table.Cell(1, col + 1).Range.Text = dataGridViewModification.Columns[col].HeaderText;
                }

                // Remplir les données du DataGridView dans le tableau
                for (int row = 0; row < dataGridViewModification.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridViewModification.Columns.Count; col++)
                    {
                        table.Cell(row + 2, col + 1).Range.Text = dataGridViewModification.Rows[row].Cells[col].Value.ToString();
                    }
                }

                // Ajuster la taille du tableau pour qu'elle s'adapte à la page
                table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);

                // Demander à l'utilisateur de spécifier le chemin du fichier Word
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers Word|*.docx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    doc.SaveAs2(filePath);

                    // Ouvrir le document Word
                    wordApp.Visible = true;

                    MessageBox.Show("Le contenu du DataGridView a été copié dans le document Word et ouvert.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                // Fermer Word
                // wordApp.Quit();
            }
        }

        //Fonction pour plus de détails pour chaque employees
        private void BtnDetailsNantenaina_Click(object sender, EventArgs e)
        {
            // Inverser la valeur de la propriété Visible du FlowLayoutPanel
            flowPanel1.Visible = !flowPanel1.Visible;

            ClassPersonnel empl = new ClassPersonnel();

            // Assurez-vous qu'un employé est sélectionné dans le DataGridView
            if (dataGridViewModification.SelectedRows.Count > 0)
            {
                // Obtenir l'ID de l'employé sélectionné
                var selectedEmployeeId = Convert.ToInt32(dataGridViewModification.CurrentRow.Cells[0].Value.ToString());

                // Obtenir les nouvelles valeurs des champs de modification
                ClassAttribut employee = empl.getOneMenu(selectedEmployeeId);
                NomPersonne.Text = employee.NameEmpl;
                Prenoms.Text = employee.FstName;
                Fonctionlab.Text = employee.FunctionPrincipe;
                labsecondaire.Text = employee.FunctionSecond;
                labFgeneral.Text = employee.Function;
                labdistrict.Text = employee.District;
                LabTelphone.Text = employee.NumPhone;
                labEmail.Text = employee.EmailEmpl;
                PictureDetails.Image = employee.Image; // Assurez-vous que l'image est correcte
            }
            else
            {
                MessageBox.Show("Sélectionnez un employé à modifier.");
            }
        }

        private void BtnRetourDetails_Click(object sender, EventArgs e)
        {
            // Masquer le FlowLayoutPanel par défaut
            flowPanel1.Visible = false;   
        }
    }
    
    
    
}
