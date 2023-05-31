using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ConservatoireMVC.Modèles
{
    internal class EleveService
    {
        // Chaîne de connexion à la base de données
        private string _connectionString;

        // Constructeur qui initialise la chaîne de connexion
        public EleveService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Méthode pour obtenir la liste de tous les élèves
        public List<ModeleEleve> ObtenirEleves()
        {
            List<ModeleEleve> eleves = new List<ModeleEleve>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT e.id_eleve, e.nom, e.prenom, DATE_FORMAT(e.date_naissance, '%d/%m/%Y') AS date_naissance_format, e.adresse, e.telephone, e.email, i.nom AS instrument FROM eleves e LEFT JOIN instruments i ON e.id_instrument = i.id_instrument ORDER BY e.nom;\r\n";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModeleEleve eleve = new ModeleEleve
                        {
                            Id_Eleve = Convert.ToInt32(reader["id_eleve"]),
                            Nom = reader["nom"].ToString(),
                            Prenom = reader["prenom"].ToString(),
                            DateNaissance = DateTime.ParseExact(reader["date_naissance_format"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            Adresse = reader["adresse"].ToString(),
                            Telephone = reader["telephone"].ToString(),
                            Email = reader["email"].ToString(),
                            NomInstrument = reader["instrument"] == DBNull.Value ? null : reader["instrument"].ToString(),
                        };

                        eleves.Add(eleve);
                    }
                }
            }

            return eleves;
        }

        // Vérifie si un élève est inscrit à un cours
        public bool EstInscritAuCours(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM eleves_cours WHERE id_eleve = @id";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        // Supprime un élève s'il n'est pas inscrit à un cours
        public void SupprimerEleve(int id)
        {
            if (EstInscritAuCours(id))
            {
                MessageBox.Show("Impossible de supprimer cet élève car il est déjà inscrit à un cours.");
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM eleves WHERE id_eleve = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Récupère les élèves par professeur
        public List<ModeleEleve> ObtenirElevesParProfesseur(int idProfesseur)
        {
            List<ModeleEleve> eleves = new List<ModeleEleve>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"SELECT *
                            FROM eleves E
                            JOIN eleves_cours EC ON E.id_eleve = EC.id_eleve
                            JOIN cours C ON EC.id_cours = C.id_cours
                            JOIN instruments I ON E.id_instrument = I.id_instrument
                            WHERE C.id_professeur = @idProfesseur
                            ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idProfesseur", idProfesseur);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ModeleEleve eleve = new ModeleEleve
                    {
                        Id_Eleve = reader.GetInt32("id_eleve"),
                        Nom = reader.GetString("nom"),
                        Prenom = reader.GetString("prenom"),
                        Telephone = reader.GetString("telephone"),
                        Email = reader.GetString("email"),
                        NomInstrument = reader.GetString("nom"),
                    };

                    eleves.Add(eleve);
                }
            }

            return eleves;
        }

        // Récupère les élèves qui ont payé leur cotisation
        public List<ModeleEleve> ObtenirElevesAyantPaye()
        {
            List<ModeleEleve> elevesAyantPaye = new List<ModeleEleve>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM eleves WHERE cotisation = 1", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ModeleEleve eleve = new ModeleEleve
                            {
                                Id_Eleve = reader.GetInt32(reader.GetOrdinal("Id_Eleve")),
                                Nom = reader.GetString(reader.GetOrdinal("Nom")),
                                Prenom = reader.GetString(reader.GetOrdinal("Prenom")),
                                Adresse = reader.GetString(reader.GetOrdinal("Adresse")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Telephone = reader.GetString(reader.GetOrdinal("Telephone")),
                            };
                            elevesAyantPaye.Add(eleve);
                        }
                    }
                }
            }

            return elevesAyantPaye;
        }

        // Récupère les élèves qui n'ont pas payé leur cotisation
        public List<ModeleEleve> ObtenirElevesNonAyantPaye()
        {
            List<ModeleEleve> elevesNonAyantPaye = new List<ModeleEleve>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM eleves WHERE cotisation = 0", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ModeleEleve eleve = new ModeleEleve
                            {
                                Id_Eleve = reader.GetInt32(reader.GetOrdinal("Id_Eleve")),
                                Nom = reader.GetString(reader.GetOrdinal("Nom")),
                                Prenom = reader.GetString(reader.GetOrdinal("Prenom")),
                                Adresse = reader.GetString(reader.GetOrdinal("Adresse")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Telephone = reader.GetString(reader.GetOrdinal("Telephone")),
                            };
                            elevesNonAyantPaye.Add(eleve);
                        }
                    }
                }
            }

            return elevesNonAyantPaye;
        }
    }
}
