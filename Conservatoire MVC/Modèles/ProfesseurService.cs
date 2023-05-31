using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Globalization;
using ConservatoireMVC.Modèles;

namespace ConservatoireMVC.Modèles
{
    public class ProfesseurService
    {
        // Chaîne de connexion à la base de données
        private string _connectionString;

        // Constructeur qui initialise la chaîne de connexion
        public ProfesseurService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Méthode pour obtenir la liste de tous les professeurs
        public List<Professeur> ObtenirProfesseurs()
        {
            List<Professeur> professeurs = new List<Professeur>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT p.id_professeur, p.nom, p.prenom, DATE_FORMAT(p.date_naissance, '%d/%m/%Y') AS date_naissance_format, p.adresse, p.telephone, p.email, p.salaire, i.nom AS instrument FROM professeurs p JOIN instruments i ON p.id_instrument = i.id_instrument";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Professeur professeur = new Professeur
                        {
                            Nom = reader["nom"].ToString(),
                            Prenom = reader["prenom"].ToString(),
                            DateNaissance = DateTime.ParseExact(reader["date_naissance_format"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            Adresse = reader["adresse"].ToString(),
                            Telephone = reader["telephone"].ToString(),
                            Email = reader["email"].ToString(),
                            Salaire = Convert.ToDecimal(reader["salaire"]),
                            Instrument = reader["instrument"].ToString(),
                            Id = Convert.ToInt32(reader["id_professeur"]),
                        };

                        professeurs.Add(professeur);
                    }
                }
            }

            return professeurs;
        }

        // Méthode pour ajouter un nouveau professeur à la base de données
        public void AjouterProfesseur(Professeur professeur)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO professeurs (nom, prenom, date_naissance, adresse, telephone, email, salaire, id_instrument) VALUES (@nom, @prenom, @date_naissance, @adresse, @telephone, @email, @salaire, @id_instrument)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@nom", professeur.Nom);
                command.Parameters.AddWithValue("@prenom", professeur.Prenom);
                command.Parameters.AddWithValue("@date_naissance", professeur.DateNaissance);
                command.Parameters.AddWithValue("@adresse", professeur.Adresse);
                command.Parameters.AddWithValue("@telephone", professeur.Telephone);
                command.Parameters.AddWithValue("@email", professeur.Email);
                command.Parameters.AddWithValue("@salaire", professeur.Salaire);
                command.Parameters.AddWithValue("@id_instrument", professeur.IdInstrument);

                command.ExecuteNonQuery();
            }
        }

        // Méthode pour supprimer un professeur de la base de données
        public void SupprimerProfesseur(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM professeurs WHERE id_professeur = @id";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }

        // Méthode pour vérifier si un professeur donne des cours
        public bool EstProfesseurDonneCours(int idProfesseur)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM cours WHERE id_professeur = @idProfesseur";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@idProfesseur", idProfesseur);

                int count = Convert.ToInt32(command.ExecuteScalar());

                // Si le compte est supérieur à 0, cela signifie que le professeur donne des cours
                return count > 0;
            }
        }
    }
}
