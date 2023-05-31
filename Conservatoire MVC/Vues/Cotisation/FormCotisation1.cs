using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;
using System;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues.Cotisation
{
    // FormCotisation1 est une classe qui gère l'interaction utilisateur sur la page de cotisation.
    public partial class FormCotisation1 : Form
    {
        private EleveService _eleveService;

        // Constructeur de la classe.
        public FormCotisation1()
        {
            InitializeComponent();
            _eleveService = new EleveService(Connexion.ConnectionString);
        }

        // Événement déclenché lors du chargement de la page de cotisation.
        private void FormCotisation1_Load(object sender, EventArgs e)
        {
            RemplirListViewElevesAyantPaye();
        }

        // Méthode pour remplir la liste des élèves ayant payé leur cotisation.
        private void RemplirListViewElevesAyantPaye()
        {
            // Récupération de la liste des élèves ayant payé leur cotisation.
            var elevesAyantPaye = _eleveService.ObtenirElevesAyantPaye();

            // Pour chaque élève dans la liste
            foreach (var eleve in elevesAyantPaye)
            {
                // Créez un nouveau ListViewItem avec le nom de l'élève
                var item = new ListViewItem(eleve.Nom);

                // Ajoutez des sous-éléments à l'item
                item.SubItems.Add(eleve.Prenom);
                item.SubItems.Add(eleve.Id_Eleve.ToString());
                item.SubItems.Add(eleve.Email);
                item.SubItems.Add(eleve.Telephone);

                // Ajoutez l'item à la liste
                listView1.Items.Add(item);
            }
        }

        // Événement déclenché lors de la sélection d'un item dans la liste d'élèves ayant payé leur cotisation.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pour l'instant, il n'y a rien à faire ici.
        }

        // Événement déclenché lors du clic sur le bouton 1.
        private void button1_Click(object sender, EventArgs e)
        {
            // Affiche une boîte de dialogue demandant à l'utilisateur s'il veut vraiment quitter l'application.
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();  // Ferme l'application si l'utilisateur clique sur 'Oui'.
            }
        }

        // Événement déclenché lors du clic sur le bouton 3.
        private void button3_Click(object sender, EventArgs e)
        {
            // Ferme la page actuelle et ouvre la page d'élève.
            this.Close();
            EleveView formEleveView = new EleveView();
            formEleveView.Show();
        }
    }
}
