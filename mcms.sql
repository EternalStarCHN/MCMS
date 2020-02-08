/*
SQLyog - Free MySQL GUI v5.12
Host - 5.5.35 : Database - mcms
*********************************************************************
Server version : 5.5.35
*/

SET NAMES utf8;

SET SQL_MODE='';

USE `mcms`;

/*Table structure for table `administrator` */

DROP TABLE IF EXISTS `administrator`;

CREATE TABLE `administrator` (
  `Administratorid` varchar(8) NOT NULL,
  `Password` varchar(10) NOT NULL,
  PRIMARY KEY (`Administratorid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `administrator` */

insert into `administrator` (`Administratorid`,`Password`) values ('31702440','yx990510');
insert into `administrator` (`Administratorid`,`Password`) values ('31702441','123456');

/*Table structure for table `consumption` */

DROP TABLE IF EXISTS `consumption`;

CREATE TABLE `consumption` (
  `MealCardId` varchar(8) NOT NULL,
  `DishId` varchar(8) NOT NULL,
  PRIMARY KEY (`MealCardId`,`DishId`),
  KEY `DishId` (`DishId`),
  CONSTRAINT `consumption_ibfk_1` FOREIGN KEY (`MealCardId`) REFERENCES `mealcard` (`MealCardId`),
  CONSTRAINT `consumption_ibfk_2` FOREIGN KEY (`DishId`) REFERENCES `dish` (`DishId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `consumption` */

/*Table structure for table `dish` */

DROP TABLE IF EXISTS `dish`;

CREATE TABLE `dish` (
  `DishId` varchar(8) NOT NULL,
  `DishQuantity` varchar(10) NOT NULL,
  `DishInformation` varchar(20) NOT NULL,
  `DishStatus` varchar(3) NOT NULL,
  PRIMARY KEY (`DishId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `dish` */

insert into `dish` (`DishId`,`DishQuantity`,`DishInformation`,`DishStatus`) values ('00','15','3.0','1');
insert into `dish` (`DishId`,`DishQuantity`,`DishInformation`,`DishStatus`) values ('01','10','2.5','1');
insert into `dish` (`DishId`,`DishQuantity`,`DishInformation`,`DishStatus`) values ('02','20','3.5','1');
insert into `dish` (`DishId`,`DishQuantity`,`DishInformation`,`DishStatus`) values ('03','10','2.5','0');
insert into `dish` (`DishId`,`DishQuantity`,`DishInformation`,`DishStatus`) values ('04','20','2.0','1');

/*Table structure for table `management` */

DROP TABLE IF EXISTS `management`;

CREATE TABLE `management` (
  `AdministratorId` varchar(8) NOT NULL,
  `DishId` varchar(8) NOT NULL,
  `IncreaseorDecrease` int(11) NOT NULL,
  PRIMARY KEY (`AdministratorId`,`DishId`),
  KEY `DishId` (`DishId`),
  CONSTRAINT `management_ibfk_1` FOREIGN KEY (`AdministratorId`) REFERENCES `administrator` (`Administratorid`),
  CONSTRAINT `management_ibfk_2` FOREIGN KEY (`DishId`) REFERENCES `dish` (`DishId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `management` */

/*Table structure for table `mealcard` */

DROP TABLE IF EXISTS `mealcard`;

CREATE TABLE `mealcard` (
  `MealCardId` varchar(8) NOT NULL,
  `MealCardInformation` varchar(20) NOT NULL,
  `MealCardStatus` varchar(3) NOT NULL,
  PRIMARY KEY (`MealCardId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `mealcard` */

insert into `mealcard` (`MealCardId`,`MealCardInformation`,`MealCardStatus`) values ('31702242','50','1');
insert into `mealcard` (`MealCardId`,`MealCardInformation`,`MealCardStatus`) values ('31702374','10000','1');
insert into `mealcard` (`MealCardId`,`MealCardInformation`,`MealCardStatus`) values ('31702440','15000','1');
insert into `mealcard` (`MealCardId`,`MealCardInformation`,`MealCardStatus`) values ('31702457','5000','1');
insert into `mealcard` (`MealCardId`,`MealCardInformation`,`MealCardStatus`) values ('31702503','10000','1');
insert into `mealcard` (`MealCardId`,`MealCardInformation`,`MealCardStatus`) values ('31705542','15500','1');
