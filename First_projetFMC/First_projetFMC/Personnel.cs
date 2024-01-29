using First_projetFMC.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_projetFMC
{
    public partial class Personnel : Form
    {

        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        public Personnel()
        {
            InitializeComponent();
        }

        private ClassPersonnel Employeess;

        private void historqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrateurGénéralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void Rafraichissement()
        {
            Employeess = new ClassPersonnel();
            // Récupérer les données de la base de données
            DataTable employeeData = Employeess.ReadAllItemsPersonnel();
            // Lier les données au DataGridView pour les afficher
            dataGridViewPers.DataSource = employeeData;

            ///////////////////////////////////////////////////////////////
            // Ajuster la largeur des colonnes pour remplir toute la largeur du DataGridView
            dataGridViewPers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Activer la barre de défilement vertical
            dataGridViewPers.ScrollBars = ScrollBars.Both;

            // Activer la barre de défilement vertical lorsque le contenu dépasse la hauteur de la zone d'affichage
            dataGridViewPers.ScrollBars |= (employeeData.Rows.Count > dataGridViewPers.DisplayedRowCount(false)) ? ScrollBars.Vertical : ScrollBars.None;

            // Personnaliser le style si nécessaire
            // Par exemple :
            dataGridViewPers.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewPers.DefaultCellStyle.BackColor = Color.White;
            dataGridViewPers.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Fonction fanampiny
        void rechercherTool(string Search)
        {
            Employeess = new ClassPersonnel();
            // Récupérer les données de la base de données
            DataTable employeeData = Employeess.ReadFunctionItems(Search);
            // Lier les données au DataGridView pour les afficher
            dataGridViewPers.DataSource = employeeData;
        }
        private void sécuritéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Sécurité");
        }

        private void vaguemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Vaguemestre");
        }

        private void verificateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Verificateur");
        }

        private void personnelRadioOASISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Personnel Radio OASIS");
        }

        private void serviceFiduciaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Service Fiduciaire");
        }

        private void caissierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Caissier");
        }

        private void comptableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Comptable");
        }

        private void femmeDeMenageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Femme de Menage");
        }

        private void résponsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Résponsable");
        }

        private void sécrétaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Sécrétaire");
        }

        private void jardinierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rechercherTool("Jardinier");
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            Rafraichissement();
        }

        // Méthode pour filtrer les données par date
        private void FilterDataByDateHisto(DateTime startDate, DateTime endDate)
        {
            Employeess = new ClassPersonnel();
            // Obtenir les données de la base de données (vous pouvez utiliser votre propre méthode pour cela)
            DataTable employeeData = Employeess.ReadAllItems();

            // Appliquer le filtre à la DataTable en utilisant DataView
            DataView dataView = employeeData.DefaultView;
            dataView.RowFilter = $"Date_modify >= '{startDate.ToString("yyyy-MM-dd")}' AND Date_modify <= '{endDate.ToString("yyyy-MM-dd")}'";

            // Lier la DataView filtrée au DataGridView pour afficher les données filtrées
            dataGridViewPers.DataSource = dataView;
        }

        //Histo par jour
        private void parJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime aujourdHui = DateTime.Now.Date; // Obtenir la date d'aujourd'hui à minuit

            FilterDataByDateHisto(aujourdHui, aujourdHui.AddDays(1).AddSeconds(-1));
        }

        //Histo par Semaine
        private void parMoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime aujourdHui = DateTime.Now.Date; // Aujourd'hui à minuit
            DayOfWeek premierJourSemaine = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;

            int joursDepuisDebutSemaine = (aujourdHui.DayOfWeek - premierJourSemaine + 7) % 7;
            DateTime debutSemainePassee = aujourdHui.AddDays(-joursDepuisDebutSemaine - 7).Date;
            DateTime finSemainePassee = debutSemainePassee.AddDays(6).Date.AddSeconds(86399); // Fin de la semaine à 23:59:59

            FilterDataByDateHisto(debutSemainePassee, finSemainePassee);
        }
        //Histo par Mois
        private void parToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime aujourdHui = DateTime.Now.Date; // Aujourd'hui à minuit
            DateTime debutMoisActuel = new DateTime(aujourdHui.Year, aujourdHui.Month, 1);
            DateTime debutMoisPasse = debutMoisActuel.AddMonths(-1);

            DateTime finMoisPasse = debutMoisActuel.AddDays(-1); // Fin du mois précédent à 23:59:59

            FilterDataByDateHisto(debutMoisPasse, finMoisPasse);
        }

        //TOus l'historique
        private void tousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rafraichissement();
        }

        //Bare de recherche pour les personnels
        private void textBoxReCherchePers_TextChanged(object sender, EventArgs e)
        {
                 Employeess = new ClassPersonnel();
                // Récupérer les données de la base de données
                DataTable employeeData = Employeess.Rechercher(textBoxReCherchePers.Text);
                // Lier les données au DataGridView pour les afficher
                dataGridViewPers.DataSource = employeeData;            
        }

        public void rafrachir()
        {
            try
            {
                string connectionString = DatabaseConnexion.ConnexionString; // Remplacez par votre chaîne de connexion

                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT `Id_empl` as '#ID', `Name_empl`, `FstName_empl`, `Function_principal`, `Function_second`, `Function`, `District`, `NumPhone_empl`, `Email_empl`,`Date_modify` FROM employees ORDER BY Name_empl ASC"; // Remplacez YourTable et ColumnName par vos valeurs réelles
                    command = new MySqlCommand(query, conn);
                    adapter = new MySqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewPers.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void rafrachirPrenoms()
        {

            try
            {
                string connectionString = DatabaseConnexion.ConnexionString; // Remplacez par votre chaîne de connexion

                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT `Id_empl` as '#ID', `Name_empl`, `FstName_empl`, `Function_principal`, `Function_second`, `Function`, `District`, `NumPhone_empl`, `Email_empl`,`Date_modify` FROM employees ORDER BY FstName_empl ASC"; // Remplacez YourTable et ColumnName par vos valeurs réelles
                    command = new MySqlCommand(query, conn);
                    adapter = new MySqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewPers.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //odre alphabétique par nom
        private void ParNomPersonnel_Click(object sender, EventArgs e)
        {
            rafrachir();
        }
        //odre alphabétique par prénoms

        private void parPrenomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rafrachirPrenoms();
        }

        //Ordre par défaut
        private void AffichageParDefaut_Click(object sender, EventArgs e)
        {
            Rafraichissement();
        }

        //Recherche par pionnier
        private void pionnierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
