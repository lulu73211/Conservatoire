using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;
using ConservatoireMVC.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues.Eleve
{
    public partial class FormModifierEleve2 : Form
    {
        private int _selectedEleveId;
        private ControleurEleve _controleurEleve;
        private ControleurInstrument _instrumentService;

        // Déclaration de l'événement EleveUpdated
        public event EventHandler EleveUpdated;

        public FormModifierEleve2(int selectedEleveId)
        {
            InitializeComponent();

            _selectedEleveId = selectedEleveId;
            _controleurEleve = new ControleurEleve(Connexion.ConnectionString);
            _instrumentService = new ControleurInstrument(Connexion.ConnectionString);

            // Récupération de la liste des instruments
            var instruments = _instrumentService.ObtenirInstruments();

            // Création d'une liste de KeyValuePair pour lier à la comboBox
            List<KeyValuePair<int, string>> instrumentList = new List<KeyValuePair<int, string>>();
            foreach (var instrument in instruments)
            {
                instrumentList.Add(new KeyValuePair<int, string>(instrument.Id, instrument.Nom));
            }

            // Liaison de la liste à la comboBox
            comboBoxInstrumentEleve.DataSource = instrumentList;
            comboBoxInstrumentEleve.DisplayMember = "Value";
            comboBoxInstrumentEleve.ValueMember = "Key";

            // Récupération de l'élève à modifier
            ModeleEleve eleve = _controleurEleve.GetEleveById(_selectedEleveId);

            // Remplissage des champs du formulaire avec les données de l'élève
            if (eleve != null)
            {
                txtNomEleve.Text = eleve.Nom;
                txtPrenomEleve.Text = eleve.Prenom;
                txtDateNaissanceEleve.Text = eleve.DateNaissance.ToString("dd/MM/yyyy");
                txtAdresseEleve.Text = eleve.Adresse;
                txtTelephoneEleve.Text = eleve.Telephone;
                txtEmailEleve.Text = eleve.Email;
                comboBoxInstrumentEleve.SelectedValue = eleve.IdInstrument;
            }
            else
            {
                MessageBox.Show("L'élève avec l'ID donné n'a pas été trouvé.");
            }
        }

        // Méthode appelée quand le bouton "Modifier" est cliqué
        private void ModifierEleve_Click(object sender, EventArgs e)
        {
            // Récupération et vérification des données saisies par l'utilisateur
            string nom = txtNomEleve.Text;
            string prenom = txtPrenomEleve.Text;
            string adresse = txtAdresseEleve.Text;
            string email = txtEmailEleve.Text;
            string telephone = txtTelephoneEleve.Text;
            int instrumentId = ((KeyValuePair<int, string>)comboBoxInstrumentEleve.SelectedItem).Key;

            // Vérification de la validité de la date de naissance
            if (!DateTime.TryParseExact(txtDateNaissanceEleve.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateNaissance))
            {
                MessageBox.Show("Veuillez entrer une date valide. Le format doit être JJ/MM/AAAA.");
                return;
            }

            if (!Regex.IsMatch(telephone, @"^0[1-9][0-9]{8}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide à 10 chiffres commençant par 0.");
                return;
            }

            // Création de l'objet élève avec les nouvelles données
            ModeleEleve updatedEleve = new ModeleEleve
            {
                Id_Eleve = _selectedEleveId,
                Nom = nom,
                Prenom = prenom,
                DateNaissance = dateNaissance,
                Adresse = adresse,
                Telephone = telephone,
                Email = email,
                IdInstrument = instrumentId
            };

            // Mise à jour de l'élève
            _controleurEleve.UpdateEleve(updatedEleve);

            // Fermeture de la fenêtre
            this.Close();

            // Déclenchement de l'événement EleveUpdated
            EleveUpdated?.Invoke(this, EventArgs.Empty);
        }

        // Fermeture de la fenêtre si l'utilisateur clique sur le bouton "Annuler"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Vérification du format de la date quand l'utilisateur quitte le champ de la date de naissance
        private void txtDateNaissance_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!DateTime.TryParseExact(textBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("La date doit être au format JJ/MM/AAAA.");
                textBox.Text = "";
            }
        }
    }
}
