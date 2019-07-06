-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 07, 2018 at 09:15 PM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `account`
--

-- --------------------------------------------------------

--
-- Table structure for table `acountdetails`
--

CREATE TABLE IF NOT EXISTS `acountdetails` (
  `First_Name` varchar(20) NOT NULL,
  `Last_Name` varchar(20) NOT NULL,
  `Email_Address` varchar(20) NOT NULL,
  `Telephone_Number` int(10) NOT NULL,
  `User_Name` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Conform_Password` varchar(20) NOT NULL,
  `Date_Of_Birth` date NOT NULL,
  `Address` varchar(60) NOT NULL,
  `City` varchar(20) NOT NULL,
  `State` varchar(20) NOT NULL,
  `Zip_Code` int(10) NOT NULL,
  PRIMARY KEY (`User_Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `acountdetails`
--

INSERT INTO `acountdetails` (`First_Name`, `Last_Name`, `Email_Address`, `Telephone_Number`, `User_Name`, `Password`, `Conform_Password`, `Date_Of_Birth`, `Address`, `City`, `State`, `Zip_Code`) VALUES
('kamal', 'perara', 'dfg', 2444, 'kamal', 'kamal', 'kamal', '0000-00-00', 'karawanala', 'karawanala', 'sabaragamuwa', 12),
('sachin', 'sad', 'sw', 1234, 'sach', 'sad', 'sad', '0000-00-00', 'lewangam', 'ruwanwa', 'sri', 123),
('sacj', 'das', 'as', 1234, 'sachin', 'sad', 'sad', '0000-00-00', 'kay', 'dca', 'dsc', 0),
('bharatha', 'sachintha', 'sd', 1234, 'sachintha', 'bharatha', 'bharatha', '0000-00-00', 'ry', 'fv', 'fgvs', 34);

-- --------------------------------------------------------

--
-- Table structure for table `offline`
--

CREATE TABLE IF NOT EXISTS `offline` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Date` int(8) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Telephone` int(10) NOT NULL,
  `ItemCode` int(10) NOT NULL,
  `Quantity` int(100) NOT NULL,
  `Price` int(225) NOT NULL,
  `Netprice` int(225) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `offline`
--

INSERT INTO `offline` (`ID`, `Date`, `Name`, `Address`, `Telephone`, `ItemCode`, `Quantity`, `Price`, `Netprice`) VALUES
(2, 4, 'saman', 'lewangama', 123, 4, 4, 40, 160);

-- --------------------------------------------------------

--
-- Table structure for table `online`
--

CREATE TABLE IF NOT EXISTS `online` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Date` int(8) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Telephone` int(10) NOT NULL,
  `ItemCode` int(100) NOT NULL,
  `Quantity` int(225) NOT NULL,
  `price` int(225) NOT NULL,
  `Netprice` int(225) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `online`
--

INSERT INTO `online` (`ID`, `Date`, `Name`, `Address`, `Telephone`, `ItemCode`, `Quantity`, `price`, `Netprice`) VALUES
(13, 3, 'nimal', 'warakapola', 1234, 4, 5, 3, 50),
(14, 3, 'saman', 'kegalla', 1234, 5, 50, 10, 500),
(15, 3, 'nimal', 'das', 123, 2, 2, 100, 200),
(16, 2, 'kamal', 'wahara', 123, 3, 5, 50, 250);

-- --------------------------------------------------------

--
-- Table structure for table `other`
--

CREATE TABLE IF NOT EXISTS `other` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Date` int(8) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Telephone` int(10) NOT NULL,
  `ItemCode` int(100) NOT NULL,
  `Quantity` int(100) NOT NULL,
  `Price` int(100) NOT NULL,
  `Netvalue` int(100) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `other`
--

INSERT INTO `other` (`ID`, `Date`, `Name`, `Address`, `Telephone`, `ItemCode`, `Quantity`, `Price`, `Netvalue`) VALUES
(4, 3, 'nimal', 'wahara', 345, 5, 5, 50, 250);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
