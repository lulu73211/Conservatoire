using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;

namespace ConservatoireMVC.Vues
{
    public partial class FormModifierProfesseur1 : Form
    {
        private List<Professeur> _professeurs;

        // Constructeur de la classe
        public FormModifierProfesseur1()
        {
            InitializeComponent();
        }

        // Méthode appelée lors de la mise à jour d'un professeur
        private void FormModifierProfesseur2_ProfesseurUpdated(object sender, EventArgs e)
        {
            ControleurProfesseur controleurProfesseur = new ControleurProfesseur(Connexion.ConnectionString);
            _professeurs = controleurProfesseur.GetProfesseurs();
            lstmodif.DataSource = null;
            lstmodif.DataSource = _professeurs;
            lstmodif.DisplayMember = "DisplayInfo";
            lstmodif.ValueMember = "Id";
        }

        // Méthode appelée lors du chargement du formulaire
        private void FormModifierProfesseur1_Load(object sender, EventArgs e)
        {
            ControleurProfesseur controleurProfesseur = new ControleurProfesseur(Connexion.ConnectionString);
            _professeurs = controleurProfesseur.GetProfesseurs();
            lstmodif.DataSource = _professeurs;
            lstmodif.DisplayMember = "DisplayInfo";
            lstmodif.ValueMember = "Id";
        }

        // Méthode appelée lors du clic sur le bouton "Modifier"
        private void Modifier_Click(object sender, EventArgs e)
        {
            if (lstmodif.SelectedIndex != -1) // Vérifie qu'un professeur est bien sélectionné
            {
                int selectedIndex = lstmodif.SelectedIndex;
                Professeur selectedProfesseur = _professeurs[selectedIndex];
                int selectedProfesseurId = selectedProfesseur.Id;

                FormModifierProfesseur2 formModifierProfesseur2 = new FormModifierProfesseur2(selectedProfesseurId);
                formModifierProfesseur2.ProfesseurUpdated += FormModifierProfesseur2_ProfesseurUpdated; // Abonnement à l'événement de mise à jour
                formModifierProfesseur2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur."); // Message d'erreur si aucun professeur n'est sélectionné
            }
        }

        // Méthode appelée lors du clic sur le bouton "Fermer"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
