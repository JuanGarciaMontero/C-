-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-05-2022 a las 14:03:19
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.0.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

--
-- Base de datos: `futbol`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `futbol1`
--

CREATE TABLE `futbol1` (
  `id_equi` int(11) NOT NULL,
  `nombre_equi` varchar(15) DEFAULT NULL,
  `presi` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `futbol1`
--

INSERT INTO `futbol1` (`id_equi`, `nombre_equi`, `presi`) VALUES
(1, 'Madrid', 'Juan'),
(2, 'Barcelona', 'Pedro'),
(3, 'Valencia', 'Luis'),
(4, 'Sevilla', 'Alex');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `futbol2`
--

CREATE TABLE `futbol2` (
  `id_jug` int(11) NOT NULL,
  `nombre_jug` varchar(15) DEFAULT NULL,
  `apellido_jug` varchar(15) DEFAULT NULL,
  `posicion_jug` varchar(15) DEFAULT NULL,
  `equipo_jug` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `futbol2`
--

INSERT INTO `futbol2` (`id_jug`, `nombre_jug`, `apellido_jug`, `posicion_jug`, `equipo_jug`) VALUES
(1, 'Iker', 'Casillas', 'Portero', 'Madrid'),
(2, 'Sergio', 'Ramos', 'Defensa', 'Madrid'),
(3, 'Alejandro', 'Valverde', 'Centrocampista', 'Madrid'),
(4, 'Karin', 'Bencema', 'Delantero', 'Madrid'),
(5, 'Luka', 'Modric', 'Centrocampista', 'Madrid'),
(6, 'Luis', 'Fernandez', 'Portero', 'Barcelona'),
(7, 'Juan', 'Alvarez', 'Defensa', 'Barcelona'),
(8, 'Xavi', 'Alonso', 'Centrocampista', 'Barcelona'),
(9, 'Fernando', 'Hierro', 'Centrocampista', 'Barcelona'),
(10, 'Felipe', 'Case', 'Delantero', 'Valencia'),
(11, 'Juan I', 'Garcia', 'Portero', 'Valencia'),
(12, 'Sergio a', 'Garcia a', 'Centrocampista', 'Valencia'),
(13, 'Felipe b', 'Reyes', 'Centrocampista', 'Valencia'),
(14, 'Luis c', 'Reyes', 'Delantero', 'Valencia'),
(15, 'Jose', 'Carvajal', 'Delantero', 'Sevilla'),
(16, 'Jose Luis', 'Fernandez', 'Portero', 'Sevilla'),
(17, 'Jose Alberto', 'Ruiz', 'Defensa', 'Sevilla'),
(18, 'Juan Jose', 'Luis', 'Centrocampista', 'Sevilla'),
(19, 'Jose Fernando', 'Alonso', 'Centrocampista', 'Sevilla'),
(20, 'Leonel', 'Mesi', 'Delantero', 'Barcelona');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `futbol3`
--

CREATE TABLE `futbol3` (
  `id_arb` int(11) NOT NULL,
  `nombre_arb` varchar(15) DEFAULT NULL,
  `apellido_arb` varchar(15) DEFAULT NULL,
  `posicion_arb` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `futbol3`
--

INSERT INTO `futbol3` (`id_arb`, `nombre_arb`, `apellido_arb`, `posicion_arb`) VALUES
(1, 'Alejandro Luis', 'Tobias', 'Principal'),
(2, 'Jose Carlos', 'Fernandez', 'Principal'),
(3, 'Felipe', 'Sanchez', 'Principal');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `futbol4`
--

CREATE TABLE `futbol4` (
  `id_sorteos` int(11) DEFAULT NULL,
  `nombre_equi1` varchar(30) DEFAULT NULL,
  `nombre_arb` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `futbol1`
--
ALTER TABLE `futbol1`
  ADD PRIMARY KEY (`id_equi`);

--
-- Indices de la tabla `futbol2`
--
ALTER TABLE `futbol2`
  ADD PRIMARY KEY (`id_jug`);

--
-- Indices de la tabla `futbol3`
--
ALTER TABLE `futbol3`
  ADD PRIMARY KEY (`id_arb`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `futbol1`
--
ALTER TABLE `futbol1`
  MODIFY `id_equi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `futbol2`
--
ALTER TABLE `futbol2`
  MODIFY `id_jug` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `futbol3`
--
ALTER TABLE `futbol3`
  MODIFY `id_arb` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;