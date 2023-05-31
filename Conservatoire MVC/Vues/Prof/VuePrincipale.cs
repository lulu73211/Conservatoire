using ConservatoireMVC.Contrôleurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConservatoireMVC.Vues;
using ConservatoireMVC.Modèles;

namespace ConservatoireMVC
{
    public partial class VuePrincipale : Form
    {
        private ProfesseurService _professeurService;

        public VuePrincipale()
        {
            InitializeComponent();
            _professeurService = new ProfesseurService(Connexion.ConnectionString);
            RemplirListeProfesseurs();
        }

        // Méthode pour remplir la ListBox avec la liste des professeurs
        private void RemplirListeProfesseurs()
        {
            List<Professeur> professeurs = _professeurService.ObtenirProfesseurs();
            lstProfesseurs.DisplayMember = "Nom";

            // Trier les professeurs par le champ 'Nom'
            IEnumerable<Professeur> professeursTries = professeurs.OrderBy(professeur => professeur.Nom);

            foreach (Professeur professeur in professeursTries)
            {
                lstProfesseurs.Items.Add(professeur.Id + " - " + professeur.Nom + " - " + professeur.Prenom + " - " + professeur.Adresse + " - " + professeur.DateNaissance.ToString("dd/MM/yyyy")
                + " - " + professeur.Telephone + " - " + professeur.Email + " - " + professeur.Salaire + " - " + professeur.Instrument);
            }
        }

        // Méthode appelée lors du clic sur le bouton "Quitter"
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Méthode appelée lors de la sélection de "Ajouter un Professeur" dans le menu
        private void ajouterUnProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleurProfesseur controleurProfesseur = new ControleurProfesseur(Connexion.ConnectionString);

            // Afficher le formulaire d'ajout de professeur
            FormAjouterProfesseur1 formAjoutProfesseur = new FormAjouterProfesseur1(controleurProfesseur, Connexion.ConnectionString);
            formAjoutProfesseur.ShowDialog();
            RafraichirListeProfesseurs();
        }

        // Méthode appelée lors de la sélection de "Modifier un Professeur" dans le menu
        private void modifierUnProfesseurToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormModifierProfesseur1 formModifierProfesseur = new FormModifierProfesseur1();
            formModifierProfesseur.ShowDialog();
            RafraichirListeProfesseurs();
        }

        // Méthode appelée lors de la sélection de "Supprimer un Professeur" dans le menu
        private void supprimerUnProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupprimerProfesseur1 formSupprimerProfesseur = new FormSupprimerProfesseur1(this, Connexion.ConnectionString);
            formSupprimerProfesseur.ShowDialog();
            RafraichirListeProfesseurs();
        }

        // Méthode pour rafraîchir la liste des professeurs
        public void RafraichirListeProfesseurs()
        {
            // Effacer les éléments actuels de la ListBox
            lstProfesseurs.Items.Clear();

            // Remplir la ListBox avec les professeurs à jour
            RemplirListeProfesseurs();
        }

        // Méthode appelée lors du clic sur le bouton "Vue Cours"
        private void button1_Click(object sender, EventArgs e)
        {
            if (lstProfesseurs.SelectedItem != null)
            {
                string selectedProfesseurItem = lstProfesseurs.SelectedItem.ToString();
                string selectedId = selectedProfesseurItem.Split(' ')[0];
                int idProfesseur;

                if (int.TryParse(selectedId, out idProfesseur))
                {
                    VueCours formVueCours = new VueCours(idProfesseur);
                    formVueCours.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Le format de l'ID du professeur est incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur.");
            }
        }

        // Méthode appelée lors du clic sur le bouton "Vue Élève"
        private void button2_Click(object sender, EventArgs e)
        {
            EleveView formVueEleve = new EleveView();
            formVueEleve.Show();
            this.Hide();
        }

        // Les méthodes ci-dessous permettent le bon fonctionnement de l'application (ne les modifier ou supprimer pas)
        private void VuePrincipale_Load_1(object sender, EventArgs e)
        {

        }
        private void lstProfesseurs_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_Click(object sender, EventArgs e)
        {

        }
    }
}
