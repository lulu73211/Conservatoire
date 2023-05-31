using ConservatoireMVC.Modèles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues.Eleve
{
    public partial class FormSupprimerEleve1 : Form
    {
        private EleveService _eleveService;
        private List<ModeleEleve> _eleves;

        // Déclaration de l'événement EleveSupprime
        public delegate void EleveSupprimeEventHandler(object sender, EventArgs e);
        public event EleveSupprimeEventHandler EleveSupprime;

        public FormSupprimerEleve1()
        {
            InitializeComponent();

            _eleveService = new EleveService(Connexion.ConnectionString);

            // Remplissage de la liste d'élèves lors de l'initialisation du formulaire
            RemplirListeEleves();
        }

        private void RemplirListeEleves()
        {
            // Clear listBox before populating it
            listBox1.Items.Clear();

            // Fetch list of students from the service
            _eleves = _eleveService.ObtenirEleves();

            // Setting the display property for the listBox
            listBox1.DisplayMember = "Nom";

            // Adding all students to the listBox
            foreach (ModeleEleve eleve in _eleves)
            {
                listBox1.Items.Add($"{eleve.Nom} - {eleve.Prenom} - {eleve.Adresse} - {eleve.DateNaissance:dd/MM/yyyy} - {eleve.Telephone} - {eleve.Email} - {eleve.NomInstrument} - {eleve.Id_Eleve}");
            }
        }

        // Triggered when a student is selected in the listBox
        private void listBox1Eleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty implementation; can be filled as per requirement
        }

        // Triggered when the 'Supprimer' button is clicked
        private void buttonSuppEleve_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            // Verifying if a valid student is selected
            if (selectedIndex >= 0 && selectedIndex < _eleves.Count)
            {
                ModeleEleve eleveASupprimer = _eleves[selectedIndex];

                // Checking if the student is enrolled in a course
                if (_eleveService.EstInscritAuCours(eleveASupprimer.Id_Eleve))
                {
                    MessageBox.Show("Impossible de supprimer cet élève car il est déjà inscrit à un cours.");
                }
                else
                {
                    // Asking for user confirmation before deleting the student
                    DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élève ?", "Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        _eleveService.SupprimerEleve(eleveASupprimer.Id_Eleve);

                        // Updating the student list and refreshing the listBox
                        RemplirListeEleves();

                        // Triggering the EleveSupprime event
                        EleveSupprime?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élève à supprimer.");
            }
        }

        // Triggered when the 'Annuler' button is clicked, hides the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
