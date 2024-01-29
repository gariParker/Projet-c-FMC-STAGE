using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_projetFMC.Class
{
    internal class ClassPersonnel
    {
        private ClassAttribut Personnel;
        //public BindingSource bindingSource;
        private string connectionString = DatabaseConnexion.ConnexionString; // Chaîne de connexion MySQL


        public ClassPersonnel(string connectionString)
        {
            this.connectionString = connectionString;
            //bindingSource = new BindingSource();

        }

        public ClassPersonnel()
        {

        }

        public DataTable Rechercher(string Text)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    string query = "SELECT `Id_empl`, `Name_empl`, `FstName_empl`, `Function_principal`, `Function_second`, `Function`, `District`, `NumPhone_empl`, `Email_empl` FROM `employees` where Id_empl like '%" + Text + "%' or Name_empl like '%" +Text + "%' or FstName_empl like '%" + Text + "%' or Function_principal like '%" + Text + "%' or Function_second like '%" + Text+ "%' or Function_second like '%" + Text + "%' or Email_empl like '%" + Text + "%' or District like '%" + Text + "%'";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }

        public ClassAttribut getOneMenu(int Id)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "SELECT * FROM Employees WHERE Id_empl = @id";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", Id);

                    Personnel = new ClassAttribut();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Personnel.IdEmpl = Convert.ToInt32(reader["Id_empl"]);
                            Personnel.NameEmpl = reader["Name_empl"].ToString();
                            Personnel.FstName = reader["FstName_empl"].ToString();
                            Personnel.FunctionPrincipe = reader["Function_principal"].ToString();
                            Personnel.FunctionSecond = reader["Function_second"].ToString();
                            Personnel.Function = reader["Function"].ToString();
                            Personnel.District = reader["District"].ToString();
                            Personnel.NumPhone = reader["NumPhone_empl"].ToString();
                            Personnel.EmailEmpl = reader["Email_empl"].ToString();
                            byte[] imageData = (byte[])reader["Image_empl"];
                            Personnel.Image = ByteArrayToImage(imageData);
                            Personnel.DateInsert = reader["Date_insert"].ToString();
                            Personnel.DateModify = reader["Date_modify"].ToString();

                        }
                    }
                    return Personnel;
                }
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }

        public void CreateEmployeeItem(string Name, string FstName, string FunctionPrincip, string FunctionSecond, string Function, string District, string NumPhone, string Email, Image image, string Daty)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string DateNow = DateTime.Now.ToString("yyyy-MM-dd");


                int targetWidth = 800;  // Choisissez une largeur appropriée
                int targetHeight = 600; // Choisissez une hauteur appropriée
                // Redimensionner l'image et la convertir en tableau d'octets
                byte[] imageData = ResizeImageAndConvertToByteArray(image, targetWidth, targetHeight);
                // Convertir l'image en tableau d'octets
                //byte[] imageData = ImageToByteArray(image);

                // Utiliser DateTime.ParseExact pour convertir la chaîne en objet DateTime
                DateTime dateEmb = DateTime.ParseExact(Daty, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                string query = "INSERT INTO Employees (Name_empl, FstName_empl, Function_principal, Function_second, Function, District, NumPhone_empl, Email_empl, Image_empl, Date_insert, Date_modify, date_emb) VALUES (@name, @FirstName, @FunctionPrincip, @FunctionSec, @Function, @District, @NumberPhone, @Email,  @imageData, @DateInsert,@Date_modify,@date_emb)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@FirstName", FstName);
                command.Parameters.AddWithValue("@FunctionPrincip", FunctionPrincip);
                command.Parameters.AddWithValue("@FunctionSec", FunctionSecond);
                command.Parameters.AddWithValue("@Function", Function);
                command.Parameters.AddWithValue("@District", District);
                command.Parameters.AddWithValue("@NumberPhone", NumPhone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@imageData", imageData);
                command.Parameters.AddWithValue("@DateInsert", DateNow);
                command.Parameters.AddWithValue("@Date_modify", DateNow);
                command.Parameters.AddWithValue("@date_emb", dateEmb); // Utilisez l'objet DateTime ici

                command.ExecuteNonQuery();
            }
        }


        public int CompteurEmployees()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "select count(*) from Employees";
                MySqlCommand command = new MySqlCommand(query, connection);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        // Méthode pour afficher une image à partir d'un champ BLOB de la table "Menu" dans un PictureBox
        public void DisplayImage(int idPers, PictureBox pictureBox)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Image_empl FROM Employees WHERE Id_empl = @idPersonne";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPersonne", idPers);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] imageData = (byte[])reader["Image_empl"];
                        Image image = ByteArrayToImage(imageData);
                        pictureBox.Image = image;
                    }
                }
            }
        }

        // Méthode utilitaire pour convertir une image en tableau d'octets (byte[])
        //private byte[] ImageToByteArray(Image image)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        return ms.ToArray();
        //    }
        //}

        private byte[] ResizeImageAndConvertToByteArray(Image image, int targetWidth, int targetHeight)
        {
            // Redimensionner l'image à la taille cible
            Image resizedImage = new Bitmap(targetWidth, targetHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, targetWidth, targetHeight);
            }

            // Convertir l'image redimensionnée en tableau d'octets
            using (MemoryStream ms = new MemoryStream())
            {
                resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        // Méthode utilitaire pour convertir un tableau d'octets (byte[]) en image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        // Méthode pour lire tous les articles de la table "Menu" et les afficher dans un DataGridView
        public DataTable ReadFunctionItems(string rechercher)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT `Id_empl` as '#ID', `Name_empl` as 'Nom', `FstName_empl` as 'Prenom', `Function_principal` as 'Fonction Principale', `Function_second` as 'Fonction secondaire', `Function` as 'Fonction', `District`, `NumPhone_empl` as 'Téléphone', `Email_empl` as 'Email',`Date_modify` FROM Employees where Function_second = @rechercher";
                //string query = "SELECT Id, Name, date_insert FROM Employees"; // Assurez-vous que "date_insert" est correct

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@rechercher", rechercher);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        // Méthode pour lire tous les articles de la table "Menu" et les afficher dans un DataGridView
        public DataTable ReadAllItems()
        {

            DataTable dataTable = new DataTable();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT `Id_empl` as 'ID', `Name_empl` as 'Nom', `FstName_empl` as 'Prénom', `Function_principal` as 'Fonction Principale', `Function_second` as 'Fonction Secondaire', " +
                    "`Function` as 'Fonction', `District`, `NumPhone_empl` as 'Téléphone', `Email_empl` as 'Email',`Date_modify` FROM `employees`";
                //string query = "SELECT Id, Name, date_insert FROM Employees"; // Assurez-vous que "date_insert" est correct

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }
        //Fonction pour l'historique de l'administrateur
        public DataTable ReadAllItemsHistoNantenaina()
        {
            DataTable dataTable = new DataTable();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT `Id_empl`, `Name_empl`, `FstName_empl`, `Function_principal`, `Function_second`, `Function`, `District`, `NumPhone_empl`, `Email_empl`, COALESCE(`date_emb`, '') AS `date_emb`,`Date_modify` FROM `employees`";
                //string query = "SELECT Id, Name, date_insert FROM Employees"; // Assurez-vous que "date_insert" est correct

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        //POur les personnels seulement
        public DataTable ReadAllItemsPersonnel()
        {

            DataTable dataTable = new DataTable();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // string query = "SELECT `Id_empl`, `Name_empl`, `FstName_empl`, `Function_principal`, `Function_second`, `Function`, `District`, `NumPhone_empl`, `Email_empl` FROM `employees`";
                string query = "SELECT `Id_empl` as 'ID', `Name_empl` as 'Nom', `FstName_empl` as 'Prénom', `Function_principal` as 'Fonction Principale', `Function_second` as 'Fonction Secondaire', " +
     "`Function` as 'Fonction', `District`, `NumPhone_empl` as 'Téléphone', `Email_empl` as 'Email',`Date_modify` FROM `employees`";


                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }

        // Méthode pour mettre à jour un article dans la table "Employees"
        public void UpdateItem(int employeeId, string name, string firstName, string functionPrincipal, string FunctionSecond, string function, string district, string numPhone, string email, Image image)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (image != null)
                {
                    using (Image tempImage = new Bitmap(image))
                    {
                        // Convertir tempImage en tableau d'octets et effectuer la mise à jour dans la base de données
                        //byte[] imageData = ImageToByteArray(tempImage);


                        int targetWidth = 800;  // Choisissez une largeur appropriée
                        int targetHeight = 600; // Choisissez une hauteur appropriée
                        // Redimensionner l'image et la convertir en tableau d'octets
                        byte[] imageData = ResizeImageAndConvertToByteArray(tempImage, targetWidth, targetHeight);

                        string DateNow = DateTime.Now.ToString("yyyy-MM-dd");

                        string query = "UPDATE Employees SET Name_empl = @Name, FstName_empl = @FirstName, Function_principal = @FunctionPrincipal, " +
                                     "Function_second=@FunctionSec, Function = @Function, District = @District, NumPhone_empl = @NumPhone, Email_empl = @Email, " +
                                    "Image_empl = @Image, Date_modify = @DateModify WHERE Id_empl = @EmployeeId";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@FunctionPrincipal", functionPrincipal);
                            command.Parameters.AddWithValue("@FunctionSec", FunctionSecond);
                            command.Parameters.AddWithValue("@Function", function);
                            command.Parameters.AddWithValue("@District", district);
                            command.Parameters.AddWithValue("@NumPhone", numPhone);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Image", imageData);
                            command.Parameters.AddWithValue("@DateModify", DateNow);
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        // Méthode pour supprimer un article de la table "Employees"
        public void DeleteItem(int idEmpl)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Demander confirmation à l'utilisateur
               
                    // L'utilisateur a confirmé, exécuter la suppression
                    string query = "DELETE FROM Employees WHERE Id_empl = @idEmpl";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@idEmpl", idEmpl);

                    command.ExecuteNonQuery();
                
            }
        }

    }
}
