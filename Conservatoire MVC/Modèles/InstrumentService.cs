using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ConservatoireMVC.Modèles;
using ConservatoireMVC.Contrôleurs;

namespace ConservatoireMVC.Services
{
    // Classe de service pour les opérations liées aux instruments
    public class InstrumentService
    {
        // Chaîne de connexion à la base de données
        private string _connectionString;

        // Constructeur qui initialise la chaîne de connexion
        public InstrumentService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Méthode pour obtenir la liste de tous les instruments
        public List<Instrument> ObtenirInstruments()
        {
            List<Instrument> instruments = new List<Instrument>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                // Requête SQL pour obtenir les informations sur les instruments
                string query = "SELECT id_instrument, nom FROM instruments";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Lecture des données pour chaque instrument
                    int id = Convert.ToInt32(reader["id_instrument"]);
                    string name = reader["nom"].ToString();

                    // Création d'une nouvelle instance de l'objet Instrument et ajout à la liste
                    instruments.Add(new Instrument { Id = id, Nom = name });
                }
            }

            // Renvoie la liste des instruments
            return instruments;
        }
    }
}
