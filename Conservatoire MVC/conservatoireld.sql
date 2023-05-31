-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 31 mai 2023 à 18:53
-- Version du serveur : 10.4.24-MariaDB
-- Version de PHP : 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `conservatoireld`
--

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

CREATE TABLE `cours` (
  `id_cours` int(11) NOT NULL,
  `intitule` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `heure_debut` time NOT NULL,
  `heure_fin` time NOT NULL,
  `id_professeur` int(11) NOT NULL,
  `date` date DEFAULT NULL,
  `id_instrument` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `cours`
--

INSERT INTO `cours` (`id_cours`, `intitule`, `description`, `heure_debut`, `heure_fin`, `id_professeur`, `date`, `id_instrument`) VALUES
(1, 'Introduction au piano', 'Cours pour les débutants', '10:00:00', '11:00:00', 1, '2023-06-01', 1),
(2, 'Techniques avancées de violon', 'Pour les élèves de niveau intermédiaire et avancé', '11:30:00', '12:30:00', 32, '2023-06-01', 4),
(3, 'Cours de guitare pour débutants', 'Apprenez les bases de la guitare', '13:00:00', '14:00:00', 2, '2023-06-02', 2),
(4, 'Maîtriser le saxophone', 'Pour les élèves de niveau intermédiaire et avancé', '14:30:00', '15:30:00', 33, '2023-06-02', 5),
(5, 'Théorie de la batterie', 'Comprendre les bases de la musique', '10:00:00', '11:00:00', 3, '2023-06-04', 3);

-- --------------------------------------------------------

--
-- Structure de la table `eleves`
--

CREATE TABLE `eleves` (
  `id_eleve` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `date_naissance` date NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `email` varchar(255) NOT NULL,
  `id_instrument` int(11) DEFAULT NULL,
  `cotisation` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `eleves`
--

INSERT INTO `eleves` (`id_eleve`, `nom`, `prenom`, `date_naissance`, `adresse`, `telephone`, `email`, `id_instrument`, `cotisation`) VALUES
(1, 'Dupont', 'Jean', '2005-01-01', '12 rue des Ecoles', '0123456789', 'jean.dupont@mail.com', 4, 0),
(2, 'Martin', 'Julie', '2004-03-05', '17 avenue des Arts', '0678901234', 'julie.martin@mail.com', 4, 0),
(3, 'Durand', 'Pierre', '2006-02-10', '8 rue des Champs', '0987654321', 'pierre.durand@mail.com', 5, 0),
(4, 'Lefevre', 'Sophie', '2005-04-15', '29 boulevard du Midi', '0567890123', 'sophie.lefevre@mail.com', 1, 0),
(5, 'Muller', 'Lucas', '2004-09-25', '36 rue du Parc', '0345678901', 'lucas.muller@mail.com', 2, 0),
(6, 'Leroy', 'Manon', '2006-08-07', '41 avenue de la Gare', '0765432109', 'manon.leroy@mail.com', 4, 0),
(7, 'Garcia', 'Thomas', '2005-11-18', '14 rue du Commerce', '0234567890', 'thomas.garcia@mail.com', 5, 0),
(8, 'Petit', 'Camille', '2004-12-22', '3 rue de la Fontaine', '0890123456', 'camille.petit@mail.com', 1, 0),
(9, 'Lopez', 'Chloé', '2006-06-20', '22 avenue du Soleil', '0456789012', 'chloe.lopez@mail.com', 3, 0),
(10, 'RouxE', 'Alexandre', '2005-07-03', '9 boulevard des Oliviers', '0789012345', 'alexandre.roux@mail.com', 5, 0),
(11, 'Bernard', 'Laura', '2004-11-30', '6 avenue du Lac', '0123456789', 'laura.bernard@mail.com', 3, 0),
(12, 'Girard', 'Antoine', '2005-09-13', '15 rue de la Plage', '0678901234', 'antoine.girard@mail.com', 4, 0),
(13, 'Moreau', 'Emma', '2006-01-28', '31 avenue des Pins', '0987654321', 'emma.moreau@mail.com', 2, 0),
(14, 'Fournier', 'Lucie', '2005-10-02', '27 rue des Fleurs', '0567890123', 'lucie.fournier@mail.com', 3, 0),
(15, 'Garnier', 'Hugo', '2004-12-08', '4 avenue des Roses', '0345678901', 'hugo.garnier@mail.com', 2, 0),
(23, 'Christian', 'aaa', '1993-11-21', '45 rue du test', '1234567890', 'F@F', 3, 0);

-- --------------------------------------------------------

--
-- Structure de la table `eleves_cours`
--

CREATE TABLE `eleves_cours` (
  `id_eleve` int(11) NOT NULL,
  `id_cours` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `eleves_cours`
--

INSERT INTO `eleves_cours` (`id_eleve`, `id_cours`) VALUES
(1, 1),
(1, 2),
(2, 1),
(2, 2),
(3, 1),
(3, 2),
(4, 1),
(4, 2),
(5, 1),
(5, 2),
(6, 3),
(6, 4),
(7, 3),
(7, 4),
(8, 3),
(8, 4),
(9, 3),
(9, 4),
(10, 3),
(10, 4),
(11, 5),
(12, 5),
(13, 5),
(14, 5),
(15, 5);

-- --------------------------------------------------------

--
-- Structure de la table `instruments`
--

CREATE TABLE `instruments` (
  `id_instrument` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `instruments`
--

INSERT INTO `instruments` (`id_instrument`, `nom`) VALUES
(1, 'Piano'),
(2, 'Guitare'),
(3, 'Batterie'),
(4, 'Violon'),
(5, 'Saxophone');

-- --------------------------------------------------------

--
-- Structure de la table `professeurs`
--

CREATE TABLE `professeurs` (
  `id_professeur` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `date_naissance` date NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `email` varchar(255) NOT NULL,
  `id_instrument` int(11) DEFAULT NULL,
  `salaire` decimal(10,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `professeurs`
--

INSERT INTO `professeurs` (`id_professeur`, `nom`, `prenom`, `date_naissance`, `adresse`, `telephone`, `email`, `id_instrument`, `salaire`) VALUES
(1, 'Dubois', 'Marie', '1980-01-10', '12 rue des Arts', '0123456789', 'marie.dubois@mail.com', 1, '2500.00'),
(2, 'Lecomte', 'David', '1975-05-08', '17 avenue du Midi', '0678901234', 'david.lecomte@mail.com', 2, '2300.00'),
(3, 'Dupuis', 'Sophie', '1982-03-15', '29 boulevard du Parc', '0567890123', 'sophie.dupuis@mail.com', 3, '2200.00'),
(32, 'Le Breton', 'JF', '2000-10-10', '45 rue de la bretagne', '0123456789', 'bretagne@bretz.fr', 4, '2200.00'),
(33, 'Legendre', 'Alex', '2002-11-11', '25 rue legendre', '1234567890', 'jdfv@zgrvio.fr', 5, '383.00');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

CREATE TABLE `utilisateurs` (
  `id` int(11) NOT NULL,
  `identifiant` varchar(255) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  `statut` enum('admin','professeur','etudiant') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id`, `identifiant`, `mdp`, `statut`) VALUES
(2, 'admin', 'n2d49H3SDtbB4d@', 'admin'),
(3, 'admin123', 'azerty', 'admin');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `cours`
--
ALTER TABLE `cours`
  ADD PRIMARY KEY (`id_cours`),
  ADD KEY `cours_ibfk_1` (`id_professeur`),
  ADD KEY `cours_ibfk_2` (`id_instrument`);

--
-- Index pour la table `eleves`
--
ALTER TABLE `eleves`
  ADD PRIMARY KEY (`id_eleve`),
  ADD KEY `id_instrument` (`id_instrument`);

--
-- Index pour la table `eleves_cours`
--
ALTER TABLE `eleves_cours`
  ADD PRIMARY KEY (`id_eleve`,`id_cours`),
  ADD KEY `eleves_cours_ibfk_2` (`id_cours`);

--
-- Index pour la table `instruments`
--
ALTER TABLE `instruments`
  ADD PRIMARY KEY (`id_instrument`);

--
-- Index pour la table `professeurs`
--
ALTER TABLE `professeurs`
  ADD PRIMARY KEY (`id_professeur`),
  ADD KEY `id_instrument` (`id_instrument`);

--
-- Index pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `identifiant` (`identifiant`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `cours`
--
ALTER TABLE `cours`
  MODIFY `id_cours` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `eleves`
--
ALTER TABLE `eleves`
  MODIFY `id_eleve` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT pour la table `professeurs`
--
ALTER TABLE `professeurs`
  MODIFY `id_professeur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `cours`
--
ALTER TABLE `cours`
  ADD CONSTRAINT `cours_ibfk_1` FOREIGN KEY (`id_professeur`) REFERENCES `professeurs` (`id_professeur`) ON DELETE CASCADE,
  ADD CONSTRAINT `cours_ibfk_2` FOREIGN KEY (`id_instrument`) REFERENCES `instruments` (`id_instrument`);

--
-- Contraintes pour la table `eleves`
--
ALTER TABLE `eleves`
  ADD CONSTRAINT `eleves_ibfk_1` FOREIGN KEY (`id_instrument`) REFERENCES `instruments` (`id_instrument`);

--
-- Contraintes pour la table `eleves_cours`
--
ALTER TABLE `eleves_cours`
  ADD CONSTRAINT `eleves_cours_ibfk_1` FOREIGN KEY (`id_eleve`) REFERENCES `eleves` (`id_eleve`) ON DELETE CASCADE,
  ADD CONSTRAINT `eleves_cours_ibfk_2` FOREIGN KEY (`id_cours`) REFERENCES `cours` (`id_cours`);

--
-- Contraintes pour la table `professeurs`
--
ALTER TABLE `professeurs`
  ADD CONSTRAINT `professeurs_ibfk_1` FOREIGN KEY (`id_instrument`) REFERENCES `instruments` (`id_instrument`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
