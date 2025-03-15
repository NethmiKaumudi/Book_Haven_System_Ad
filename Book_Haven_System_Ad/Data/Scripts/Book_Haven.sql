CREATE DATABASE  IF NOT EXISTS `bookhaven` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bookhaven`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: bookhaven
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `BookID` char(36) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) DEFAULT NULL,
  `ISBN` varchar(20) DEFAULT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Stock` int NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES ('21f36f3a-f0da-4972-ab10-20ccb3d905d9','Madol Doova','Martin Wikramasinghe','9789555734201',500.00,27,0),('8bf19cd9-9d0e-4baf-bb61-ae385ee57871','Gamperaliya','Martin Wikaramasinghe','9781503280755',450.00,3,0),('96742ea9-3acf-42ac-802b-1e7f3fae06ca','Moby-Dick','Herman Melville','9781503280786',1250.00,15,0);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomerID` char(36) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  `Address` text,
  `IsDeleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`CustomerID`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES ('56aef362-897a-4a1b-aa15-fdceec33fcbc','Nimal','Nimal@gmail.com','0765242133','Nuwara',0),('729642f0-33ac-4aad-8561-d7a0b1f6130d','Charith','Charith@gmail.com','0725665412','Galle',0),('b8e6bc63-674b-49ce-9ee5-8ab931a1ec7b','Thisum Nethsara','thisum@gmail.com','0765321456','Baddegama',0),('d0276b17-f139-472d-99b4-c60af62509de','Jayani  Perera','Jayani@gmail.com','0756423155','Colombo',0);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetails` (
  `OrderDetailID` char(36) NOT NULL,
  `OrderID` varchar(10) NOT NULL,
  `BookID` char(36) NOT NULL,
  `Quantity` int NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`OrderDetailID`),
  KEY `OrderID` (`OrderID`),
  KEY `BookID` (`BookID`),
  CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`),
  CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES ('3af903d7-408e-4105-a687-5bb211f90316','OR-0002','8bf19cd9-9d0e-4baf-bb61-ae385ee57871',1,450.00),('49a79aa6-4840-4615-819d-e8d1839a4144','OR-0002','21f36f3a-f0da-4972-ab10-20ccb3d905d9',5,500.00),('5b24cf67-c713-40fe-97de-057e0273e670','OR-0003','21f36f3a-f0da-4972-ab10-20ccb3d905d9',2,500.00),('7d7513a4-f092-4225-8c58-d6c9abd38551','OR-0001','21f36f3a-f0da-4972-ab10-20ccb3d905d9',5,500.00),('8bbbc8e0-7e57-4470-995f-c11001029bca','OR-0004','8bf19cd9-9d0e-4baf-bb61-ae385ee57871',1,450.00),('aa5fa91f-2879-4c08-ae9c-2ba30bfc78fd','OR-0004','21f36f3a-f0da-4972-ab10-20ccb3d905d9',1,500.00);
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` varchar(10) NOT NULL,
  `CustomerID` char(36) NOT NULL,
  `TotalAmount` decimal(10,2) NOT NULL,
  `Status` enum('Pending','Shipped','Delivered','Canceled') DEFAULT NULL,
  `DeliveryType` enum('In-Store Pickup','Home Delivery') DEFAULT NULL,
  `DeliveryStatus` enum('Not Applicable','Processing','Out for Delivery','Delivered') DEFAULT NULL,
  `DeliveryAddress` varchar(255) DEFAULT NULL,
  `OrderDate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `ProcessedBy` varchar(255) NOT NULL,
  `IsDeleted` tinyint(1) DEFAULT '0',
  `OrderSource` enum('Online','POS') NOT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `CustomerID` (`CustomerID`),
  KEY `ProcessedBy` (`ProcessedBy`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES ('OR-0001','d0276b17-f139-472d-99b4-c60af62509de',2375.00,'Shipped',NULL,'Not Applicable',NULL,'2025-03-13 12:50:46','Nethmi',0,'POS'),('OR-0002','b8e6bc63-674b-49ce-9ee5-8ab931a1ec7b',2655.00,'Pending',NULL,'Not Applicable',NULL,'2025-03-13 12:52:12','Nethmi',0,'Online'),('OR-0003','d0276b17-f139-472d-99b4-c60af62509de',950.00,'Pending',NULL,'Not Applicable',NULL,'2025-03-14 14:34:52','Kamal',0,'POS'),('OR-0004','d0276b17-f139-472d-99b4-c60af62509de',902.50,'Pending',NULL,'Not Applicable',NULL,'2025-03-15 01:04:03','Admin',0,'POS');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchaseorderdetails`
--

DROP TABLE IF EXISTS `purchaseorderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchaseorderdetails` (
  `PurchaseOrderDetailID` char(36) NOT NULL,
  `PurchaseOrderID` char(36) NOT NULL,
  `BookID` char(36) NOT NULL,
  `Quantity` int NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`PurchaseOrderDetailID`),
  KEY `PurchaseOrderID` (`PurchaseOrderID`),
  KEY `BookID` (`BookID`),
  CONSTRAINT `purchaseorderdetails_ibfk_1` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchaseorders` (`PurchaseOrderID`),
  CONSTRAINT `purchaseorderdetails_ibfk_2` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchaseorderdetails`
--

LOCK TABLES `purchaseorderdetails` WRITE;
/*!40000 ALTER TABLE `purchaseorderdetails` DISABLE KEYS */;
INSERT INTO `purchaseorderdetails` VALUES ('84ca1aa4-10f9-41fe-bc51-ddee3db7b749','a7db952b-8c0f-46e6-836c-dca1e26c49a0','21f36f3a-f0da-4972-ab10-20ccb3d905d9',10,500.00),('bb746f9d-0e23-43c7-a10f-a231e58c2806','d505dd45-df5a-4f37-bc81-b53c16331ca9','21f36f3a-f0da-4972-ab10-20ccb3d905d9',10,500.00),('f2fc3882-a05e-4229-b93e-b33fa4004ff9','a7db952b-8c0f-46e6-836c-dca1e26c49a0','96742ea9-3acf-42ac-802b-1e7f3fae06ca',10,1250.00);
/*!40000 ALTER TABLE `purchaseorderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchaseorders`
--

DROP TABLE IF EXISTS `purchaseorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchaseorders` (
  `PurchaseOrderID` char(36) NOT NULL,
  `SupplierID` char(36) NOT NULL,
  `OrderDate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `TotalAmount` decimal(10,2) NOT NULL,
  `Status` enum('Pending','Received','Canceled') DEFAULT 'Pending',
  PRIMARY KEY (`PurchaseOrderID`),
  KEY `SupplierID` (`SupplierID`),
  CONSTRAINT `purchaseorders_ibfk_1` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchaseorders`
--

LOCK TABLES `purchaseorders` WRITE;
/*!40000 ALTER TABLE `purchaseorders` DISABLE KEYS */;
INSERT INTO `purchaseorders` VALUES ('a7db952b-8c0f-46e6-836c-dca1e26c49a0','8c0d45d4-ef6e-49e4-a7ee-63ca511c6caf','2025-03-12 14:29:40',17500.00,'Pending'),('d505dd45-df5a-4f37-bc81-b53c16331ca9','5b6c825e-5dc7-40e5-a382-37cfdcc70e7b','2025-03-12 14:24:21',5000.00,'Pending');
/*!40000 ALTER TABLE `purchaseorders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `SupplierID` char(36) NOT NULL,
  `SupplierName` varchar(255) NOT NULL,
  `ContactName` varchar(255) DEFAULT NULL,
  `ContactEmail` varchar(255) DEFAULT NULL,
  `ContactPhone` varchar(15) DEFAULT NULL,
  `IsDeleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES ('5b6c825e-5dc7-40e5-a382-37cfdcc70e7b','ABC Company','Nimal Rajapaksha','nimal@gmail.com','0765231426',0),('8c0d45d4-ef6e-49e4-a7ee-63ca511c6caf','Munchee','Dinitha','dinith@gmail.com','0771234567\n',0);
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` char(36) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('Admin','Sales Clerk') NOT NULL,
  `DateCreated` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `IsDeleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('416d8700-f1dc-4ec4-8adf-c98ced472c6c','Kamal','8c3fe47ba2c7125ac5f77b8928c4a40c2c6d24b52e708696da28f6da8c230cf2','Sales Clerk','2025-03-14 23:39:07',0),('778383a4-23ed-4d4a-b923-b896c5b14db4','admin','41e5653fc7aeb894026d6bb7b2db7f65902b454945fa8fd65a6327047b5277fb','Admin','2025-03-14 23:12:21',0);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-15 11:04:47
