using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ConservatoireMVC.Modèles
{
    public class CoursService
    {
        // Chaîne de connexion à la base de données
        private string _connectionString;

        // Constructeur de la classe qui initialise la chaîne de connexion
        public CoursService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Méthode pour obtenir la liste des cours d'un professeur donné
        public List<Cours> ObtenirCours(int idProfesseur)
        {
            // Initialisation de la liste des cours
            List<Cours> cours = new List<Cours>();

            // Utilisation d'une connexion à la base de données
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                // Ouverture de la connexion
                connection.Open();

                // Définition de l'ordre SQL
                string ordreSql = "SELECT * FROM cours WHERE id_professeur = @idProfesseur";

                // Création d'une commande SQL
                MySqlCommand command = new MySqlCommand(ordreSql, connection);

                // Ajout du paramètre à la commande
                command.Parameters.AddWithValue("@idProfesseur", idProfesseur);

                // Exécution de la commande et obtention d'un lecteur de données
                MySqlDataReader reader = command.ExecuteReader();

                // Lecture des données tant qu'il y en a
                while (reader.Read())
                {
                    // Création d'un nouveau cours et initialisation de ses propriétés
                    Cours unCours = new Cours();
                    unCours.Id = reader.GetInt32("id_cours");
                    unCours.Intitule = reader.GetString("intitule");
                    unCours.Description = reader.GetString("Description");
                    unCours.DateCours = reader.GetDateTime("date");
                    unCours.Heure_Debut = reader.GetString("heure_debut");
                    unCours.Heure_Fin = reader.GetString("heure_fin");
                    unCours.Id_Professeur = Int32.Parse(reader.GetString("id_professeur"));

                    // Ajout du cours à la liste
                    cours.Add(unCours);
                }
            }

            // Retour de la liste des cours
            return cours;
        }
    }
}
