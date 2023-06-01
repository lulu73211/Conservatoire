Conservatoire de Musique - Application de Gestion

Description

L'application de gestion du conservatoire de musique est conçue pour aider à la gestion efficace des élèves, des professeurs, des cours et des instruments. Les fonctionnalités de l'application comprennent la gestion des élèves, la gestion des professeurs et le suivi des cotisations.

Fonctionnalités de l'application

Gestion des Utilisateurs : La plateforme permet de gérer deux types d'utilisateurs - professeurs et élèves. Les informations stockées comprennent l'identifiant, le mot de passe et le statut.

Gestion des Cotisations : Pour chaque élève, l'information sur le paiement de la cotisation est stockée et pourra être mise à jour par l'administrateur.

Gestion des Cours : Les cours offerts par le conservatoire sont présents dans l'application. Les informations incluent l'intitulé du cours, la description, les horaires de début et de fin, le professeur du cours, la date et l'instrument associé.

Gestion des Inscriptions aux Cours : L'information sur l'élève inscrit et le cours choisi est stockée dans l'application.

Gestion des Instruments : L'application conserve un enregistrement des différents instruments enseignés dans le conservatoire.

Structure de la Base de Données
La base de données comprend les tables suivantes :

utilisateurs : Contient les informations des utilisateurs de l'application.
cours : Contient les informations relatives aux cours proposés.
eleves : Contient les informations des élèves inscrits dans le conservatoire.
eleves_cours : Enregistre les informations sur les inscriptions des élèves aux différents cours.
instruments : Enregistre les différents instruments enseignés.
professeurs : Enregistre les informations des professeurs du conservatoire.
Chaque table est liée par des clés étrangères pour permettre des requêtes complexes et des rapports.

Instructions d'installation

1 - Télécharger l'application : Commencez par télécharger le dossier zip contenant l'application et la base de données.

2 - Installer un serveur de base de données MySQL : Si vous ne l'avez pas déjà fait, installez un serveur de base de données MySQL. Une option populaire est XAMPP, qui comprend MySQL et phpMyAdmin. Vous pouvez le télécharger depuis https://www.apachefriends.org/index.html. Suivez les instructions de l'installateur pour installer XAMPP.

3 - Lancer XAMPP : Une fois que XAMPP est installé, lancez-le et démarrez le serveur MySQL.

4 - Importer la base de données : Ouvrez votre navigateur web et allez à http://localhost/phpmyadmin/. Cliquez sur l'onglet "Import", puis choisissez le fichier SQL de la base de données que vous avez téléchargé et cliquez sur "Go" pour importer la base de données.

5 - Lancer l'application via l'executable "ConservatoireMVC.exe".

6 - Exécutez l'application : Vous pouvez maintenant exécuter l'application depuis l'executable "ConservatoireMVC.exe". Si tout a été configuré correctement, l'application devrait se connecter à la base de données et fonctionner correctement.

Comment Contribuer

Si vous souhaitez contribuer au développement de cette application, veuillez suivre ces étapes :

Forkez le dépôt sur Github.
Clonez votre fork sur votre machine locale.
Créez une nouvelle branche pour votre fonctionnalité.
Implémentez votre fonctionnalité ou votre correction de bug.
Validez vos modifications dans votre branche.
Poussez votre branche vers Github.
Créez une nouvelle Pull Request à partir de votre branche sur le dépôt d'origine.
Contact
Si vous avez des questions ou des commentaires concernant cette application, n'hésitez pas à nous contacter. Nous serons ravis de vous aider.

Note: Ce fichier README est une description générale de l'application. Pour des informations plus spécifiques et détaillées, veuillez consulter la documentation complète de l'application.
