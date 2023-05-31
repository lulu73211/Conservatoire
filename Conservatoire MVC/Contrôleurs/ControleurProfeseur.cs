using ConservatoireMVC.Modèles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ConservatoireMVC.Contrôleurs
{
    public class ControleurProfesseur
    {
        // Attributs
        private string _connectionString; // Chaîne de connexion à la base de données

        // Constructeur
        public ControleurProfesseur(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Méthode pour ajouter un professeur dans la base de données
        public void AjouterProfesseur(Professeur professeur)
        {
            // Établir la connexion à la base de données
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                // Commande SQL pour ajouter un professeur
                string ordreSql = "INSERT INTO professeurs (nom, prenom, date_naissance, adresse, telephone, email, salaire, id_instrument) VALUES (@nom, @prenom, @date_naissance, @adresse, @telephone, @email, @salaire, @id_instrument)";

                MySqlCommand command = new MySqlCommand(ordreSql, connection);
                // Ajouter les valeurs aux paramètres de la commande
                command.Parameters.AddWithValue("@nom", professeur.Nom);
                command.Parameters.AddWithValue("@prenom", professeur.Prenom);
                command.Parameters.AddWithValue("@date_naissance", professeur.DateNaissance);
                command.Parameters.AddWithValue("@adresse", professeur.Adresse);
                command.Parameters.AddWithValue("@telephone", professeur.Telephone);
                command.Parameters.AddWithValue("@email", professeur.Email);
                command.Parameters.AddWithValue("@salaire", professeur.Salaire);
                command.Parameters.AddWithValue("@id_instrument", professeur.IdInstrument);

                // Exécuter la commande
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour obtenir la liste de tous les professeurs
        public List<Professeur> GetProfesseurs()
        {
            // Initialise la liste des professeurs
            List<Professeur> professeurs = new List<Professeur>();

            // Établir la connexion à la base de données
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                // Commande SQL pour sélectionner tous les professeurs
                string ordreSql = "SELECT p.*, i.nom AS nom_instrument FROM professeurs p LEFT JOIN instruments i ON p.id_instrument = i.id_instrument ORDER BY p.nom";
                MySqlCommand command = new MySqlCommand(ordreSql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                // Parcourir chaque enregistrement de professeur dans la base de données
                while (reader.Read())
                {
                    // Créer une nouvelle instance de Professeur
                    Professeur professeur = new Professeur();

                    // Remplir l'instance avec les informations du professeur
                    professeur.Id = reader.GetInt32("id_professeur");
                    professeur.Nom = reader.GetString("nom");
                    professeur.Prenom = reader.GetString("prenom");
                    professeur.DateNaissance = reader.GetDateTime("date_naissance");
                    professeur.Adresse = reader.GetString("adresse");
                    professeur.Telephone = reader.GetString("telephone");
                    professeur.Email = reader.GetString("email");
                    professeur.Salaire = (decimal)reader.GetFloat("salaire");
                    professeur.IdInstrument = reader.GetInt32("id_instrument");
                    professeur.Instrument = reader["nom_instrument"] == DBNull.Value ? null : reader["nom_instrument"].ToString();

                    // Ajouter l'instance à la liste des professeurs
                    professeurs.Add(professeur);
                }
            }

            // Retourne la liste des professeurs
            return professeurs;
        }

        // Méthode pour obtenir un professeur par son identifiant
        public Professeur GetProfesseurById(int id)
        {
            // Initialise le professeur
            Professeur professeur = null;

            // Établir la connexion à la base de données
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                // Commande SQL pour sélectionner le professeur par son id
                string ordreSql = "SELECT * FROM professeurs WHERE id_professeur = @id";
                MySqlCommand command = new MySqlCommand(ordreSql, connection);
                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();

                // Si un professeur est trouvé
                if (reader.Read())
                {
                    // Créer une nouvelle instance de Professeur
                    professeur = new Professeur();

                    // Remplir l'instance avec les informations du professeur
                    professeur.Id = reader.GetInt32("id_professeur");
                    professeur.Nom = reader.GetString("nom");
                    professeur.Prenom = reader.GetString("prenom");
                    professeur.DateNaissance = reader.GetDateTime("date_naissance");
                    professeur.Adresse = reader.GetString("adresse");
                    professeur.Telephone = reader.GetString("telephone");
                    professeur.Email = reader.GetString("email");
                    professeur.Salaire = (decimal)reader.GetFloat("salaire");
                    professeur.IdInstrument = reader.GetInt32("id_instrument");
                }
            }

            // Retourner le professeur
            return professeur;
        }

        // Méthode pour mettre à jour les informations d'un professeur
        public void UpdateProfesseur(Professeur professeur)
        {
            // Établir la connexion à la base de données
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                // Commande SQL pour mettre à jour les informations du professeur
                string query = "UPDATE Professeurs SET nom = @Nom, prenom = @Prenom, date_naissance = @DateNaissance, adresse = @Adresse, telephone = @Telephone, salaire = @Salaire, email = @Email, id_instrument = @IdInstrument WHERE id_professeur = @id_professeur";

                MySqlCommand command = new MySqlCommand(query, connection);
                // Ajouter les valeurs aux paramètres de la commande
                command.Parameters.AddWithValue("@id_professeur", professeur.Id);
                command.Parameters.AddWithValue("@Nom", professeur.Nom);
                command.Parameters.AddWithValue("@Prenom", professeur.Prenom);
                command.Parameters.AddWithValue("@DateNaissance", professeur.DateNaissance);
                command.Parameters.AddWithValue("@Adresse", professeur.Adresse);
                command.Parameters.AddWithValue("@Telephone", professeur.Telephone);
                command.Parameters.AddWithValue("@Salaire", professeur.Salaire);
                command.Parameters.AddWithValue("@Email", professeur.Email);
                command.Parameters.AddWithValue("@IdInstrument", professeur.IdInstrument);

                // Exécuter la commande
                command.ExecuteNonQuery();
            }
        }
    }
}
