-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-05-2019 a las 22:58:35
-- Versión del servidor: 10.1.38-MariaDB
-- Versión de PHP: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `gestorpublicaciones`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulocientifico`
--

CREATE TABLE `articulocientifico` (
  `id_produccion` int(11) NOT NULL,
  `numPaginas` int(11) DEFAULT NULL,
  `numCitas` int(11) DEFAULT NULL,
  `DOI` varchar(255) DEFAULT NULL,
  `tipo` varchar(25) DEFAULT NULL,
  `nombreConferencia` varchar(255) DEFAULT NULL,
  `lugar` varchar(255) DEFAULT NULL,
  `categoría` varchar(255) DEFAULT NULL,
  `nombreRevista` varchar(255) DEFAULT NULL,
  `editorial` varchar(255) DEFAULT NULL,
  `factorImpacto` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `articulocientifico`
--

INSERT INTO `articulocientifico` (`id_produccion`, `numPaginas`, `numCitas`, `DOI`, `tipo`, `nombreConferencia`, `lugar`, `categoría`, `nombreRevista`, `editorial`, `factorImpacto`) VALUES
(3, 20, 10, 'primerdoi', 'conferencia', 'conferencia agujeros negros', 'Valencia', 'A*', NULL, NULL, NULL),
(4, 25, 8, 'segundodoi', 'conferencia', 'conferencia materia oscura', 'Valencia', 'A', NULL, NULL, NULL),
(5, 50, 30, 'tercerdoi', 'revista', NULL, NULL, NULL, 'Astronimical Jouernal', 'passat', 0.9),
(6, 40, 15, 'cuartodoi', 'revista', NULL, NULL, NULL, 'Science', 'cuatro', 0.8);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `autores`
--

CREATE TABLE `autores` (
  `ID` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `apellido` varchar(255) DEFAULT NULL,
  `deUniversidad` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `autores`
--

INSERT INTO `autores` (`ID`, `nombre`, `apellido`, `deUniversidad`) VALUES
(1, 'Jose', 'Hervas', 1),
(2, 'Pilu', 'Accino', 0),
(3, 'Marcel', 'Hervas', 1),
(4, 'Javi', 'Fernandez', 0),
(7, 'Mari', 'Hervas', 1),
(12, 'Pepe', 'Sabater', 1),
(17, 'Pilar', 'Pérez-Accino', 1),
(30, 'Ana', 'Herrera', 1),
(77, 'Jaime', 'Martinez', 1),
(80, 'Carmen', 'Perez', 0),
(88, 'Mariano', 'Romero', 1),
(101, 'Sergio', 'Jumilla', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `autoresuniversidad`
--

CREATE TABLE `autoresuniversidad` (
  `id_autor` int(11) NOT NULL,
  `DNI` varchar(9) DEFAULT NULL,
  `edad` int(11) DEFAULT NULL,
  `departamento` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `autoresuniversidad`
--

INSERT INTO `autoresuniversidad` (`id_autor`, `DNI`, `edad`, `departamento`) VALUES
(1, '53601857N', 33, 'Matemáticas'),
(3, '45123654Q', 2, 'Fisica'),
(7, '256457899', 28, 'Geologia'),
(12, '45789654b', 25, 'Fisica'),
(17, '12345678f', 58, 'Construccion'),
(30, '56478459N', 32, 'Matemáticas'),
(77, '12546398o', 25, 'Contruccion'),
(88, '25463147s', 41, 'Fisica aplicada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patentes`
--

CREATE TABLE `patentes` (
  `id_produccion` int(11) NOT NULL,
  `cuantia` double DEFAULT NULL,
  `fechaVencimiento` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `patentes`
--

INSERT INTO `patentes` (`id_produccion`, `cuantia`, `fechaVencimiento`) VALUES
(2, 2000, '2029-01-25'),
(7, 2015, '2029-12-21'),
(8, 5000, '2020-05-05'),
(9, 3000, '2030-04-23');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccioncientifica`
--

CREATE TABLE `produccioncientifica` (
  `ID` int(11) NOT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `año` int(11) DEFAULT NULL,
  `tipo` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `produccioncientifica`
--

INSERT INTO `produccioncientifica` (`ID`, `titulo`, `año`, `tipo`) VALUES
(2, 'patenteX', 2014, 'patente'),
(3, 'Agujeros negros', 2019, 'conferencia'),
(4, 'materia oscura', 2019, 'conferencia'),
(5, 'agujeros gusano', 2018, 'revista'),
(6, 'sistema kepler', 2018, 'revista'),
(7, 'test', 2018, 'patente'),
(8, 'Metodo transporte', 2003, 'patente'),
(9, 'Sistema nuevo', 2019, 'patente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `publica`
--

CREATE TABLE `publica` (
  `id_autor` int(11) NOT NULL,
  `id_produccion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `publica`
--

INSERT INTO `publica` (`id_autor`, `id_produccion`) VALUES
(1, 9),
(2, 6),
(3, 2),
(3, 3),
(3, 4),
(3, 9),
(4, 2),
(4, 5),
(17, 2),
(30, 8),
(88, 7);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `articulocientifico`
--
ALTER TABLE `articulocientifico`
  ADD PRIMARY KEY (`id_produccion`);

--
-- Indices de la tabla `autores`
--
ALTER TABLE `autores`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `autoresuniversidad`
--
ALTER TABLE `autoresuniversidad`
  ADD PRIMARY KEY (`id_autor`);

--
-- Indices de la tabla `patentes`
--
ALTER TABLE `patentes`
  ADD PRIMARY KEY (`id_produccion`);

--
-- Indices de la tabla `produccioncientifica`
--
ALTER TABLE `produccioncientifica`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `publica`
--
ALTER TABLE `publica`
  ADD PRIMARY KEY (`id_autor`,`id_produccion`),
  ADD KEY `id_produccion_publica_fk` (`id_produccion`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `articulocientifico`
--
ALTER TABLE `articulocientifico`
  ADD CONSTRAINT `produccion_Art_cient_fk` FOREIGN KEY (`id_produccion`) REFERENCES `produccioncientifica` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `autoresuniversidad`
--
ALTER TABLE `autoresuniversidad`
  ADD CONSTRAINT `autor_fk` FOREIGN KEY (`id_autor`) REFERENCES `autores` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `patentes`
--
ALTER TABLE `patentes`
  ADD CONSTRAINT `produccion_fk` FOREIGN KEY (`id_produccion`) REFERENCES `produccioncientifica` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `publica`
--
ALTER TABLE `publica`
  ADD CONSTRAINT `autor` FOREIGN KEY (`id_autor`) REFERENCES `autores` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `produccion` FOREIGN KEY (`id_produccion`) REFERENCES `produccioncientifica` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
