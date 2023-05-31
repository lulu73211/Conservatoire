using ConservatoireMVC.Modèles;
using MySql.Data.MySqlClient;
using System;

namespace ConservatoireMVC.Contrôleurs
{
    internal class ControleurEleve
    {
        // La chaîne de connexion à la base de données
        private string _connectionString;

        // Constructeur du contrôleur
        public ControleurEleve(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Méthode pour ajouter un nouvel élève
        public void AjouterEleve(ModeleEleve eleve)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string ordreSql = "INSERT INTO eleves (nom, prenom, date_naissance, adresse, telephone, email, id_instrument) VALUES (@nom, @prenom, @date_naissance, @adresse, @telephone, @email, @id_instrument)";

                MySqlCommand command = new MySqlCommand(ordreSql, connection);
                command.Parameters.AddWithValue("@nom", eleve.Nom);
                command.Parameters.AddWithValue("@prenom", eleve.Prenom);
                command.Parameters.AddWithValue("@date_naissance", eleve.DateNaissance);
                command.Parameters.AddWithValue("@adresse", eleve.Adresse);
                command.Parameters.AddWithValue("@telephone", eleve.Telephone);
                command.Parameters.AddWithValue("@email", eleve.Email);
                command.Parameters.AddWithValue("@id_instrument", eleve.IdInstrument);
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour obtenir un élève par son ID
        public ModeleEleve GetEleveById(int id)
        {
            ModeleEleve eleve = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string ordreSql = "SELECT * FROM eleves WHERE id_eleve = @id";
                    MySqlCommand command = new MySqlCommand(ordreSql, connection);
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        eleve = new ModeleEleve();
                        eleve.Id_Eleve = reader.GetInt32("id_eleve");
                        eleve.Nom = reader.GetString("nom");
                        eleve.Prenom = reader.GetString("prenom");
                        eleve.DateNaissance = reader.GetDateTime("date_naissance");
                        eleve.Adresse = reader.GetString("adresse");
                        eleve.Telephone = reader.GetString("telephone");
                        eleve.Email = reader.GetString("email");
                        eleve.IdInstrument = reader.GetInt32("id_instrument");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return eleve;
        }

        // Méthode pour mettre à jour un élève
        public void UpdateEleve(ModeleEleve eleve)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE eleves SET nom = @Nom, prenom = @Prenom, date_naissance = @DateNaissance, adresse = @Adresse, telephone = @Telephone, email = @Email, id_instrument = @IdInstrument WHERE id_eleve = @id_eleve";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_eleve", eleve.Id_Eleve); // change "@id_professeur" to "@id_eleve"
                command.Parameters.AddWithValue("@Nom", eleve.Nom);
                command.Parameters.AddWithValue("@Prenom", eleve.Prenom);
                command.Parameters.AddWithValue("@DateNaissance", eleve.DateNaissance);
                command.Parameters.AddWithValue("@Adresse", eleve.Adresse);
                command.Parameters.AddWithValue("@Telephone", eleve.Telephone);
                command.Parameters.AddWithValue("@Email", eleve.Email);
                command.Parameters.AddWithValue("@IdInstrument", eleve.IdInstrument);

                command.ExecuteNonQuery();
            }
        }
    }
}
