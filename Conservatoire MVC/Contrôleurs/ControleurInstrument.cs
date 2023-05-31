using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ConservatoireMVC.Contrôleurs
{
    public class ControleurInstrument
    {
        // La chaîne de connexion à la base de données
        private string _connectionString;

        // Constructeur du contrôleur
        public ControleurInstrument(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Méthode pour obtenir une liste d'instruments
        public List<Instrument> ObtenirInstruments()
        {
            // Initialise la liste des instruments
            List<Instrument> instruments = new List<Instrument>();

            // Établit une connexion à la base de données
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                // Commande SQL pour sélectionner tous les instruments
                string ordreSql = "SELECT * FROM instruments";
                MySqlCommand command = new MySqlCommand(ordreSql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                // Parcourt chaque instrument dans la base de données
                while (reader.Read())
                {
                    // Crée une nouvelle instance d'Instrument
                    Instrument instrument = new Instrument();

                    // Remplit l'instance avec les informations de l'instrument
                    instrument.Id = reader.GetInt32("id_instrument");
                    instrument.Nom = reader.GetString("nom");

                    // Ajoute l'instance à la liste des instruments
                    instruments.Add(instrument);
                }
            }

            // Retourne la liste des instruments
            return instruments;
        }
    }
}
