-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-05-2022 a las 19:58:37
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
(1, 'FC Barcelona', 'Felipe Gozalez'),
(2, 'Real Madrid', 'Raul Lopez'),
(3, 'Sevilla', 'Armando Ortega'),
(4, 'Valencia', 'Felipe Dosantos');

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
(1, 'Julian', 'Perez', 'Portero', 'Real Madrid'),
(2, 'Felipe', 'Lopez', 'Defensa', 'Real Madrid'),
(3, 'Alejandro', 'Almeida', 'Centrocampista', 'Real Madrid'),
(4, 'Esteban', 'Garcia', 'Centrocampista', 'Real Madrid'),
(5, 'Juan', 'Garcia', 'Delantero', 'Real Madrid'),
(6, 'Paco', 'Buyo', 'Delantero', 'Valencia'),
(7, 'Luis', 'Fernandez', 'Defensa', 'Valencia'),
(8, 'Jesus', 'Esteban', 'Portero', 'Valencia'),
(9, 'Carlos', 'Arias', 'Centrocampista', 'Valencia'),
(10, 'Raul', 'Martin', 'Centrocampista', 'Valencia'),
(11, 'Jose', 'Perez', 'Centrocampista', 'Sevilla'),
(12, 'Luis Felipe', 'Garcia', 'Portero', 'Sevilla'),
(13, 'Oscar', 'Montero', 'Centrocampista', 'Sevilla'),
(14, 'Oscar i', 'Lopez', 'Delantero', 'Sevilla'),
(15, 'Francisco', 'Malagón', 'Defensa', 'Sevilla'),
(16, 'Juan Ignacio', 'Parada', 'Portero', 'FC Barcelona'),
(17, 'Esteban Jose', 'Hernandez', 'Defensa', 'FC Barcelona'),
(18, 'Luis Juan', 'Hernandez', 'Centrocampista', 'FC Barcelona'),
(19, 'Sergio', 'Garcia', 'Centrocampista', 'FC Barcelona'),
(20, 'Alex', 'Camara', 'Delantero', 'FC Barcelona');

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
(1, 'Esteban', 'Gonzalez', 'Principal'),
(2, 'Felipe', 'Lopez', 'Secundario'),
(3, 'Carlos', 'Martin', 'Principal'),
(4, 'Luis', 'De la Hoz', 'Principal'),
(5, 'Ruben', 'Felipe', 'Secundario'),
(6, 'Ruben a', 'Garcia', 'Secundario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `futbol4`
--

CREATE TABLE `futbol4` (
  `id_sorteos` int(11) DEFAULT NULL,
  `nombre_equi1` varchar(15) DEFAULT NULL,
  `nombre_equi2` varchar(15) DEFAULT NULL,
  `nombre_arb` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `futbol4`
--

INSERT INTO `futbol4` (`id_sorteos`, `nombre_equi1`, `nombre_equi2`, `nombre_arb`) VALUES
(1, 'FC Barcelona', 'Valencia', 'Esteban'),
(1, 'Real Madrid', 'Valencia', 'Esteban'),
(1, 'Sevilla', 'Valencia', 'Esteban'),
(1, 'Valencia', 'Valencia', 'Esteban'),
(1, 'FC Barcelona', 'Valencia', 'Felipe'),
(1, 'Real Madrid', 'Valencia', 'Felipe'),
(1, 'Sevilla', 'Valencia', 'Felipe'),
(1, 'Valencia', 'Valencia', 'Felipe'),
(1, 'FC Barcelona', 'Valencia', 'Carlos'),
(1, 'Real Madrid', 'Valencia', 'Carlos'),
(1, 'Sevilla', 'Valencia', 'Carlos'),
(1, 'Valencia', 'Valencia', 'Carlos'),
(1, 'FC Barcelona', 'Valencia', 'Luis'),
(1, 'Real Madrid', 'Valencia', 'Luis'),
(1, 'Sevilla', 'Valencia', 'Luis'),
(1, 'Valencia', 'Valencia', 'Luis'),
(1, 'FC Barcelona', 'Valencia', 'Ruben'),
(1, 'Real Madrid', 'Valencia', 'Ruben'),
(1, 'Sevilla', 'Valencia', 'Ruben'),
(1, 'Valencia', 'Valencia', 'Ruben'),
(1, 'FC Barcelona', 'Valencia', 'Ruben a'),
(1, 'Real Madrid', 'Valencia', 'Ruben a'),
(1, 'Sevilla', 'Valencia', 'Ruben a'),
(1, 'Valencia', 'Valencia', 'Ruben a'),
(2, 'FC Barcelona', 'Valencia', 'Esteban'),
(2, 'Real Madrid', 'Valencia', 'Esteban'),
(2, 'Sevilla', 'Valencia', 'Esteban'),
(2, 'Valencia', 'Valencia', 'Esteban'),
(2, 'FC Barcelona', 'Valencia', 'Felipe'),
(2, 'Real Madrid', 'Valencia', 'Felipe'),
(2, 'Sevilla', 'Valencia', 'Felipe'),
(2, 'Valencia', 'Valencia', 'Felipe'),
(2, 'FC Barcelona', 'Valencia', 'Carlos'),
(2, 'Real Madrid', 'Valencia', 'Carlos'),
(2, 'Sevilla', 'Valencia', 'Carlos'),
(2, 'Valencia', 'Valencia', 'Carlos'),
(2, 'FC Barcelona', 'Valencia', 'Luis'),
(2, 'Real Madrid', 'Valencia', 'Luis'),
(2, 'Sevilla', 'Valencia', 'Luis'),
(2, 'Valencia', 'Valencia', 'Luis'),
(2, 'FC Barcelona', 'Valencia', 'Ruben'),
(2, 'Real Madrid', 'Valencia', 'Ruben'),
(2, 'Sevilla', 'Valencia', 'Ruben'),
(2, 'Valencia', 'Valencia', 'Ruben'),
(2, 'FC Barcelona', 'Valencia', 'Ruben a'),
(2, 'Real Madrid', 'Valencia', 'Ruben a'),
(2, 'Sevilla', 'Valencia', 'Ruben a'),
(2, 'Valencia', 'Valencia', 'Ruben a'),
(3, 'FC Barcelona', 'Valencia', 'Esteban'),
(3, 'Real Madrid', 'Valencia', 'Esteban'),
(3, 'Sevilla', 'Valencia', 'Esteban'),
(3, 'Valencia', 'Valencia', 'Esteban'),
(3, 'FC Barcelona', 'Valencia', 'Felipe'),
(3, 'Real Madrid', 'Valencia', 'Felipe'),
(3, 'Sevilla', 'Valencia', 'Felipe'),
(3, 'Valencia', 'Valencia', 'Felipe'),
(3, 'FC Barcelona', 'Valencia', 'Carlos'),
(3, 'Real Madrid', 'Valencia', 'Carlos'),
(3, 'Sevilla', 'Valencia', 'Carlos'),
(3, 'Valencia', 'Valencia', 'Carlos'),
(3, 'FC Barcelona', 'Valencia', 'Luis'),
(3, 'Real Madrid', 'Valencia', 'Luis'),
(3, 'Sevilla', 'Valencia', 'Luis'),
(3, 'Valencia', 'Valencia', 'Luis'),
(3, 'FC Barcelona', 'Valencia', 'Ruben'),
(3, 'Real Madrid', 'Valencia', 'Ruben'),
(3, 'Sevilla', 'Valencia', 'Ruben'),
(3, 'Valencia', 'Valencia', 'Ruben'),
(3, 'FC Barcelona', 'Valencia', 'Ruben a'),
(3, 'Real Madrid', 'Valencia', 'Ruben a'),
(3, 'Sevilla', 'Valencia', 'Ruben a'),
(3, 'Valencia', 'Valencia', 'Ruben a'),
(4, 'FC Barcelona', 'Valencia', 'Esteban'),
(4, 'Real Madrid', 'Valencia', 'Esteban'),
(4, 'Sevilla', 'Valencia', 'Esteban'),
(4, 'Valencia', 'Valencia', 'Esteban'),
(4, 'FC Barcelona', 'Valencia', 'Felipe'),
(4, 'Real Madrid', 'Valencia', 'Felipe'),
(4, 'Sevilla', 'Valencia', 'Felipe'),
(4, 'Valencia', 'Valencia', 'Felipe'),
(4, 'FC Barcelona', 'Valencia', 'Carlos'),
(4, 'Real Madrid', 'Valencia', 'Carlos'),
(4, 'Sevilla', 'Valencia', 'Carlos'),
(4, 'Valencia', 'Valencia', 'Carlos'),
(4, 'FC Barcelona', 'Valencia', 'Luis'),
(4, 'Real Madrid', 'Valencia', 'Luis'),
(4, 'Sevilla', 'Valencia', 'Luis'),
(4, 'Valencia', 'Valencia', 'Luis'),
(4, 'FC Barcelona', 'Valencia', 'Ruben'),
(4, 'Real Madrid', 'Valencia', 'Ruben'),
(4, 'Sevilla', 'Valencia', 'Ruben'),
(4, 'Valencia', 'Valencia', 'Ruben'),
(4, 'FC Barcelona', 'Valencia', 'Ruben a'),
(4, 'Real Madrid', 'Valencia', 'Ruben a'),
(4, 'Sevilla', 'Valencia', 'Ruben a'),
(4, 'Valencia', 'Valencia', 'Ruben a'),
(1, 'FC Barcelona', 'Sevilla', 'Esteban'),
(1, 'Real Madrid', 'Sevilla', 'Esteban'),
(1, 'Sevilla', 'Sevilla', 'Esteban'),
(1, 'Valencia', 'Sevilla', 'Esteban'),
(1, 'FC Barcelona', 'Sevilla', 'Felipe'),
(1, 'Real Madrid', 'Sevilla', 'Felipe'),
(1, 'Sevilla', 'Sevilla', 'Felipe'),
(1, 'Valencia', 'Sevilla', 'Felipe'),
(1, 'FC Barcelona', 'Sevilla', 'Carlos'),
(1, 'Real Madrid', 'Sevilla', 'Carlos'),
(1, 'Sevilla', 'Sevilla', 'Carlos'),
(1, 'Valencia', 'Sevilla', 'Carlos'),
(1, 'FC Barcelona', 'Sevilla', 'Luis'),
(1, 'Real Madrid', 'Sevilla', 'Luis'),
(1, 'Sevilla', 'Sevilla', 'Luis'),
(1, 'Valencia', 'Sevilla', 'Luis'),
(1, 'FC Barcelona', 'Sevilla', 'Ruben'),
(1, 'Real Madrid', 'Sevilla', 'Ruben'),
(1, 'Sevilla', 'Sevilla', 'Ruben'),
(1, 'Valencia', 'Sevilla', 'Ruben'),
(1, 'FC Barcelona', 'Sevilla', 'Ruben a'),
(1, 'Real Madrid', 'Sevilla', 'Ruben a'),
(1, 'Sevilla', 'Sevilla', 'Ruben a'),
(1, 'Valencia', 'Sevilla', 'Ruben a'),
(2, 'FC Barcelona', 'Sevilla', 'Esteban'),
(2, 'Real Madrid', 'Sevilla', 'Esteban'),
(2, 'Sevilla', 'Sevilla', 'Esteban'),
(2, 'Valencia', 'Sevilla', 'Esteban'),
(2, 'FC Barcelona', 'Sevilla', 'Felipe'),
(2, 'Real Madrid', 'Sevilla', 'Felipe'),
(2, 'Sevilla', 'Sevilla', 'Felipe'),
(2, 'Valencia', 'Sevilla', 'Felipe'),
(2, 'FC Barcelona', 'Sevilla', 'Carlos'),
(2, 'Real Madrid', 'Sevilla', 'Carlos'),
(2, 'Sevilla', 'Sevilla', 'Carlos'),
(2, 'Valencia', 'Sevilla', 'Carlos'),
(2, 'FC Barcelona', 'Sevilla', 'Luis'),
(2, 'Real Madrid', 'Sevilla', 'Luis'),
(2, 'Sevilla', 'Sevilla', 'Luis'),
(2, 'Valencia', 'Sevilla', 'Luis'),
(2, 'FC Barcelona', 'Sevilla', 'Ruben'),
(2, 'Real Madrid', 'Sevilla', 'Ruben'),
(2, 'Sevilla', 'Sevilla', 'Ruben'),
(2, 'Valencia', 'Sevilla', 'Ruben'),
(2, 'FC Barcelona', 'Sevilla', 'Ruben a'),
(2, 'Real Madrid', 'Sevilla', 'Ruben a'),
(2, 'Sevilla', 'Sevilla', 'Ruben a'),
(2, 'Valencia', 'Sevilla', 'Ruben a'),
(3, 'FC Barcelona', 'Sevilla', 'Esteban'),
(3, 'Real Madrid', 'Sevilla', 'Esteban'),
(3, 'Sevilla', 'Sevilla', 'Esteban'),
(3, 'Valencia', 'Sevilla', 'Esteban'),
(3, 'FC Barcelona', 'Sevilla', 'Felipe'),
(3, 'Real Madrid', 'Sevilla', 'Felipe'),
(3, 'Sevilla', 'Sevilla', 'Felipe'),
(3, 'Valencia', 'Sevilla', 'Felipe'),
(3, 'FC Barcelona', 'Sevilla', 'Carlos'),
(3, 'Real Madrid', 'Sevilla', 'Carlos'),
(3, 'Sevilla', 'Sevilla', 'Carlos'),
(3, 'Valencia', 'Sevilla', 'Carlos'),
(3, 'FC Barcelona', 'Sevilla', 'Luis'),
(3, 'Real Madrid', 'Sevilla', 'Luis'),
(3, 'Sevilla', 'Sevilla', 'Luis'),
(3, 'Valencia', 'Sevilla', 'Luis'),
(3, 'FC Barcelona', 'Sevilla', 'Ruben'),
(3, 'Real Madrid', 'Sevilla', 'Ruben'),
(3, 'Sevilla', 'Sevilla', 'Ruben'),
(3, 'Valencia', 'Sevilla', 'Ruben'),
(3, 'FC Barcelona', 'Sevilla', 'Ruben a'),
(3, 'Real Madrid', 'Sevilla', 'Ruben a'),
(3, 'Sevilla', 'Sevilla', 'Ruben a'),
(3, 'Valencia', 'Sevilla', 'Ruben a'),
(4, 'FC Barcelona', 'Sevilla', 'Esteban'),
(4, 'Real Madrid', 'Sevilla', 'Esteban'),
(4, 'Sevilla', 'Sevilla', 'Esteban'),
(4, 'Valencia', 'Sevilla', 'Esteban'),
(4, 'FC Barcelona', 'Sevilla', 'Felipe'),
(4, 'Real Madrid', 'Sevilla', 'Felipe'),
(4, 'Sevilla', 'Sevilla', 'Felipe'),
(4, 'Valencia', 'Sevilla', 'Felipe'),
(4, 'FC Barcelona', 'Sevilla', 'Carlos'),
(4, 'Real Madrid', 'Sevilla', 'Carlos'),
(4, 'Sevilla', 'Sevilla', 'Carlos'),
(4, 'Valencia', 'Sevilla', 'Carlos'),
(4, 'FC Barcelona', 'Sevilla', 'Luis'),
(4, 'Real Madrid', 'Sevilla', 'Luis'),
(4, 'Sevilla', 'Sevilla', 'Luis'),
(4, 'Valencia', 'Sevilla', 'Luis'),
(4, 'FC Barcelona', 'Sevilla', 'Ruben'),
(4, 'Real Madrid', 'Sevilla', 'Ruben'),
(4, 'Sevilla', 'Sevilla', 'Ruben'),
(4, 'Valencia', 'Sevilla', 'Ruben'),
(4, 'FC Barcelona', 'Sevilla', 'Ruben a'),
(4, 'Real Madrid', 'Sevilla', 'Ruben a'),
(4, 'Sevilla', 'Sevilla', 'Ruben a'),
(4, 'Valencia', 'Sevilla', 'Ruben a'),
(1, 'FC Barcelona', 'Real Madrid', 'Esteban'),
(1, 'Real Madrid', 'Real Madrid', 'Esteban'),
(1, 'Sevilla', 'Real Madrid', 'Esteban'),
(1, 'Valencia', 'Real Madrid', 'Esteban'),
(1, 'FC Barcelona', 'Real Madrid', 'Felipe'),
(1, 'Real Madrid', 'Real Madrid', 'Felipe'),
(1, 'Sevilla', 'Real Madrid', 'Felipe'),
(1, 'Valencia', 'Real Madrid', 'Felipe'),
(1, 'FC Barcelona', 'Real Madrid', 'Carlos'),
(1, 'Real Madrid', 'Real Madrid', 'Carlos'),
(1, 'Sevilla', 'Real Madrid', 'Carlos'),
(1, 'Valencia', 'Real Madrid', 'Carlos'),
(1, 'FC Barcelona', 'Real Madrid', 'Luis'),
(1, 'Real Madrid', 'Real Madrid', 'Luis'),
(1, 'Sevilla', 'Real Madrid', 'Luis'),
(1, 'Valencia', 'Real Madrid', 'Luis'),
(1, 'FC Barcelona', 'Real Madrid', 'Ruben'),
(1, 'Real Madrid', 'Real Madrid', 'Ruben'),
(1, 'Sevilla', 'Real Madrid', 'Ruben'),
(1, 'Valencia', 'Real Madrid', 'Ruben'),
(1, 'FC Barcelona', 'Real Madrid', 'Ruben a'),
(1, 'Real Madrid', 'Real Madrid', 'Ruben a'),
(1, 'Sevilla', 'Real Madrid', 'Ruben a'),
(1, 'Valencia', 'Real Madrid', 'Ruben a'),
(2, 'FC Barcelona', 'Real Madrid', 'Esteban'),
(2, 'Real Madrid', 'Real Madrid', 'Esteban'),
(2, 'Sevilla', 'Real Madrid', 'Esteban'),
(2, 'Valencia', 'Real Madrid', 'Esteban'),
(2, 'FC Barcelona', 'Real Madrid', 'Felipe'),
(2, 'Real Madrid', 'Real Madrid', 'Felipe'),
(2, 'Sevilla', 'Real Madrid', 'Felipe'),
(2, 'Valencia', 'Real Madrid', 'Felipe'),
(2, 'FC Barcelona', 'Real Madrid', 'Carlos'),
(2, 'Real Madrid', 'Real Madrid', 'Carlos'),
(2, 'Sevilla', 'Real Madrid', 'Carlos'),
(2, 'Valencia', 'Real Madrid', 'Carlos'),
(2, 'FC Barcelona', 'Real Madrid', 'Luis'),
(2, 'Real Madrid', 'Real Madrid', 'Luis'),
(2, 'Sevilla', 'Real Madrid', 'Luis'),
(2, 'Valencia', 'Real Madrid', 'Luis'),
(2, 'FC Barcelona', 'Real Madrid', 'Ruben'),
(2, 'Real Madrid', 'Real Madrid', 'Ruben'),
(2, 'Sevilla', 'Real Madrid', 'Ruben'),
(2, 'Valencia', 'Real Madrid', 'Ruben'),
(2, 'FC Barcelona', 'Real Madrid', 'Ruben a'),
(2, 'Real Madrid', 'Real Madrid', 'Ruben a'),
(2, 'Sevilla', 'Real Madrid', 'Ruben a'),
(2, 'Valencia', 'Real Madrid', 'Ruben a'),
(3, 'FC Barcelona', 'Real Madrid', 'Esteban'),
(3, 'Real Madrid', 'Real Madrid', 'Esteban'),
(3, 'Sevilla', 'Real Madrid', 'Esteban'),
(3, 'Valencia', 'Real Madrid', 'Esteban'),
(3, 'FC Barcelona', 'Real Madrid', 'Felipe'),
(3, 'Real Madrid', 'Real Madrid', 'Felipe'),
(3, 'Sevilla', 'Real Madrid', 'Felipe'),
(3, 'Valencia', 'Real Madrid', 'Felipe'),
(3, 'FC Barcelona', 'Real Madrid', 'Carlos'),
(3, 'Real Madrid', 'Real Madrid', 'Carlos'),
(3, 'Sevilla', 'Real Madrid', 'Carlos'),
(3, 'Valencia', 'Real Madrid', 'Carlos'),
(3, 'FC Barcelona', 'Real Madrid', 'Luis'),
(3, 'Real Madrid', 'Real Madrid', 'Luis'),
(3, 'Sevilla', 'Real Madrid', 'Luis'),
(3, 'Valencia', 'Real Madrid', 'Luis'),
(3, 'FC Barcelona', 'Real Madrid', 'Ruben'),
(3, 'Real Madrid', 'Real Madrid', 'Ruben'),
(3, 'Sevilla', 'Real Madrid', 'Ruben'),
(3, 'Valencia', 'Real Madrid', 'Ruben'),
(3, 'FC Barcelona', 'Real Madrid', 'Ruben a'),
(3, 'Real Madrid', 'Real Madrid', 'Ruben a'),
(3, 'Sevilla', 'Real Madrid', 'Ruben a'),
(3, 'Valencia', 'Real Madrid', 'Ruben a'),
(4, 'FC Barcelona', 'Real Madrid', 'Esteban'),
(4, 'Real Madrid', 'Real Madrid', 'Esteban'),
(4, 'Sevilla', 'Real Madrid', 'Esteban'),
(4, 'Valencia', 'Real Madrid', 'Esteban'),
(4, 'FC Barcelona', 'Real Madrid', 'Felipe'),
(4, 'Real Madrid', 'Real Madrid', 'Felipe'),
(4, 'Sevilla', 'Real Madrid', 'Felipe'),
(4, 'Valencia', 'Real Madrid', 'Felipe'),
(4, 'FC Barcelona', 'Real Madrid', 'Carlos'),
(4, 'Real Madrid', 'Real Madrid', 'Carlos'),
(4, 'Sevilla', 'Real Madrid', 'Carlos'),
(4, 'Valencia', 'Real Madrid', 'Carlos'),
(4, 'FC Barcelona', 'Real Madrid', 'Luis'),
(4, 'Real Madrid', 'Real Madrid', 'Luis'),
(4, 'Sevilla', 'Real Madrid', 'Luis'),
(4, 'Valencia', 'Real Madrid', 'Luis'),
(4, 'FC Barcelona', 'Real Madrid', 'Ruben'),
(4, 'Real Madrid', 'Real Madrid', 'Ruben'),
(4, 'Sevilla', 'Real Madrid', 'Ruben'),
(4, 'Valencia', 'Real Madrid', 'Ruben'),
(4, 'FC Barcelona', 'Real Madrid', 'Ruben a'),
(4, 'Real Madrid', 'Real Madrid', 'Ruben a'),
(4, 'Sevilla', 'Real Madrid', 'Ruben a'),
(4, 'Valencia', 'Real Madrid', 'Ruben a'),
(1, 'FC Barcelona', 'FC Barcelona', 'Esteban'),
(1, 'Real Madrid', 'FC Barcelona', 'Esteban'),
(1, 'Sevilla', 'FC Barcelona', 'Esteban'),
(1, 'Valencia', 'FC Barcelona', 'Esteban'),
(1, 'FC Barcelona', 'FC Barcelona', 'Felipe'),
(1, 'Real Madrid', 'FC Barcelona', 'Felipe'),
(1, 'Sevilla', 'FC Barcelona', 'Felipe'),
(1, 'Valencia', 'FC Barcelona', 'Felipe'),
(1, 'FC Barcelona', 'FC Barcelona', 'Carlos'),
(1, 'Real Madrid', 'FC Barcelona', 'Carlos'),
(1, 'Sevilla', 'FC Barcelona', 'Carlos'),
(1, 'Valencia', 'FC Barcelona', 'Carlos'),
(1, 'FC Barcelona', 'FC Barcelona', 'Luis'),
(1, 'Real Madrid', 'FC Barcelona', 'Luis'),
(1, 'Sevilla', 'FC Barcelona', 'Luis'),
(1, 'Valencia', 'FC Barcelona', 'Luis'),
(1, 'FC Barcelona', 'FC Barcelona', 'Ruben'),
(1, 'Real Madrid', 'FC Barcelona', 'Ruben'),
(1, 'Sevilla', 'FC Barcelona', 'Ruben'),
(1, 'Valencia', 'FC Barcelona', 'Ruben'),
(1, 'FC Barcelona', 'FC Barcelona', 'Ruben a'),
(1, 'Real Madrid', 'FC Barcelona', 'Ruben a'),
(1, 'Sevilla', 'FC Barcelona', 'Ruben a'),
(1, 'Valencia', 'FC Barcelona', 'Ruben a'),
(2, 'FC Barcelona', 'FC Barcelona', 'Esteban'),
(2, 'Real Madrid', 'FC Barcelona', 'Esteban'),
(2, 'Sevilla', 'FC Barcelona', 'Esteban'),
(2, 'Valencia', 'FC Barcelona', 'Esteban'),
(2, 'FC Barcelona', 'FC Barcelona', 'Felipe'),
(2, 'Real Madrid', 'FC Barcelona', 'Felipe'),
(2, 'Sevilla', 'FC Barcelona', 'Felipe'),
(2, 'Valencia', 'FC Barcelona', 'Felipe'),
(2, 'FC Barcelona', 'FC Barcelona', 'Carlos'),
(2, 'Real Madrid', 'FC Barcelona', 'Carlos'),
(2, 'Sevilla', 'FC Barcelona', 'Carlos'),
(2, 'Valencia', 'FC Barcelona', 'Carlos'),
(2, 'FC Barcelona', 'FC Barcelona', 'Luis'),
(2, 'Real Madrid', 'FC Barcelona', 'Luis'),
(2, 'Sevilla', 'FC Barcelona', 'Luis'),
(2, 'Valencia', 'FC Barcelona', 'Luis'),
(2, 'FC Barcelona', 'FC Barcelona', 'Ruben'),
(2, 'Real Madrid', 'FC Barcelona', 'Ruben'),
(2, 'Sevilla', 'FC Barcelona', 'Ruben'),
(2, 'Valencia', 'FC Barcelona', 'Ruben'),
(2, 'FC Barcelona', 'FC Barcelona', 'Ruben a'),
(2, 'Real Madrid', 'FC Barcelona', 'Ruben a'),
(2, 'Sevilla', 'FC Barcelona', 'Ruben a'),
(2, 'Valencia', 'FC Barcelona', 'Ruben a'),
(3, 'FC Barcelona', 'FC Barcelona', 'Esteban'),
(3, 'Real Madrid', 'FC Barcelona', 'Esteban'),
(3, 'Sevilla', 'FC Barcelona', 'Esteban'),
(3, 'Valencia', 'FC Barcelona', 'Esteban'),
(3, 'FC Barcelona', 'FC Barcelona', 'Felipe'),
(3, 'Real Madrid', 'FC Barcelona', 'Felipe'),
(3, 'Sevilla', 'FC Barcelona', 'Felipe'),
(3, 'Valencia', 'FC Barcelona', 'Felipe'),
(3, 'FC Barcelona', 'FC Barcelona', 'Carlos'),
(3, 'Real Madrid', 'FC Barcelona', 'Carlos'),
(3, 'Sevilla', 'FC Barcelona', 'Carlos'),
(3, 'Valencia', 'FC Barcelona', 'Carlos'),
(3, 'FC Barcelona', 'FC Barcelona', 'Luis'),
(3, 'Real Madrid', 'FC Barcelona', 'Luis'),
(3, 'Sevilla', 'FC Barcelona', 'Luis'),
(3, 'Valencia', 'FC Barcelona', 'Luis'),
(3, 'FC Barcelona', 'FC Barcelona', 'Ruben'),
(3, 'Real Madrid', 'FC Barcelona', 'Ruben'),
(3, 'Sevilla', 'FC Barcelona', 'Ruben'),
(3, 'Valencia', 'FC Barcelona', 'Ruben'),
(3, 'FC Barcelona', 'FC Barcelona', 'Ruben a'),
(3, 'Real Madrid', 'FC Barcelona', 'Ruben a'),
(3, 'Sevilla', 'FC Barcelona', 'Ruben a'),
(3, 'Valencia', 'FC Barcelona', 'Ruben a'),
(4, 'FC Barcelona', 'FC Barcelona', 'Esteban'),
(4, 'Real Madrid', 'FC Barcelona', 'Esteban'),
(4, 'Sevilla', 'FC Barcelona', 'Esteban'),
(4, 'Valencia', 'FC Barcelona', 'Esteban'),
(4, 'FC Barcelona', 'FC Barcelona', 'Felipe'),
(4, 'Real Madrid', 'FC Barcelona', 'Felipe'),
(4, 'Sevilla', 'FC Barcelona', 'Felipe'),
(4, 'Valencia', 'FC Barcelona', 'Felipe'),
(4, 'FC Barcelona', 'FC Barcelona', 'Carlos'),
(4, 'Real Madrid', 'FC Barcelona', 'Carlos'),
(4, 'Sevilla', 'FC Barcelona', 'Carlos'),
(4, 'Valencia', 'FC Barcelona', 'Carlos'),
(4, 'FC Barcelona', 'FC Barcelona', 'Luis'),
(4, 'Real Madrid', 'FC Barcelona', 'Luis'),
(4, 'Sevilla', 'FC Barcelona', 'Luis'),
(4, 'Valencia', 'FC Barcelona', 'Luis'),
(4, 'FC Barcelona', 'FC Barcelona', 'Ruben'),
(4, 'Real Madrid', 'FC Barcelona', 'Ruben'),
(4, 'Sevilla', 'FC Barcelona', 'Ruben'),
(4, 'Valencia', 'FC Barcelona', 'Ruben'),
(4, 'FC Barcelona', 'FC Barcelona', 'Ruben a'),
(4, 'Real Madrid', 'FC Barcelona', 'Ruben a'),
(4, 'Sevilla', 'FC Barcelona', 'Ruben a'),
(4, 'Valencia', 'FC Barcelona', 'Ruben a');

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
  MODIFY `id_equi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `futbol2`
--
ALTER TABLE `futbol2`
  MODIFY `id_jug` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `futbol3`
--
ALTER TABLE `futbol3`
  MODIFY `id_arb` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;