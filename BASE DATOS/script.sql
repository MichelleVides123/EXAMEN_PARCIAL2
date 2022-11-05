-- MySQL Script generated by MySQL Workbench
-- Fri Nov  4 16:30:14 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Examen
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Examen
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Examen` DEFAULT CHARACTER SET utf8 ;
USE `Examen` ;

-- -----------------------------------------------------
-- Table `Examen`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen`.`Usuario` (
  `Codigo` NVARCHAR(20) NOT NULL,
  `Nombre` NVARCHAR(50) NOT NULL,
  `Clave` NVARCHAR(120) NOT NULL,
  `Correo` NVARCHAR(45) NULL,
  `Rol` NVARCHAR(20) NOT NULL,
  `EstActivo` TINYINT NOT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Examen`.`Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Examen`.`Producto` (
  `Codigo` INT NOT NULL,
  `Descripcion` NVARCHAR(50) NOT NULL,
  `Existencia` INT NOT NULL,
  `Precio` DECIMAL NOT NULL,
  `Fecha` DATETIME NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
