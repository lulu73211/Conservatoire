using ConservatoireMVC.Modèles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues
{
    public partial class FormSupprimerProfesseur1 : Form
    {
        private VuePrincipale _vuePrincipale;
        private ProfesseurService _professeurService;
        private List<Professeur> _professeurs;

        // Déclaration d'un délégué pour un événement qui sera déclenché lors de la suppression d'un professeur
        public delegate void ProfesseurSupprimeEventHandler(object sender, EventArgs e);
        public event ProfesseurSupprimeEventHandler ProfesseurSupprime;

        public FormSupprimerProfesseur1(VuePrincipale vuePrincipale, string connectionString)
        {
            InitializeComponent();
            _vuePrincipale = vuePrincipale;
            _professeurService = new ProfesseurService(connectionString);
        }

        // Méthode pour remplir la ListBox avec la liste des professeurs
        private void RemplirListeProfesseurs()
        {
            // Effacer les éléments actuels de la ListBox
            listBox1.Items.Clear();

            // Récupérer la liste des professeurs
            _professeurs = _professeurService.ObtenirProfesseurs();

            foreach (Professeur professeur in _professeurs)
            {
                listBox1.Items.Add(professeur.Nom + " - " + professeur.Prenom + " - " + professeur.Adresse + " - " + professeur.DateNaissance.ToString("dd/MM/yyyy")
                + " - " + professeur.Telephone + " - " + professeur.Email + " - " + professeur.Salaire + " - " + professeur.Instrument);
            }
        }

        // Méthode appelée lors du clic sur le bouton "Supprimer"
        private void buttonSupp_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            Professeur professeurASupprimer = null;

            if (selectedIndex >= 0 && selectedIndex < _professeurs.Count)
            {
                professeurASupprimer = _professeurs[selectedIndex];

                // Vérifier si le professeur donne un cours avant de le supprimer
                if (_professeurService.EstProfesseurDonneCours(professeurASupprimer.Id))
                {
                    MessageBox.Show("Impossible de supprimer ce professeur car il donne actuellement un cours.");
                    return;
                }

                // Demander à l'utilisateur s'il est sûr de vouloir supprimer le professeur
                DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce professeur ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Appeler la méthode SupprimerProfesseur du service ProfesseurService
                    _professeurService.SupprimerProfesseur(professeurASupprimer.Id);

                    // Mettre à jour la liste des professeurs et rafraîchir la ListBox
                    RemplirListeProfesseurs();

                    // Déclencher l'événement ProfesseurSupprime
                    ProfesseurSupprime?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur à supprimer.");
            }
        }

        // Méthode appelée lors du chargement du formulaire
        private void FormSupprimerProfesseur1_Load(object sender, EventArgs e)
        {
            RemplirListeProfesseurs();
        }

        // Méthode appelée lors du clic sur le bouton "Fermer"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
