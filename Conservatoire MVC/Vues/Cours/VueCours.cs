using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues
{
    public partial class VueCours : Form
    {
        private CoursService _coursService;
        private int _idProfesseur;

        // Le constructeur nécessite l'identifiant du professeur.
        public VueCours(int idProfesseur)
        {
            InitializeComponent();
            _coursService = new CoursService(Connexion.ConnectionString);
            _idProfesseur = idProfesseur;
            RemplirListeCours();
        }

        // Cette méthode remplit la liste des cours d'un professeur.
        private void RemplirListeCours()
        {
            // Récupérer la liste des cours du professeur.
            List<ConservatoireMVC.Modèles.Cours> coursListe = _coursService.ObtenirCours(_idProfesseur);

            // Pour chaque cours dans la liste...
            foreach (ConservatoireMVC.Modèles.Cours cours in coursListe)
            {
                // Créer un nouveau ListViewItem.
                ListViewItem item = new ListViewItem(cours.Intitule);

                // Ajouter des sous-éléments à l'item.
                item.SubItems.Add(cours.DateCours.ToString("dd/MM/yyyy"));
                DateTime heureDebut = DateTime.Parse(cours.Heure_Debut);
                item.SubItems.Add(heureDebut.ToString("HH:mm"));
                DateTime heureFin = DateTime.Parse(cours.Heure_Fin);
                item.SubItems.Add(heureFin.ToString("HH:mm"));
                item.SubItems.Add(cours.Id_Professeur.ToString());

                // Ajouter l'item à la liste.
                listeCours.Items.Add(item);
            }
        }

        // Cet événement est déclenché lorsque l'utilisateur sélectionne un élément dans la liste des cours.
        private void listeCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Assurez-vous qu'un élément est bien sélectionné.
            if (listeCours.SelectedItems.Count > 0)
            {
                // Récupérer l'ID du professeur sélectionné.
                int idProfesseur = int.Parse(listeCours.SelectedItems[0].SubItems[4].Text);

                // Obtenir la liste des élèves inscrits à ce professeur.
                EleveService eleveService = new EleveService(Connexion.ConnectionString);
                List<ModeleEleve> eleves = eleveService.ObtenirElevesParProfesseur(idProfesseur);

                // Effacer la listView2.
                listView2.Items.Clear();

                // Remplir la listView2 avec la liste des élèves.
                foreach (ModeleEleve eleve in eleves)
                {
                    ListViewItem item = new ListViewItem(eleve.Nom);
                    // Ajouter des sous-éléments à l'item selon votre modèle.
                    item.SubItems.Add(eleve.Prenom);
                    item.SubItems.Add(eleve.Id_Eleve.ToString());
                    item.SubItems.Add(eleve.Email);
                    item.SubItems.Add(eleve.Telephone);
                    listView2.Items.Add(item);
                }
            }
        }

        // Événement déclenché lors du clic sur le bouton 1.
        private void button1_Click(object sender, EventArgs e)
        {
            // Affiche une boîte de dialogue demandant à l'utilisateur s'il veut vraiment quitter l'application.
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Si l'utilisateur choisit "Yes", l'application se ferme.
                this.Close();
            }
        }

        // Événement déclenché lors du clic sur le bouton 3.
        private void button3_Click(object sender, EventArgs e)
        {
            // Ferme cette fenêtre et ouvre la vue principale.
            this.Close();
            VuePrincipale formVuePrincipale = new VuePrincipale();
            formVuePrincipale.Show();
        }
    }
}

