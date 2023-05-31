using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;
using ConservatoireMVC.Vues.Cotisation;
using ConservatoireMVC.Vues.Eleve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConservatoireMVC.Vues
{
    public partial class EleveView : Form
    {
        private EleveService _elevesService;

        public EleveView()
        {
            InitializeComponent();
            _elevesService = new EleveService(Connexion.ConnectionString);
            RemplirListeEleves();
        }

        private void RemplirListeEleves()
        {
            List<ConservatoireMVC.Modèles.ModeleEleve> eleves = _elevesService.ObtenirEleves();

            // Trier la liste des élèves par nom
            eleves = eleves.OrderBy(e => e.Nom).ToList();

            lstEleves.DisplayMember = "Nom";

            foreach (ConservatoireMVC.Modèles.ModeleEleve eleve in eleves)
            {
                lstEleves.Items.Add(eleve.Nom + " - " + eleve.Prenom + " - " + eleve.Adresse + " - " + eleve.DateNaissance.ToString("dd/MM/yyyy")
                + " - " + eleve.Telephone + " - " + eleve.Email + " - " + eleve.NomInstrument + " - N° d'étudiant : " + eleve.Id_Eleve);
            }
        }



        public void RafraichirListeEleves()
        {
            // Effacer les éléments actuels de la ListBox
            lstEleves.Items.Clear();

            // Remplir la ListBox avec les professeurs à jour
            RemplirListeEleves();
        }

        private void lstEleves_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            VuePrincipale formVuePrincipale = new VuePrincipale();
            formVuePrincipale.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void ajouterUnEleveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterEleve1 formAjoutEleve = new FormAjouterEleve1();
            formAjoutEleve.ShowDialog();
            RafraichirListeEleves();
        }

        private void modifierUnEleveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifierEleve1 formModifierEleve = new FormModifierEleve1();
            formModifierEleve.ShowDialog();
            RafraichirListeEleves();
        }

        private void supprimerUnEleveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupprimerEleve1 formSupprimerEleve = new FormSupprimerEleve1();
            formSupprimerEleve.ShowDialog();
            RafraichirListeEleves();
        }

        private void gérerLesCotisations202324ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCotisation1 formCotisation = new FormCotisation1();
            formCotisation.Show();
        }

        private void btnSearch_Click_Click(object sender, EventArgs e)
        {
           
        }

        private void RemplirListView(List<ModeleEleve> eleves)
        {
        }
    }
}

