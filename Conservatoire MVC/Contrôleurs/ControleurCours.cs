using ConservatoireMVC.Modèles;
using ConservatoireMVC.Vues;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ConservatoireMVC.Contrôleurs
{
    public class ControleurCours
    {
        // La vue sur laquelle le contrôleur agit
        private VueCours _vue;

        // Le service pour interagir avec la base de données
        private CoursService _service;

        // La chaîne de connexion à la base de données
        private string _connectionString;

        // La classe interne représentant un cours
        public class Cours
        {
            public int Id { get; set; }
            public string Intitule { get; set; }
            public string Description { get; set; }
            public DateTime DateCours { get; set; }
            public string Heure_Debut { get; set; }
            public string Heure_Fin { get; set; }
            public int Id_Professeur { get; set; }
        }

        // Constructeur du contrôleur
        public ControleurCours(VueCours vue, string connectionString)
        {
            _vue = vue;
            _connectionString = connectionString;
            _service = new CoursService(connectionString);
        }

        // Méthode pour ajouter un nouveau cours
        public void AjouterCours(Cours cours)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string ordreSql = "INSERT INTO cours (intitule, description, date, heure_debut, heure_fin, id_professeur) VALUES (@intitule, @description, @date, @heure_debut, @heure_fin, @id_professeur)";

                MySqlCommand command = new MySqlCommand(ordreSql, connection);
                command.Parameters.AddWithValue("@intitule", cours.Intitule);
                command.Parameters.AddWithValue("@description", cours.Description);
                command.Parameters.AddWithValue("@date", cours.DateCours);
                command.Parameters.AddWithValue("@heure_debut", cours.Heure_Debut);
                command.Parameters.AddWithValue("@heure_fin", cours.Heure_Fin);
                command.Parameters.AddWithValue("@id_professeur", cours.Id_Professeur);
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour obtenir la liste de tous les cours
        public List<Cours> ObtenirCours()
        {
            List<Cours> coursList = new List<Cours>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string ordreSql = "SELECT * FROM cours";

                MySqlCommand command = new MySqlCommand(ordreSql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cours cours = new Cours();
                    cours.Id = reader.GetInt32("id_cours");
                    cours.Intitule = reader.GetString("intitule");
                    cours.Description = reader.GetString("description");
                    cours.DateCours = reader.GetDateTime("date");
                    cours.Heure_Debut = reader.GetString("heure_debut");
                    cours.Heure_Fin = reader.GetString("heure_fin");
                    cours.Id_Professeur = reader.GetInt32("id_professeur");

                    coursList.Add(cours);
                }
            }

            return coursList;
        }
    }
}
