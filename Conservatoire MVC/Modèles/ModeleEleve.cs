using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConservatoireMVC.Modèles
{
    internal class ModeleEleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int Id_Eleve { get; set; }
        public int IdInstrument { get; set; }
        public string NomInstrument { get; set; }

        // 1 référence avec FormModifEleve1
        public string DisplayInfo
        {
            get
            {
                return $"{Nom} - {Prenom} - {Adresse} - {DateNaissance.ToString("dd/MM/yyyy")} - {Telephone} - {Email} - {NomInstrument}";
            }
        }

    }
};