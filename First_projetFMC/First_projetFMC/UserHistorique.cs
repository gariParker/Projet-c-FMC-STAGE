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
    public partial class UserHistorique : UserControl
    {
        private string connectionString = DatabaseConnexion.ConnexionString;
        private ClassPersonnel EmployeesHisto;
        public UserHistorique()
        {
            InitializeComponent();
        }

        private void BtnHistoHier_Click(object sender, EventArgs e)
        {
            DateTime hier = DateTime.Now.AddDays(-1);
            DateTime debutJour = new DateTime(hier.Year, hier.Month, hier.Day, 0, 0, 0);
            DateTime finJour = new DateTime(hier.Year, hier.Month, hier.Day, 23, 59, 59);

            FilterDataByDate(debutJour, finJour);
        }
        //Fonction pour filtrer
        // Méthode pour filtrer les données par date
        private void FilterDataByDate(DateTime startDate, DateTime endDate)
        {
            // Obtenir les données de la base de données (vous pouvez utiliser votre propre méthode pour cela)
            DataTable employeeData = EmployeesHisto.ReadAllItemsHistoNantenaina();

            // Appliquer le filtre à la DataTable en utilisant DataView
            DataView dataView = employeeData.DefaultView;
            dataView.RowFilter = $"Date_modify >= '{startDate.ToString("yyyy-MM-dd")}' AND Date_modify <= '{endDate.ToString("yyyy-MM-dd")}'";

            // Lier la DataView filtrée au DataGridView pour afficher les données filtrées
            dataGridViewHistoriqueAction.DataSource = dataView;
        }

        //Fonction pour rafraichir le dataGridView
        public void RafraichirdataGridDansHisto()
        {
            EmployeesHisto = new ClassPersonnel();
            // Récupérer les données de la base de données
            DataTable employeeData = EmployeesHisto.ReadAllItemsHistoNantenaina();
            // Lier les données au DataGridView pour les afficher
            dataGridViewHistoriqueAction.DataSource = employeeData;

            ///////////////////////////////////////////////////////////////
            // Ajuster la largeur des colonnes pour remplir toute la largeur du DataGridView
            dataGridViewHistoriqueAction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Activer la barre de défilement vertical
            dataGridViewHistoriqueAction.ScrollBars = ScrollBars.Both;

            // Activer la barre de défilement vertical lorsque le contenu dépasse la hauteur de la zone d'affichage
            dataGridViewHistoriqueAction.ScrollBars |= (employeeData.Rows.Count > dataGridViewHistoriqueAction.DisplayedRowCount(false)) ? ScrollBars.Vertical : ScrollBars.None;

            // Personnaliser le style si nécessaire
            // Par exemple :
            dataGridViewHistoriqueAction.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewHistoriqueAction.DefaultCellStyle.BackColor = Color.White;
            dataGridViewHistoriqueAction.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Chargement de dataGridView dans l'userControl Historique
        private void UserHistorique_Load(object sender, EventArgs e)
        {
            RafraichirdataGridDansHisto();
        }
        //Fonction pour afficher l'historique du jour
        private void BtnHistoJour_Click(object sender, EventArgs e)
        {
            DateTime aujourdHui = DateTime.Now.Date; // Obtenir la date d'aujourd'hui à minuit

            FilterDataByDate(aujourdHui, aujourdHui.AddDays(1).AddSeconds(-1));
        }
        //Fonction pour afficher l'historique de la semaine passé
        private void BtnHistoSemaine_Click(object sender, EventArgs e)
        {
            DateTime aujourdHui = DateTime.Now.Date; // Aujourd'hui à minuit
            DayOfWeek premierJourSemaine = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;

            int joursDepuisDebutSemaine = (aujourdHui.DayOfWeek - premierJourSemaine + 7) % 7;
            DateTime debutSemainePassee = aujourdHui.AddDays(-joursDepuisDebutSemaine - 7).Date;
            DateTime finSemainePassee = debutSemainePassee.AddDays(6).Date.AddSeconds(86399); // Fin de la semaine à 23:59:59

            FilterDataByDate(debutSemainePassee, finSemainePassee);
        }
        //Fonction pour afficher l'historique du mois dernier
        private void BtnHistoMois_Click(object sender, EventArgs e)
        {
            DateTime aujourdHui = DateTime.Now.Date; // Aujourd'hui à minuit
            DateTime debutMoisActuel = new DateTime(aujourdHui.Year, aujourdHui.Month, 1);
            DateTime debutMoisPasse = debutMoisActuel.AddMonths(-1);

            DateTime finMoisPasse = debutMoisActuel.AddDays(-1); // Fin du mois précédent à 23:59:59

            FilterDataByDate(debutMoisPasse, finMoisPasse);
        }
       
        private void BtnHistoTous_Click(object sender, EventArgs e)
        {
            RafraichirdataGridDansHisto();
        }
        //Fonction pour rafraichir histo
        private void LogoRafraichirHisto_Click(object sender, EventArgs e)
        {
            RafraichirdataGridDansHisto();
        }

        //Fonction pour la spécification de la datetime Picker
        private void DateDansHistorique_ValueChanged(object sender, EventArgs e)
        {
            // Récupérer la date sélectionnée dans le DateTimePicker
            DateTime selectedDate = DateDansHistorique.Value.Date;

            // Calculer le début de la journée sélectionnée (minuit)
            DateTime debutJour = selectedDate.Date;

            // Calculer la fin de la journée sélectionnée (23:59:59)
            DateTime finJour = selectedDate.Date.AddDays(1).AddSeconds(-1);

            // Filtrer les données en utilisant la date sélectionnée comme critère
            FilterDataByDate(debutJour, finJour);
        }
    }
}
