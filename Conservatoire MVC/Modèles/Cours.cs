using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ConservatoireMVC.Modèles
{
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

    
}
