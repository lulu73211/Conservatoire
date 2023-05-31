using ConservatoireMVC.Contrôleurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ConservatoireMVC.Modèles
{
      public class Professeur
      {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public decimal Salaire { get; set; }
        public string Instrument { get; set; }
        public int Id { get; set; }
        public int IdInstrument { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{Nom} - {Prenom} - {Adresse} - {DateNaissance.ToString("dd/MM/yyyy")} - {Telephone} - {Email} - {Salaire} - {Instrument}";
            }
        }


    }






}
