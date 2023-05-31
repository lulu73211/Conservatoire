using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConservatoireMVC.Modèles;
using ConservatoireMVC.Vues.Eleve;
using MySql.Data.MySqlClient;

namespace ConservatoireMVC.Vues
{
    public partial class FormModifierEleve1 : Form
    {
        // Liste pour stocker les données des élèves
        private List<ModeleEleve> _eleves;

        public FormModifierEleve1()
        {
            InitializeComponent();
        }

        // Méthode déclenchée lorsque l'événement EleveUpdated est soulevé
        private void FormModifierEleve2_EleveUpdated(object sender, EventArgs e)
        {
            // Créez une instance du service Eleve
            EleveService eleveService = new EleveService(Connexion.ConnectionString);

            // Obtenez la liste mise à jour des élèves
            _eleves = eleveService.ObtenirEleves();

            // Réinitialisez la source de données du ListBox
            lstEleves.DataSource = null;
            lstEleves.DataSource = _eleves;
            lstEleves.DisplayMember = "DisplayInfo";
            lstEleves.ValueMember = "Id_Eleve";
        }

        // Méthode déclenchée lorsque le bouton Modifier est cliqué
        private void Modifier_Click_1(object sender, EventArgs e)
        {
            // Vérifiez si un élève est sélectionné dans la ListBox
            if (lstEleves.SelectedIndex != -1)
            {
                // Obtenez l'index de l'élément sélectionné
                int selectedIndex = lstEleves.SelectedIndex;

                // Obtenez l'élève sélectionné
                ModeleEleve selectedEleve = _eleves[selectedIndex];

                // Obtenez l'ID de l'élève sélectionné
                int selectedEleveId = selectedEleve.Id_Eleve;

                // Créez une instance de FormModifierEleve2 et passez l'ID de l'élève sélectionné
                FormModifierEleve2 formModifierEleve2 = new FormModifierEleve2(selectedEleveId);

                // Abonnez-vous à l'événement EleveUpdated
                formModifierEleve2.EleveUpdated += FormModifierEleve2_EleveUpdated;

                // Affichez le formulaire
                formModifierEleve2.ShowDialog();
            }
            else
            {
                // Affichez un message si aucun élève n'est sélectionné
                MessageBox.Show("Veuillez sélectionner un élève.");
            }
        }

        // Méthode déclenchée lorsque le bouton de retour est cliqué
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Masquez ce formulaire
            this.Hide();
        }

        // Méthode déclenchée lorsque le formulaire est chargé
        private void FormModifierEleve1_Load_1(object sender, EventArgs e)
        {
            // Créez une instance du service Eleve
            EleveService eleveService = new EleveService(Connexion.ConnectionString);

            // Obtenez la liste des élèves
            _eleves = eleveService.ObtenirEleves();

            // Liez la liste des élèves au ListBox
            lstEleves.DataSource = _eleves;
            lstEleves.DisplayMember = "DisplayInfo";
            lstEleves.ValueMember = "Id_Eleve";
        }
    }
}
