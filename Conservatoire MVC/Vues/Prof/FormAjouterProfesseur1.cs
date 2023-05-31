using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;
using ConservatoireMVC.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues
{
    public partial class FormAjouterProfesseur1 : Form
    {
        private ControleurProfesseur _ControleurProfesseur;
        private ProfesseurService _professeurService;
        private InstrumentService _instrumentService;

        public FormAjouterProfesseur1(ControleurProfesseur ControleurProfesseur, string connectionString)
        {
            InitializeComponent();
            _ControleurProfesseur = ControleurProfesseur;
            _professeurService = new ProfesseurService(connectionString);
            _instrumentService = new InstrumentService(connectionString);
        }

        // Événement de chargement du formulaire
        private void FormAjouterProfesseur1_Load(object sender, EventArgs e)
        {
            List<Instrument> instruments = _instrumentService.ObtenirInstruments();
            Dictionary<int, string> instrumentsDict = new Dictionary<int, string>();

            foreach (Instrument instrument in instruments)
            {
                instrumentsDict.Add(instrument.Id, instrument.Nom);
            }

            instrument.DataSource = new BindingSource(instrumentsDict, null);
            instrument.DisplayMember = "Value";
            instrument.ValueMember = "Key";
        }

        // Événement de clic sur le bouton "Ajouter"
        private void button1_Click_1(object sender, EventArgs e)
        {
            string nomValue = nom.Text;
            string prenomValue = prenom.Text;
            string naissanceValue = naissance.Text;

            if (!DateTime.TryParseExact(naissanceValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateNaissance))
            {
                MessageBox.Show("Veuillez entrer une date valide. Le format doit être JJ/MM/AAAA.");
                return;
            }

            string adresseValue = adresse.Text;
            string telephoneValue = telephone.Text;

            if (!Regex.IsMatch(telephoneValue, @"^0[1-9][0-9]{8}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide à 10 chiffres commençant par 0.");
                return;
            }

            string emailValue = email.Text;
            string salaireValue = salaire.Text;

            if (!decimal.TryParse(salaireValue, out decimal salaireParsed))
            {
                MessageBox.Show("Veuillez entrer un salaire valide.");
                return;
            }

            int instrumentValue = ((KeyValuePair<int, string>)instrument.SelectedItem).Key;

            // Vérification de la validité des entrées
            if (!string.IsNullOrWhiteSpace(nomValue) &&
                !string.IsNullOrWhiteSpace(prenomValue) &&
                !string.IsNullOrWhiteSpace(adresseValue) &&
                instrumentValue != 0)
            {
                Professeur professeur = new Professeur
                {
                    Nom = nomValue,
                    Prenom = prenomValue,
                    DateNaissance = dateNaissance,
                    Adresse = adresseValue,
                    Telephone = telephoneValue,
                    Email = emailValue,
                    Salaire = salaireParsed,
                    IdInstrument = instrumentValue
                };

                try
                {
                    _ControleurProfesseur.AjouterProfesseur(professeur);
                    MessageBox.Show("Le professeur a bien été ajouté");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors du traitement de vos données. Veuillez vérifier vos entrées et réessayer. " +
                        "Si le problème persiste, contactez le support technique.\n\nDétails de l'erreur : " + ex.Message);
                }
            }
        }

        // Événement de clic sur le bouton "Annuler"
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Événement lors de la modification du champ "salaire"
        private void salaire_TextChanged(object sender, EventArgs e)
        {
            // Vide pour le moment, peut être rempli en fonction des besoins
        }
    }
}
