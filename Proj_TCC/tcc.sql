-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 14, 2026 at 11:49 AM
-- Server version: 5.7.17
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tcc`
--

-- --------------------------------------------------------

--
-- Table structure for table `baralho`
--

CREATE TABLE `baralho` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `codigo_montagem` varchar(50) DEFAULT NULL,
  `favorito` tinyint(1) DEFAULT NULL,
  `delecao_bloqueada` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `baralho`
--

INSERT INTO `baralho` (`id`, `id_usuario`, `nome`, `codigo_montagem`, `favorito`, `delecao_bloqueada`) VALUES
(1, 1, 'Fúria Flamejante', 'MONT-001', 1, 0),
(2, 1, 'Escudo de Pedra', 'MONT-002', 0, 0),
(3, 2, 'Magia Lunar', 'MONT-003', 1, 0),
(4, 3, 'Sombras da Noite', 'MONT-004', 0, 1),
(5, 4, 'Renascimento', 'MONT-005', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `carta`
--

CREATE TABLE `carta` (
  `id` int(11) NOT NULL,
  `codigo_conjunto` char(10) DEFAULT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `nome_arte` varchar(100) DEFAULT NULL,
  `texto` varchar(500) DEFAULT NULL,
  `atributos_secundarios` int(11) DEFAULT NULL,
  `vida` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `carta`
--

INSERT INTO `carta` (`id`, `codigo_conjunto`, `nome`, `nome_arte`, `texto`, `atributos_secundarios`, `vida`) VALUES
(1, 'SET01', 'Dragao de Fogo', 'arte_dragao_fogo', 'Causa 500 de dano ao ser invocado.', 2, 1200),
(2, 'SET01', 'Cavaleiro Sombrio', 'arte_cavaleiro_sombrio', 'Ganha +200 de vida em campo escuro.', 1, 900),
(3, 'SET02', 'Feiticeira Lunar', 'arte_feiticeira_lunar', 'Cura 300 de vida ao time.', 3, 600),
(4, 'SET02', 'Golem de Pedra', 'arte_golem_pedra', 'Reduz dano recebido em 20%%.', 1, 1500),
(5, 'SET03', 'Fenix Renascida', 'arte_fenix_renascida', 'Revive uma vez ao ser destruida.', 2, 800);

-- --------------------------------------------------------

--
-- Table structure for table `compartilhamento`
--

CREATE TABLE `compartilhamento` (
  `id_usuario` int(11) NOT NULL,
  `id_baralho` int(11) NOT NULL,
  `qtd_visualizacoes` int(11) DEFAULT NULL,
  `qtd_copias` int(11) DEFAULT NULL,
  `qtd_curtidas` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `compartilhamento`
--

INSERT INTO `compartilhamento` (`id_usuario`, `id_baralho`, `qtd_visualizacoes`, `qtd_copias`, `qtd_curtidas`) VALUES
(1, 1, 150, 12, 8),
(1, 2, 80, 5, 3),
(2, 3, 220, 20, 15),
(3, 4, 60, 2, 1),
(4, 5, 300, 25, 18);

-- --------------------------------------------------------

--
-- Table structure for table `curtida`
--

CREATE TABLE `curtida` (
  `id_usuario_remetente` int(11) NOT NULL,
  `id_usuario_destinatario` int(11) NOT NULL,
  `id_baralho` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `curtida`
--

INSERT INTO `curtida` (`id_usuario_remetente`, `id_usuario_destinatario`, `id_baralho`) VALUES
(2, 1, 1),
(3, 1, 1),
(1, 2, 3),
(4, 3, 4),
(1, 4, 5);

-- --------------------------------------------------------

--
-- Table structure for table `inclusao_carta`
--

CREATE TABLE `inclusao_carta` (
  `id_baralho` int(11) NOT NULL,
  `id_carta` int(11) NOT NULL,
  `quantidade` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inclusao_carta`
--

INSERT INTO `inclusao_carta` (`id_baralho`, `id_carta`, `quantidade`) VALUES
(1, 1, 3),
(1, 2, 2),
(2, 4, 4),
(3, 3, 3),
(3, 5, 1),
(4, 2, 2),
(4, 4, 2),
(5, 3, 1),
(5, 5, 3);

-- --------------------------------------------------------

--
-- Table structure for table `sessao_token`
--

CREATE TABLE `sessao_token` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `token_hash` varchar(255) NOT NULL,
  `data_expiracao` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sessao_token`
--

INSERT INTO `sessao_token` (`id`, `id_usuario`, `token_hash`, `data_expiracao`) VALUES
(3, 6, '$2a$11$gCDQrBDboS.rSspw0GbBv.qIAc7ybHUb3QIRnKrD68P4dQsb.t90O', '2026-10-13 00:15:27');

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `apelido` varchar(100) DEFAULT NULL,
  `email` varchar(150) DEFAULT NULL,
  `senha` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id`, `apelido`, `email`, `senha`) VALUES
(1, 'dragaoazul', 'dragaoazul@email.com', 'senha123'),
(2, 'mestremagico', 'mestremagico@email.com', 'senha456'),
(3, 'cavaleironegro', 'cavaleironegro@email.com', 'senha789'),
(4, 'feiticeira99', 'feiticeira99@email.com', 'senhaabc'),
(5, 'aaaaaaaaaa', 'aaaaaaaa', '$2a$11$de4a/0p3XlTeVHbBqe45Au9PGLtexqBOsDGh1lTduf32zDKAm/hyC'),
(6, 'aaaaaaaaaa', 'asdf@gmail.com', '$2a$11$GWZduroAppihZr6Vd85ca.zcscEeh.Ff9ZGgyYIRFrGKbFEajexF2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `baralho`
--
ALTER TABLE `baralho`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_baralho_usuario` (`id_usuario`);

--
-- Indexes for table `carta`
--
ALTER TABLE `carta`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `compartilhamento`
--
ALTER TABLE `compartilhamento`
  ADD PRIMARY KEY (`id_usuario`,`id_baralho`),
  ADD KEY `fk_compartilhamento_baralho` (`id_baralho`);

--
-- Indexes for table `curtida`
--
ALTER TABLE `curtida`
  ADD PRIMARY KEY (`id_usuario_remetente`,`id_usuario_destinatario`,`id_baralho`),
  ADD KEY `fk_curtida_destinatario` (`id_usuario_destinatario`),
  ADD KEY `fk_curtida_baralho` (`id_baralho`);

--
-- Indexes for table `inclusao_carta`
--
ALTER TABLE `inclusao_carta`
  ADD PRIMARY KEY (`id_baralho`,`id_carta`),
  ADD KEY `fk_inclusao_carta` (`id_carta`);

--
-- Indexes for table `sessao_token`
--
ALTER TABLE `sessao_token`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_sessao_usuario` (`id_usuario`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `sessao_token`
--
ALTER TABLE `sessao_token`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `sessao_token`
--
ALTER TABLE `sessao_token`
  ADD CONSTRAINT `fk_sessao_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
