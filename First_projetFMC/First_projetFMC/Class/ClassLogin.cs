using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_projetFMC.Class
{
    internal class ClassLogin
    {
        private ClassAttributLogin Login;
        private string connectionString = DatabaseConnexion.ConnexionString; // Chaîne de connexion MySQL

        //public static List<ClassAchat> list_des_achats   { get; set; } = new List<ClassAchat>();

        public ClassLogin(string connectionString)
        {
            this.connectionString = connectionString;
            //bindingSource = new BindingSource();

        }

        public ClassLogin()
        {

        }
        public static bool NoMdp = false;
        public void SeConnecterNantenaina(string nom, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string requete = "SELECT COUNT(*) FROM login WHERE Nom_log = '" + nom + "' AND PassWords = '" + password + "'";
                MySqlCommand cmd = new MySqlCommand(requete, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == 1)
                    {
                        LoginAdmin login=new LoginAdmin();
                        login.Close();
                        MessageBox.Show("\t\tBonjour " + nom + "\nSoyer bienvenue dans le système du gestion des ressources humaine", "BIENVENUE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        using (Administrateurs AdminForm = new Administrateurs())
                        {
                            AdminForm.ShowDialog();
                        }

                    }
                    else
                    {
                        //MessageBox.Show("Mot de passe ou nom d'utilisateur Incorrect", "erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        NoMdp = true;
                    }
                }
                reader.Close(); // Fermer le lecteur
                conn.Close(); // Fermer la connexion

            }

        }

        public static bool NoPublicMdp = false;
        public void SeConnecterPublic(string nom, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string requete = "SELECT COUNT(*) FROM login WHERE PassWords = '" + password + "'";
                MySqlCommand cmd = new MySqlCommand(requete, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == 1)
                    {
                        LoginPersonnel login = new LoginPersonnel();
                        login.Close();
                        MessageBox.Show("\t\tBonjour " + nom + "\nSoyer bienvenue dans le système du gestion des ressources humaine", "BIENVENUE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        using (Personnel PersonForm = new Personnel())
                        {
                            PersonForm.ShowDialog();
                        }

                    }
                    else
                    {
                        //MessageBox.Show("Mot de passe ou nom d'utilisateur Incorrect", "erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        NoPublicMdp = true;

                    }
                }
                reader.Close(); // Fermer le lecteur
                conn.Close(); // Fermer la connexion

            }

        }

        public ClassAttributLogin getOneLogin(int Id)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "SELECT * FROM Login WHERE Id_log = @id";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", Id);

                    Login = new ClassAttributLogin();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Login.IdLog = Convert.ToInt32(reader["Id_log"]);
                            Login.NameLog = reader["Nom_log"].ToString();
                            Login.LoginPrincip = reader["PassWords"].ToString();
                            Login.TypeFunction = reader["TypeFunction"].ToString();

                        }
                    }
                    return Login;
                }
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }


        // Méthode pour créer un nouvel article dans la table "Login"
        public void CreateLoginItem(string Name, string PassWord, string TypeFunction)
        {

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //string DateNow = DateTime.Now.ToString("yyyy-MM-dd");

                string query = "INSERT INTO Login (Nom_log, PassWords, TypeFunction) VALUES (@name, @PassWord, @Function)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@PassWord", PassWord);
                command.Parameters.AddWithValue("@Function", TypeFunction);

                command.ExecuteNonQuery();

            }

        }

        public int CompteurLogin()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "select count(*) from Login";
                MySqlCommand command = new MySqlCommand(query, connection);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        // Méthode pour lire tous les articles de la table "Login" et les afficher dans un DataGridView
        public DataTable ReadAllItems()
        {
            DataTable dataTable = new DataTable();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Login";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        // Méthode pour mettre à jour un article dans la table "Login"
        public void UpdateItem(int IdLogin, string name, string passWord, string TypeFunction)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //string DateNow = DateTime.Now.ToString("yyyy-MM-dd");

                string query = "UPDATE Login SET Nom_log = @Name, PassWords = @motsDPasse, TypeFunction = @TypeFonct WHERE Id_log = @IdLogin";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@motsDPasse", passWord);
                    command.Parameters.AddWithValue("@TypeFonct", TypeFunction);
                    command.Parameters.AddWithValue("@IdLogin", IdLogin);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour supprimer un article de la table "Login"
        public void DeleteItem(int idLog)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Login WHERE Id_log = @idLog";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@idLog", idLog);

                command.ExecuteNonQuery();
            }
        }
    }
}
