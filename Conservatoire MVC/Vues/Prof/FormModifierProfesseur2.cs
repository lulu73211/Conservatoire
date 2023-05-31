using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;

namespace ConservatoireMVC.Vues
{
    public partial class FormModifierProfesseur2 : Form
    {
        private int _selectedProfesseurId;
        private ControleurProfesseur _controleurProfesseur;
        private ControleurInstrument _instrumentService;

        // Déclaration d'un délégué pour un événement qui sera déclenché lors de la mise à jour d'un professeur
        public delegate void ProfesseurUpdatedEventHandler(object sender, EventArgs e);
        public event ProfesseurUpdatedEventHandler ProfesseurUpdated;

        // Constructeur de la classe
        public FormModifierProfesseur2(int selectedProfesseurId)
        {
            InitializeComponent();

            _selectedProfesseurId = selectedProfesseurId;
            _controleurProfesseur = new ControleurProfesseur(Connexion.ConnectionString);
            _instrumentService = new ControleurInstrument(Connexion.ConnectionString);

            Professeur professeur = _controleurProfesseur.GetProfesseurById(selectedProfesseurId);

            // Remplir les champs du formulaire avec les informations du professeur
            txtNom.Text = professeur.Nom;
            txtPrenom.Text = professeur.Prenom;
            txtDateNaissance.Text = professeur.DateNaissance.ToString("dd/MM/yyyy");
            txtAdresse.Text = professeur.Adresse;
            txtTelephone.Text = professeur.Telephone;
            txtSalaire.Text = professeur.Salaire.ToString();
            txtEmail.Text = professeur.Email;
            comboBoxInstrument.SelectedItem = professeur.Instrument;
        }

        // Méthode appelée lors du clic sur le bouton "Fermer"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Méthode appelée lors du clic sur le bouton "Modifier"
        private void Modifier_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string adresse = txtAdresse.Text;
            string telephone = txtTelephone.Text;
            string email = txtEmail.Text;
            int instrumentId = ((KeyValuePair<int, string>)comboBoxInstrument.SelectedItem).Key;

            // Vérification de la validité de la date de naissance
            if (!DateTime.TryParseExact(txtDateNaissance.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateNaissance))
            {
                MessageBox.Show("Veuillez entrer une date valide. Le format doit être JJ/MM/AAAA.");
                return;
            }

            // Vérification de la validité du téléphone
            if (!Regex.IsMatch(telephone, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide à 10 chiffres commençant par 0.");
                return;
            }

            // Vérification de la validité du salaire
            if (!decimal.TryParse(txtSalaire.Text, out decimal salaire))
            {
                MessageBox.Show("Veuillez entrer un salaire valide.");
                return;
            }

            // Création d'un nouvel objet Professeur avec les informations mises à jour
            Professeur updatedProfesseur = new Professeur
            {
                Id = _selectedProfesseurId,
                Nom = nom,
                Prenom = prenom,
                DateNaissance = dateNaissance,
                Adresse = adresse,
                Telephone = telephone,
                Salaire = salaire,
                Email = email,
                IdInstrument = instrumentId
            };

            // Mise à jour du professeur dans la base de données
            _controleurProfesseur.UpdateProfesseur(updatedProfesseur);

            // Fermeture du formulaire
            this.Close();

            // Déclenchement de l'événement de mise à jour du professeur
            ProfesseurUpdated?.Invoke(this, EventArgs.Empty);
        }

        // Méthode appelée lors du chargement du formulaire
        private void FormModifierProfesseur2_Load(object sender, EventArgs e)
        {
            List<Instrument> instruments = _instrumentService.ObtenirInstruments();
            Dictionary<int, string> instrumentsDict = new Dictionary<int, string>();

            foreach (Instrument instrument in instruments)
            {
                instrumentsDict.Add(instrument.Id, instrument.Nom);
            }

            comboBoxInstrument.DataSource = new BindingSource(instrumentsDict, null);
            comboBoxInstrument.DisplayMember = "Value";
            comboBoxInstrument.ValueMember = "Key";
        }
    }
}
