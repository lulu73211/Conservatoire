using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConservatoireMVC.Modèles
{
    internal class ControleurUtilisateur
    {
        private string _connectionString;

        public ControleurUtilisateur(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool VerifierConnexion(string identifiant, string motDePasse)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                // Utilisez des paramètres pour éviter les injections SQL
                string query = "SELECT COUNT(*) FROM Utilisateurs WHERE identifiant = @identifiant AND mdp = @mot_de_passe AND statut = 'admin'";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@identifiant", identifiant);
                    command.Parameters.AddWithValue("@mot_de_passe", motDePasse); // Vous devriez hasher le mot de passe avant de le comparer à la valeur stockée dans la base de données

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
