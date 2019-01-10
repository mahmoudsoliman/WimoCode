CREATE DATABASE  IF NOT EXISTS `wimo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `wimo`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: wimo
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tasks`
--

DROP TABLE IF EXISTS `tasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tasks` (
  `taskId` bigint(20) NOT NULL AUTO_INCREMENT,
  `taskKey` varchar(20) NOT NULL,
  `fromLocation` varchar(20) NOT NULL,
  `toLocation` varchar(20) NOT NULL,
  `deliveryDate` date NOT NULL,
  `startedAt` date DEFAULT NULL,
  `finishedAt` date DEFAULT NULL,
  `driverName` varchar(50) NOT NULL,
  `courier` varchar(50) NOT NULL,
  `description` longtext,
  `status` varchar(20) NOT NULL,
  `driverComment` longtext,
  `createdOn` date DEFAULT NULL,
  PRIMARY KEY (`taskId`),
  UNIQUE KEY `taskId_UNIQUE` (`taskId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasks`
--

LOCK TABLES `tasks` WRITE;
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` VALUES (1,'s6ca9a74uq','25.204849,55.270783','25.125386, 55.227821','2019-05-10','2019-05-10','2019-05-10','Marko Pandres','FastWay','Deliver a credit card, user must sign','completed',NULL,'2019-01-09'),(2,'4m2bdx76tu','25.191099, 55.283402','25.127795, 55.226619','2019-05-10','2019-05-10','2019-05-10','Anmol Dares','Wimo','Deliver a bank statement','completed',NULL,'2019-01-09'),(3,'omv3q98gn2','25.194594, 55.274034','25.138623, 55.231355','2019-05-10','2019-05-10','2019-05-10','Marko Pandres','FastWay','Deliver souq.com order','completed',NULL,'2019-01-09'),(4,'dv186ic8t2','25.166517, 55.278027','25.089483, 55.189321','2019-05-10','2019-05-10','2019-05-10','Adam Aldo','Wimo','Grocery Delivery','failed','Can\'t reach the customer, customer not answering calls','2019-01-09'),(5,'6v1v519a16','25.166517, 55.278027','25.074626, 55.193905','2019-05-10','2019-05-10','2019-05-10','Marko Pandres','FastWay','Deliver a credit card, user must sign','completed',NULL,'2019-01-09'),(6,'sn6jshfmns','25.166051, 55.271847','25.074626, 55.193905','2019-05-10','2019-05-10','2019-05-10','Adam Aldo','Wimo','Deliver noon.com shipping','completed',NULL,'2019-01-09'),(7,'9dewnwxgbf','25.194594, 55.274034','25.089483, 55.189321','2019-05-10','2019-05-10','2019-05-10','Anmol Dares','Wimo','Deliver a document shipping','completed',NULL,'2019-01-09'),(8,'5cn91j1jca','25.089240, 55.211242','25.138623, 55.231355','2019-05-22',NULL,NULL,'Nazih Omar','FastWay','Deliver emirates ID','pending',NULL,'2019-01-09'),(9,'6l8ymeuk7j','25.166051, 55.271847','25.127795, 55.226619','2019-05-12','2019-05-12',NULL,'Marko Pandres','FastWay','Deliver emirates ID','started',NULL,'2019-01-09'),(10,'zctz4drcdk','25.194594, 55.274034','25.125386, 55.227821','2019-05-25',NULL,NULL,'Adam Aldo','Wimo','Deliver a souq.com shipping','pending',NULL,'2019-01-09');
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-10 17:55:22
