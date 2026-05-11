-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Maio-2026 às 14:09
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `beamstruggledb`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `baralho`
--

CREATE TABLE `baralho` (
  `ID_Baralho` int(11) NOT NULL,
  `Codigo_Construcao` text DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Favoritado` tinyint(1) DEFAULT NULL,
  `Delecao_Bloqueada` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `carta`
--

CREATE TABLE `carta` (
  `Codigo_ID` char(9) NOT NULL,
  `Borda` enum('Líder','Unidade Laranja','Unidade Azul','Unidade Cinza','Truque') DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Tipos_Secundarios` int(11) DEFAULT NULL,
  `Vida` int(11) DEFAULT NULL,
  `Texto` text DEFAULT NULL,
  `Nome_Imagem` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `compartilhamento`
--

CREATE TABLE `compartilhamento` (
  `Nome` varchar(100) DEFAULT NULL,
  `ID_Baralho` int(11) NOT NULL,
  `ID_UsuarioCriador` int(11) NOT NULL,
  `Qtd_Views` int(11) DEFAULT NULL,
  `Qtd_Copias` int(11) DEFAULT NULL,
  `Qtd_Avaliacoes` int(11) DEFAULT NULL,
  `Avaliacao` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuário`
--

CREATE TABLE `usuário` (
  `Apelido` varchar(50) DEFAULT NULL,
  `Email` varchar(150) DEFAULT NULL,
  `Senha` varchar(20) DEFAULT NULL,
  `ID_Usuario` int(11) NOT NULL,
  `Dt_Nascimento` date DEFAULT NULL,
  `Genero` enum('Masculino','Feminino','Não-Binário','Outro') DEFAULT NULL,
  `Pais_Residencia` enum('Afeganistão','África do Sul','Albânia','Alemanha','Andorra','Angola','Antígua e Barbuda','Arábia Saudita','Argélia','Argentina','Armênia','Austrália','Áustria','Azerbaijão','Bahamas','Bangladesh','Barbados','Barein','Belarus','Bélgica','Belize','Benim','Bolívia','Bósnia e Herzegovina','Botsuana','Brasil','Brunei','Bulgária','Burkina Fasso','Burundi','Butão','Cabo Verde','Camarões','Camboja','Canadá','Catar','Cazaquistão','Chade','Chile','China','Chipre','Colômbia','Comores','Congo','Coreia do Norte','Coreia do Sul','Costa do Marfim','Costa Rica','Croácia','Cuba','Dinamarca','Djibuti','Dominica','Egito','El Salvador','Emirados Árabes Unidos','Equador','Eritreia','Eslováquia','Eslovênia','Espanha','Essuatíni','Estados Unidos','Estônia','Etiópia','Fiji','Filipinas','Finlândia','França','Gabão','Gâmbia','Gana','Geórgia','Granada','Grécia','Guatemala','Guiana','Guiné','Guiné-Bissau','Guiné Equatorial','Haiti','Honduras','Hungria','Iêmen','Ilhas Marshall','Ilhas Salomão','Índia','Indonésia','Irã','Iraque','Irlanda','Islândia','Israel','Itália','Jamaica','Japão','Jordânia','Kiribati','Kosovo','Kuwait','Laos','Lesoto','Letônia','Líbano','Libéria','Líbia','Liechtenstein','Lituânia','Luxemburgo','Macedônia do Norte','Madagascar','Malásia','Malaui','Maldivas','Mali','Malta','Marrocos','Maurício','Mauritânia','México','Mianmar','Micronésia','Moçambique','Moldávia','Mônaco','Mongólia','Montenegro','Namíbia','Nauru','Nepal','Nicarágua','Níger','Nigéria','Noruega','Nova Zelândia','Omã','Países Baixos','Palau','Panamá','Papua-Nova Guiné','Paquistão','Paraguai','Peru','Polônia','Portugal','Quênia','Quirguistão','Reino Unido','República Centro-Africana','República Democrática do Congo','República Dominicana','República Tcheca','Romênia','Ruanda','Rússia','Samoa','San Marino','Santa Lúcia','São Cristóvão e Névis','São Tomé e Príncipe','São Vicente e Granadinas','Seicheles','Senegal','Serra Leoa','Sérvia','Singapura','Síria','Somália','Sri Lanka','Sudão','Sudão do Sul','Suécia','Suíça','Suriname','Tadjiquistão','Tailândia','Taiwan','Tanzânia','Timor-Leste','Togo','Tonga','Trinidad e Tobago','Tunísia','Turcomenistão','Turquia','Tuvalu','Ucrânia','Uganda','Uruguai','Uzbequistão','Vanuatu','Vaticano','Venezuela','Vietnã','Zâmbia','Zimbábue') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `baralho`
--
ALTER TABLE `baralho`
  ADD PRIMARY KEY (`ID_Baralho`);

--
-- Índices para tabela `carta`
--
ALTER TABLE `carta`
  ADD PRIMARY KEY (`Codigo_ID`);

--
-- Índices para tabela `compartilhamento`
--
ALTER TABLE `compartilhamento`
  ADD PRIMARY KEY (`ID_Baralho`,`ID_UsuarioCriador`),
  ADD KEY `ID_UsuarioCriador` (`ID_UsuarioCriador`);

--
-- Índices para tabela `usuário`
--
ALTER TABLE `usuário`
  ADD PRIMARY KEY (`ID_Usuario`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `baralho`
--
ALTER TABLE `baralho`
  MODIFY `ID_Baralho` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuário`
--
ALTER TABLE `usuário`
  MODIFY `ID_Usuario` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `compartilhamento`
--
ALTER TABLE `compartilhamento`
  ADD CONSTRAINT `compartilhamento_ibfk_1` FOREIGN KEY (`ID_Baralho`) REFERENCES `baralho` (`ID_Baralho`),
  ADD CONSTRAINT `compartilhamento_ibfk_2` FOREIGN KEY (`ID_UsuarioCriador`) REFERENCES `usuário` (`ID_Usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
