using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ConservatoireMVC.Modèles;

namespace ConservatoireMVC.Contrôleurs
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}
