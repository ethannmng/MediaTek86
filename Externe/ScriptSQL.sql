-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Généré le : jeu. 06 juin 2024 à 11:59
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--
CREATE DATABASE IF NOT EXISTS `mediatek86` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
CREATE USER 'mediatek_user'@'%' IDENTIFIED BY 'Admin123!!';
GRANT USAGE ON *.* TO 'mediatek_user'@'%';
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek_user'@'%';
USE `mediatek86`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(40, '2025-01-03 22:49:34', '2023-09-07 18:50:14', 3),
(46, '2020-07-08 00:32:31', '2022-11-30 14:43:27', 4),
(77, '2024-09-09 06:34:55', '2022-06-28 14:44:12', 1),
(18, '2025-05-16 23:57:43', '2022-04-17 21:02:58', 2),
(57, '2021-07-15 05:54:01', '2023-04-15 01:14:58', 3),
(25, '2024-05-13 13:38:17', '2025-02-01 01:47:49', 1),
(49, '2020-11-15 07:30:17', '2021-08-19 03:21:44', 2),
(77, '2022-04-03 06:41:40', '2022-07-10 14:09:45', 3),
(56, '2021-11-28 18:29:29', '2021-09-30 02:10:56', 2),
(16, '2022-06-07 20:06:23', '2025-04-22 19:06:51', 2),
(72, '2021-03-10 11:58:56', '2021-10-06 00:38:52', 4),
(34, '2022-08-17 23:23:53', '2024-09-13 06:13:28', 3),
(81, '2021-01-10 07:42:09', '2022-10-28 13:45:15', 3),
(53, '2022-09-01 11:44:20', '2023-04-18 00:06:36', 3),
(67, '2023-08-22 16:00:10', '2020-11-25 01:09:35', 3),
(69, '2025-03-13 19:40:09', '2024-02-03 12:17:35', 3),
(21, '2024-09-23 11:07:27', '2024-04-12 13:21:15', 2),
(42, '2024-09-21 21:35:40', '2025-02-02 03:11:48', 4),
(95, '2023-12-09 18:12:08', '2021-03-27 23:35:45', 2),
(81, '2021-11-12 19:18:23', '2024-06-09 05:28:18', 1),
(81, '2024-07-21 21:57:23', '2020-06-10 06:48:26', 3),
(8, '2020-07-10 08:24:46', '2023-10-19 02:04:21', 3),
(30, '2022-10-21 10:07:23', '2025-04-22 21:37:25', 1),
(25, '2023-10-08 07:51:27', '2022-04-12 22:21:04', 2),
(49, '2024-12-24 02:00:47', '2021-06-30 02:03:34', 1),
(59, '2020-09-17 12:36:53', '2020-12-07 15:05:18', 2),
(45, '2023-08-11 08:13:30', '2020-09-30 09:25:24', 2),
(6, '2022-08-31 12:18:05', '2024-01-01 06:27:44', 3),
(46, '2020-06-08 01:56:48', '2024-11-08 08:17:57', 2),
(21, '2021-03-19 04:49:35', '2025-01-30 10:52:37', 3),
(95, '2022-02-25 01:47:58', '2023-09-28 08:22:42', 1),
(5, '2023-08-15 14:45:14', '2022-04-05 12:58:05', 2),
(9, '2024-07-08 02:23:54', '2022-11-02 08:13:35', 2),
(15, '2020-11-18 23:33:10', '2025-05-26 12:53:21', 2),
(2, '2025-04-24 18:36:14', '2022-07-04 20:44:47', 3),
(79, '2022-07-04 11:39:14', '2023-08-09 10:49:16', 3),
(51, '2022-06-21 02:12:00', '2024-04-10 09:35:40', 3),
(89, '2023-04-14 21:51:03', '2024-03-21 16:05:13', 1),
(41, '2025-05-13 00:04:05', '2024-11-27 12:39:20', 4),
(26, '2020-07-31 08:50:21', '2021-01-15 23:48:17', 2),
(56, '2022-06-20 18:56:11', '2023-03-20 08:48:14', 4),
(32, '2020-08-20 17:20:25', '2022-04-06 16:34:33', 3),
(91, '2024-04-18 10:16:57', '2021-04-23 21:11:57', 4),
(9, '2023-01-13 08:15:26', '2024-11-02 11:18:46', 3),
(17, '2021-07-18 10:02:50', '2023-07-11 10:10:43', 1),
(74, '2022-03-29 10:23:43', '2022-09-10 14:36:40', 2),
(4, '2023-10-04 02:07:02', '2023-09-28 20:54:10', 2),
(75, '2021-07-13 17:54:30', '2021-02-23 19:36:10', 2),
(38, '2023-06-23 07:41:10', '2021-04-30 09:38:54', 3),
(77, '2024-11-06 20:53:03', '2021-08-22 22:55:16', 4),
(71, '2024-06-22 02:32:58', '2022-08-03 07:14:24', 1),
(79, '2023-11-12 19:24:51', '2021-08-23 15:12:55', 3),
(15, '2020-07-22 23:31:15', '2020-06-29 04:02:46', 4),
(61, '2023-07-03 08:58:04', '2023-01-10 17:15:24', 1),
(98, '2020-09-16 20:19:00', '2021-08-24 22:39:13', 4),
(78, '2020-07-11 08:00:07', '2023-12-01 17:56:06', 2),
(18, '2022-03-03 12:08:25', '2022-01-22 11:27:03', 3),
(80, '2020-09-12 23:50:50', '2021-08-01 18:52:40', 4),
(8, '2024-05-09 12:26:21', '2023-07-15 17:03:35', 2),
(45, '2024-01-01 09:58:59', '2021-02-07 18:30:05', 3),
(83, '2023-11-14 16:29:59', '2024-02-04 18:34:38', 3),
(42, '2022-04-04 12:22:40', '2020-10-15 01:44:10', 3),
(25, '2024-06-03 13:29:34', '2024-06-09 13:29:34', 3),
(59, '2021-08-01 00:37:02', '2021-08-11 19:47:43', 2),
(66, '2021-11-21 06:37:58', '2023-03-11 14:58:39', 2),
(28, '2021-07-11 07:28:27', '2025-03-01 14:19:44', 4),
(59, '2025-05-20 04:07:32', '2022-05-12 13:48:11', 2),
(73, '2021-03-21 17:06:11', '2021-12-10 16:14:56', 2),
(58, '2023-05-07 08:59:23', '2024-08-06 19:19:07', 2),
(6, '2024-10-08 15:24:35', '2024-11-22 18:30:05', 2),
(4, '2023-10-15 02:19:59', '2024-08-30 05:34:06', 3),
(63, '2022-06-11 00:59:04', '2023-09-29 01:41:48', 4),
(11, '2023-09-28 23:11:26', '2024-01-11 10:00:16', 4),
(4, '2021-09-28 20:06:22', '2024-12-08 14:55:12', 3),
(39, '2021-12-19 18:22:15', '2021-12-31 10:28:59', 2),
(93, '2024-07-30 09:41:18', '2022-08-11 05:25:12', 2),
(12, '2023-04-28 10:57:34', '2021-11-14 09:30:00', 3),
(18, '2022-07-31 04:30:12', '2025-01-29 09:40:44', 1),
(25, '2022-01-10 01:25:10', '2022-02-23 15:52:10', 2),
(66, '2022-09-19 14:22:14', '2023-06-13 08:05:18', 2),
(13, '2021-01-11 05:48:43', '2023-11-03 23:50:17', 2),
(1, '2020-08-26 00:44:31', '2024-12-26 13:48:57', 3),
(29, '2024-03-11 04:58:36', '2021-04-29 14:57:49', 2),
(28, '2022-07-25 10:21:48', '2021-04-28 06:22:00', 3),
(87, '2020-11-22 18:33:25', '2022-02-23 11:10:51', 2),
(25, '2023-08-30 23:03:35', '2022-12-23 08:30:22', 3),
(14, '2024-09-01 22:43:19', '2024-09-05 00:51:04', 2),
(70, '2021-12-21 21:28:14', '2022-06-03 02:28:36', 2),
(58, '2023-01-02 13:01:57', '2024-11-15 23:11:33', 3),
(86, '2020-06-18 22:26:07', '2025-05-12 07:41:51', 3),
(14, '2023-08-31 00:22:05', '2024-11-02 03:29:02', 2),
(97, '2022-03-05 06:26:50', '2022-10-15 04:40:05', 2),
(91, '2021-09-20 03:57:26', '2022-11-09 18:49:25', 3),
(82, '2024-12-21 20:11:48', '2024-12-24 21:19:25', 2),
(40, '2021-01-03 03:56:33', '2021-01-29 12:22:51', 1),
(37, '2021-10-12 10:23:28', '2021-08-31 18:47:08', 3),
(61, '2020-12-04 06:51:25', '2021-02-20 15:59:25', 3),
(32, '2023-08-07 07:14:50', '2020-06-10 14:57:33', 4),
(5, '2024-10-11 21:23:24', '2022-12-06 08:21:46', 2),
(65, '2022-09-25 13:37:20', '2024-12-07 09:21:23', 3),
(25, '2024-06-03 13:29:56', '2024-06-30 13:29:56', 3),
(25, '2024-06-01 13:30:24', '2024-06-30 13:30:24', 4);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=104 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Morris', 'Dahlia', '02 37 85 45 18', 'velit.sed@yahoo.net', 1),
(2, 'Baldwin', 'Dillon', '07 26 22 29 14', 'sollicitudin.adipiscing.ligula@aol.org', 2),
(3, 'Sheppard', 'Dana', '07 15 28 67 69', 'cursus.et@aol.net', 1),
(4, 'Finch', 'Kermit', '01 12 75 27 97', 'urna.justo@hotmail.edu', 2),
(5, 'Wood', 'Karina', '08 47 32 44 37', 'est.ac@yahoo.org', 2),
(6, 'Trevino', 'Nerea', '06 58 76 24 60', 'sed.diam@google.org', 3),
(7, 'Lawson', 'Naomi', '09 30 30 66 06', 'dolor.sit@yahoo.com', 2),
(8, 'Blackwell', 'Ifeoma', '09 85 98 84 46', 'justo.faucibus@yahoo.ca', 2),
(9, 'Gilbert', 'Galena', '08 52 89 37 71', 'egestas.sed@yahoo.com', 1),
(10, 'Poole', 'Hermione', '06 56 73 38 24', 'libero.donec@google.ca', 3),
(11, 'Burgess', 'Hiram', '06 25 81 85 69', 'auctor.nunc@hotmail.ca', 1),
(12, 'Duffy', 'Robert', '02 83 77 36 60', 'nam.interdum@protonmail.ca', 3),
(13, 'Torres', 'Constance', '03 41 04 34 61', 'arcu.curabitur@outlook.ca', 2),
(14, 'Hart', 'Ivory', '04 87 56 23 85', 'egestas.rhoncus@hotmail.edu', 2),
(15, 'Tran', 'Whilemina', '06 59 55 05 85', 'nulla.at.sem@google.edu', 2),
(16, 'Montoya', 'Oscar', '05 40 30 44 85', 'venenatis.lacus.etiam@aol.couk', 3),
(17, 'Rush', 'Malcolm', '04 55 41 67 96', 'torquent.per@icloud.ca', 2),
(18, 'Wynn', 'Velma', '01 93 19 84 08', 'magna.a@hotmail.org', 2),
(19, 'Wyatt', 'Noble', '02 52 19 08 78', 'non.arcu.vivamus@yahoo.edu', 2),
(20, 'Blake', 'Lester', '03 34 95 43 70', 'ut.nulla.cras@yahoo.com', 2),
(21, 'Soto', 'Heather', '07 12 95 04 62', 'dui.nec@yahoo.org', 2),
(22, 'Russo', 'Macaulay', '05 12 89 64 88', 'egestas@hotmail.org', 2),
(23, 'Cotton', 'Kaitlin', '03 82 71 78 38', 'viverra.maecenas@icloud.edu', 3),
(24, 'Guzman', 'Olivia', '04 72 51 05 74', 'pharetra.ut@hotmail.couk', 3),
(25, 'Aguirre', 'Tyler', '02 18 51 14 95', 'penatibus.et@yahoo.net', 2),
(26, 'Howard', 'Rhiannon', '08 96 61 45 09', 'commodo@aol.ca', 3),
(27, 'Parsons', 'Wynne', '06 23 94 72 20', 'nulla.facilisis@yahoo.net', 2),
(28, 'Nielsen', 'Tate', '08 37 45 95 30', 'eu.elit@yahoo.ca', 1),
(29, 'Gordon', 'Brynne', '05 68 46 60 65', 'viverra@icloud.com', 1),
(30, 'Mays', 'Harper', '02 05 30 57 20', 'urna.convallis.erat@google.org', 3),
(31, 'Rollins', 'Nichole', '05 64 75 37 16', 'ut.ipsum.ac@google.org', 2),
(32, 'Daniel', 'Bo', '06 52 13 73 27', 'lobortis.nisi@icloud.couk', 2),
(33, 'Brittany', 'Aguirre', '03 40 95 85 15', 'interdum.enim@outlook.couk', 1),
(34, 'Sampson', 'Talon', '06 72 81 51 86', 'pellentesque@aol.couk', 3),
(35, 'Kinney', 'Nicholas', '05 85 60 03 17', 'ipsum.curabitur.consequat@aol.ca', 2),
(36, 'Morrow', 'Ray', '02 03 55 51 16', 'mi@yahoo.com', 2),
(37, 'Sparks', 'Nolan', '03 41 35 52 13', 'amet.luctus.vulputate@protonmail.couk', 2),
(38, 'Chan', 'Murphy', '02 25 41 38 13', 'blandit.viverra@google.com', 2),
(39, 'Merritt', 'Shelby', '04 87 78 87 41', 'lorem.vitae@outlook.ca', 3),
(40, 'Bowers', 'Leo', '06 10 28 16 70', 'lacus@yahoo.ca', 3),
(41, 'Heath', 'Ralph', '07 17 73 35 85', 'fringilla.est.mauris@protonmail.ca', 2),
(42, 'Ross', 'Hiroko', '04 13 17 26 05', 'dictum.proin.eget@hotmail.net', 2),
(43, 'Forbes', 'Maisie', '04 14 28 83 28', 'semper.auctor.mauris@yahoo.edu', 3),
(44, 'Sampson', 'Odette', '04 29 28 18 84', 'phasellus.libero.mauris@yahoo.couk', 2),
(45, 'Carpenter', 'Shea', '01 14 36 77 82', 'fermentum.metus@outlook.com', 3),
(46, 'Frazier', 'Jeremy', '07 41 15 77 94', 'in@google.couk', 2),
(47, 'Daniels', 'Orla', '08 24 27 43 15', 'donec.elementum.lorem@protonmail.org', 1),
(48, 'Long', 'Melodie', '07 93 44 11 32', 'purus.ac@google.couk', 2),
(49, 'Reynolds', 'Audrey', '01 42 86 52 01', 'quis.diam.luctus@hotmail.net', 3),
(50, 'Perez', 'Rebecca', '04 41 37 57 82', 'enim.nisl.elementum@aol.org', 1),
(51, 'Moses', 'Nichole', '05 72 64 61 84', 'imperdiet.ullamcorper.duis@protonmail.couk', 1),
(52, 'Coffey', 'Carson', '06 61 62 41 31', 'commodo.at.libero@google.couk', 2),
(53, 'Valdez', 'Kirestin', '05 05 43 31 68', 'felis.purus@outlook.edu', 1),
(54, 'Miller', 'Melvin', '06 30 62 87 22', 'turpis@protonmail.net', 2),
(55, 'Mcpherson', 'Cleo', '04 45 41 99 46', 'facilisis.facilisis@yahoo.ca', 3),
(56, 'Herrera', 'Andrew', '09 92 58 11 76', 'integer.urna.vivamus@google.edu', 2),
(57, 'Rivas', 'Norman', '05 46 83 98 57', 'metus.eu@protonmail.net', 3),
(58, 'Doyle', 'Keane', '04 58 21 84 55', 'ligula.donec@hotmail.org', 1),
(59, 'Walters', 'Nicholas', '07 30 38 39 07', 'mauris.id.sapien@aol.couk', 2),
(60, 'Ellis', 'Bradley', '02 75 35 44 49', 'ad@icloud.net', 2),
(61, 'Atkins', 'August', '02 49 42 71 91', 'eu.sem.pellentesque@yahoo.ca', 2),
(62, 'Hess', 'Callie', '04 58 94 67 29', 'praesent@google.edu', 1),
(63, 'Fitzgerald', 'Quentin', '06 83 77 23 63', 'neque.nullam@icloud.com', 3),
(64, 'Holland', 'Alice', '04 47 12 52 47', 'erat.eget@google.org', 2),
(65, 'Walsh', 'Leila', '03 41 73 53 65', 'magna@hotmail.ca', 1),
(66, 'Wong', 'Yardley', '04 96 86 63 75', 'aliquet.sem.ut@protonmail.com', 2),
(67, 'Silva', 'Leandra', '03 28 80 98 29', 'quisque@icloud.org', 1),
(68, 'Stephenson', 'Idola', '05 96 37 44 27', 'auctor.velit.eget@aol.org', 3),
(69, 'Mendez', 'Kennedy', '08 01 97 29 51', 'facilisis.vitae@hotmail.edu', 2),
(70, 'Mendez', 'Jocelyn', '06 52 20 07 35', 'dictum@aol.edu', 2),
(71, 'Mcguire', 'Amelia', '08 83 21 58 88', 'ut.eros@google.couk', 2),
(72, 'Hatfield', 'Nasim', '04 45 71 27 47', 'nec@icloud.net', 3),
(73, 'Lyle', 'Edwards', '03 86 83 44 38', 'facilisi.sed@icloud.couk', 1),
(74, 'Sullivan', 'Alika', '02 61 38 26 83', 'ante@icloud.net', 2),
(75, 'Nolan', 'Clark', '03 93 15 34 04', 'libero.dui@google.edu', 2),
(76, 'Parks', 'Zephr', '03 15 62 42 75', 'id.enim@hotmail.couk', 2),
(77, 'Bentley', 'Cheyenne', '06 25 11 62 30', 'enim.suspendisse.aliquet@aol.edu', 2),
(78, 'Mann', 'Danielle', '07 51 12 04 61', 'inceptos.hymenaeos@yahoo.ca', 2),
(103, 'Ethan', 'Ethan', '0565656464', 'trhkfd@dfjfd.fr', 2),
(80, 'William', 'Marsden', '02 51 51 42 15', 'dui.nec.tempus@outlook.com', 2),
(81, 'Merrill', 'Emmanuel', '05 17 71 09 61', 'arcu.vel@outlook.edu', 2),
(82, 'Webster', 'Alana', '05 34 29 75 45', 'eu.arcu@yahoo.edu', 2),
(83, 'Ayers', 'Jeanette', '07 34 08 48 92', 'tellus.imperdiet.non@icloud.ca', 3),
(84, 'Sexton', 'Bethany', '02 28 87 73 63', 'morbi.tristique@protonmail.edu', 2),
(85, 'Estes', 'Kaitlin', '07 33 74 72 36', 'metus.urna.convallis@yahoo.org', 3),
(86, 'Horton', 'Rogan', '04 76 61 69 85', 'eget@google.edu', 2),
(87, 'Valdez', 'Mercedes', '04 05 27 36 13', 'ut.pellentesque@protonmail.couk', 2),
(88, 'Wyatt', 'Robert', '02 91 23 72 78', 'dolor.tempus@outlook.org', 3),
(89, 'Dahlia', 'Aiguille', '02 10 73 92 75', 'vel.vulputate.eu@hotmail.net', 2),
(90, 'Mason', 'Philip', '05 04 11 25 43', 'leo@protonmail.edu', 1),
(91, 'Mendez', 'Joel', '07 68 86 33 12', 'at.nisi@outlook.net', 1),
(92, 'Fernand', 'Chien', '07 68 78 33 12', 'atfnsi@outlook.xyz', 1),
(93, 'Rogers', 'Oscar', '08 76 44 36 17', 'magna.phasellus.dolor@outlook.org', 2),
(94, 'Chambers', 'Vincent', '02 32 74 61 24', 'nullam@google.net', 3),
(95, 'Miranda', 'Clare', '01 66 23 83 86', 'nunc.sollicitudin@outlook.net', 2),
(96, 'Lowe', 'Yoshio', '09 47 55 39 78', 'adipiscing.fringilla@icloud.ca', 2),
(97, 'Fleming', 'Oliver', '06 66 73 96 33', 'tincidunt.neque@google.edu', 2),
(98, 'Battle', 'Ross', '08 67 69 33 53', 'dolor@google.com', 2),
(99, 'Carr', 'Ingrid', '06 36 44 82 86', 'nec@hotmail.org', 2),
(100, 'Horne', 'Mechelle', '05 57 82 85 23', 'integer.in@icloud.com', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('mediatek_user', '6ceb6bfbf24566237485a49f21393d4fef9b2940057ff396522c890c8d16dc86');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
