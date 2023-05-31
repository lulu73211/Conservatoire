using ConservatoireMVC.Contrôleurs;
using ConservatoireMVC.Modèles;
using ConservatoireMVC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConservatoireMVC.Vues.Eleve
{
    public partial class FormAjouterEleve1 : Form
    {
        private EleveService _elevesService;
        private ControleurEleve _ControleurEleve;
        string connectionString = Connexion.ConnectionString;
        private InstrumentService _instrumentService;

        // Constructeur de la forme
        public FormAjouterEleve1()
        {
            InitializeComponent();
            _elevesService = new EleveService(Connexion.ConnectionString);
            _ControleurEleve = new ControleurEleve(connectionString);
            _instrumentService = new InstrumentService(connectionString);
        }

        // Événement déclenché lors du clic sur le bouton "Ajouter un élève"
        private void Ajout1Eleve_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs du formulaire
            string nomValue = nomEleve.Text;
            string prenomValue = prenomEleve.Text;
            string naissanceValue = naissanceEleve.Text;
            string adresseValue = adresseEleve.Text;
            string telephoneValue = telephoneEleve.Text;
            string emailValue = emailEleve.Text;
            int instrumentValue = ((KeyValuePair<int, string>)instrumentEleve.SelectedItem).Key;

            // Valider la date de naissance
            if (!DateTime.TryParseExact(naissanceValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateNaissance))
            {
                MessageBox.Show("Veuillez entrer une date valide. Le format doit être JJ/MM/AAAA.");
                return;
            }

            // Valider le numéro de téléphone
            if (!Regex.IsMatch(telephoneValue, @"^0[1-9][0-9]{8}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide à 10 chiffres commençant par 0.");
                return;
            }

            // Si tous les champs nécessaires sont remplis
            if (!string.IsNullOrWhiteSpace(nomValue) &&
                !string.IsNullOrWhiteSpace(prenomValue) &&
                !string.IsNullOrWhiteSpace(adresseValue) &&
                instrumentValue != 0)
            {
                // Créez un nouveau modèle d'élève avec les données saisies
                ModeleEleve eleve = new ModeleEleve
                {
                    Nom = nomValue,
                    Prenom = prenomValue,
                    DateNaissance = dateNaissance,
                    Adresse = adresseValue,
                    Telephone = telephoneValue,
                    Email = emailValue,
                    IdInstrument = instrumentValue
                };

                // Essayez d'ajouter l'élève
                try
                {
                    _ControleurEleve.AjouterEleve(eleve);
                    MessageBox.Show("L'élève a bien été ajouté");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors du traitement de vos données. Veuillez vérifier vos entrées et réessayer. " +
                        "Si le problème persiste, contactez le support technique.\n\nDétails de l'erreur : " + ex.Message);
                }
            }
        }

        // Événement déclenché lors du clic sur le bouton "Retour"
        private void button2_Click(object sender, EventArgs e)
        {
            // Masquez cette forme
            this.Hide();
        }

        // Événement déclenché lorsque la forme est chargée
        private void FormAjouterEleve1_Load_1(object sender, EventArgs e)
        {
            // Obtenez la liste des instruments du service
            List<Instrument> instruments = _instrumentService.ObtenirInstruments();
            Dictionary<int, string> instrumentsDict = new Dictionary<int, string>();

            // Remplissez le dictionnaire avec les informations de chaque instrument
            foreach (Instrument instrument in instruments)
            {
                instrumentsDict.Add(instrument.Id, instrument.Nom);
            }

            // Liez les données du dictionnaire à la liste déroulante des instruments
            instrumentEleve.DataSource = new BindingSource(instrumentsDict, null);
            instrumentEleve.DisplayMember = "Value";
            instrumentEleve.ValueMember = "Key";
        }
    }
}
