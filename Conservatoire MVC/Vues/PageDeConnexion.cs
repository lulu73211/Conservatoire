using ConservatoireMVC.Modèles;
using System;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues
{
    // La classe PageDeConnexion gère l'interaction utilisateur sur la page de connexion.
    public partial class PageDeConnexion : Form
    {
        // Constructeur de la classe.
        public PageDeConnexion()
        {
            InitializeComponent();
        }

        // Événement déclenché lorsque l'utilisateur clique sur le bouton de connexion.
        private void coBt_Click(object sender, EventArgs e)
        {
            // Récupération des données saisies par l'utilisateur.
            string identifiant = identidiantBox.Text;
            string motDePasse = mdpBox.Text;

            // Création d'un contrôleur utilisateur.
            ControleurUtilisateur controleurUtilisateur = new ControleurUtilisateur(Connexion.ConnectionString);

            // Vérification des informations de connexion.
            if (controleurUtilisateur.VerifierConnexion(identifiant, motDePasse))
            {
                // Si les informations de connexion sont correctes, on ouvre la vue principale.
                VuePrincipale vuePrincipale = new VuePrincipale();
                this.Hide(); // Cache la fenêtre de connexion
                vuePrincipale.ShowDialog(); // Affiche la vue principale
            }
            else
            {
                // Si les informations de connexion sont incorrectes, on affiche un message d'erreur.
                MessageBox.Show("Identifiant ou mot de passe incorrect.");
            }
        }

        // Événement déclenché lors du chargement de la page de connexion.
        private void PageDeConnexion_Load(object sender, EventArgs e)
        {
            // Pour l'instant, il n'y a rien à faire ici.
        }

        // Événement déclenché lorsque l'utilisateur clique sur le label.
        private void label3_Click(object sender, EventArgs e)
        {
            // On efface le contenu des champs d'identifiant et de mot de passe.
            identidiantBox.Text = "";
            mdpBox.Text = "";
        }
    }
}
