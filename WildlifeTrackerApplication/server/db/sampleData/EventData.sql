-- MySQL 

-- Host: localhost    Database: root
-- ------------------------------------------------------


DROP TABLE IF EXISTS `EventData`;

CREATE TABLE `EventData` (  
  `DeviceID` varchar(32) NOT NULL,
  `timestamp` int(10) unsigned NOT NULL,
  `StatusCode` int(10) unsigned NOT NULL,
  `Latitude` double DEFAULT NULL,
  `Longitude` double DEFAULT NULL,  
  `CreationTime` int(10) unsigned DEFAULT NULL,
  `IPAddress` varchar(80) DEFAULT NULL,
  `Description` varchar(40) DEFAULT NULL,
  `IPAddress` varchar(40) DEFAULT 
  `AnimalID` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`DeviceID`,`timestamp`,`StatusCode`),
  KEY `adtkey` (`accountID`,`deviceID`,`timestamp`)
);

