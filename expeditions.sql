/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50620
Source Host           : 127.0.0.1:3306
Source Database       : expeditions

Target Server Type    : MYSQL
Target Server Version : 50620
File Encoding         : 65001

Date: 2015-03-18 19:08:57
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for article
-- ----------------------------
DROP TABLE IF EXISTS `article`;
CREATE TABLE `article` (
  `ArticleNo` int(11) NOT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ArticleNo`),
  KEY `article` (`ArticleNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of article
-- ----------------------------
INSERT INTO `article` VALUES ('30390', '2014-09-21 16:03:40');
INSERT INTO `article` VALUES ('30420', '2014-09-21 16:03:40');
INSERT INTO `article` VALUES ('30421', '2014-09-21 16:03:40');
INSERT INTO `article` VALUES ('31600', '2014-09-21 16:03:40');
INSERT INTO `article` VALUES ('31601', '2014-10-01 10:28:01');
INSERT INTO `article` VALUES ('37152', '2014-09-21 16:03:40');
INSERT INTO `article` VALUES ('37153', '2014-09-22 12:41:48');
INSERT INTO `article` VALUES ('37154', '2014-09-22 12:41:48');
INSERT INTO `article` VALUES ('37155', '2014-09-22 12:41:48');
INSERT INTO `article` VALUES ('37159', '2014-09-21 16:03:40');
INSERT INTO `article` VALUES ('38000', '2014-10-14 21:29:21');

-- ----------------------------
-- Table structure for bu
-- ----------------------------
DROP TABLE IF EXISTS `bu`;
CREATE TABLE `bu` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Date` (`Date`)
) ENGINE=InnoDB AUTO_INCREMENT=483 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bu
-- ----------------------------
INSERT INTO `bu` VALUES ('477', '2014-09-03', '2014-09-22 11:59:39');
INSERT INTO `bu` VALUES ('478', '2014-09-10', '2014-09-21 16:00:04');
INSERT INTO `bu` VALUES ('480', '2014-09-17', '2014-09-22 11:59:55');
INSERT INTO `bu` VALUES ('481', '2014-09-24', '2014-10-01 10:27:16');
INSERT INTO `bu` VALUES ('482', '2014-09-28', '2014-10-11 22:52:28');

-- ----------------------------
-- Table structure for expedirani
-- ----------------------------
DROP TABLE IF EXISTS `expedirani`;
CREATE TABLE `expedirani` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bu_ID` int(11) NOT NULL,
  `Article_ID` int(11) NOT NULL,
  `Lavoratione_ID` int(11) NOT NULL,
  `Versions_ID` int(11) NOT NULL,
  `Foundo_ID` int(11) NOT NULL,
  `Linia_ID` int(11) NOT NULL,
  `No_39` int(11) NOT NULL,
  `No_40` int(11) NOT NULL,
  `No_41` int(11) NOT NULL,
  `No_42` int(11) NOT NULL,
  `No_43` int(11) NOT NULL,
  `No_44` int(11) NOT NULL,
  `No_45` int(11) NOT NULL,
  `No_46` int(11) NOT NULL,
  `Total` int(11) DEFAULT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_bu_idx` (`Bu_ID`),
  KEY `fk_lavoratione_idx` (`Lavoratione_ID`),
  KEY `fk_versions_idx` (`Versions_ID`),
  KEY `fk_foundo_idx` (`Foundo_ID`),
  KEY `fk_linia_idx` (`Linia_ID`),
  KEY `fk_article_idx` (`Article_ID`),
  CONSTRAINT `expedirani_ibfk_1` FOREIGN KEY (`Foundo_ID`) REFERENCES `foundo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `expedirani_ibfk_2` FOREIGN KEY (`Lavoratione_ID`) REFERENCES `lavoratione` (`Lavoratoine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `expedirani_ibfk_3` FOREIGN KEY (`Versions_ID`) REFERENCES `versions` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `expedirani_ibfk_4` FOREIGN KEY (`Bu_ID`) REFERENCES `bu` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `expedirani_ibfk_5` FOREIGN KEY (`Linia_ID`) REFERENCES `linia` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `expedirani_ibfk_6` FOREIGN KEY (`Article_ID`) REFERENCES `article` (`ArticleNo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of expedirani
-- ----------------------------
INSERT INTO `expedirani` VALUES ('1', '477', '31600', '108399', '2', '2', '10', '50', '313', '407', '807', '807', '806', '407', '313', '3910', '2015-01-15 23:20:32');
INSERT INTO `expedirani` VALUES ('2', '481', '31600', '108400', '2', '2', '10', '85', '855', '10', '647', '647', '647', '326', '266', '3483', '2015-01-16 21:21:41');

-- ----------------------------
-- Table structure for foundo
-- ----------------------------
DROP TABLE IF EXISTS `foundo`;
CREATE TABLE `foundo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `F_Name` varchar(15) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `F_Name` (`F_Name`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of foundo
-- ----------------------------
INSERT INTO `foundo` VALUES ('1', 'RELAY', '2014-09-21 16:10:30');
INSERT INTO `foundo` VALUES ('2', 'HANDEL GALLUS', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('3', 'FREETIME', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('4', 'FLEXTIME IGI', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('5', 'RELAY ENVAL', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('6', 'TRAVELER ENVAL', '2014-09-22 11:53:41');

-- ----------------------------
-- Table structure for lavoratione
-- ----------------------------
DROP TABLE IF EXISTS `lavoratione`;
CREATE TABLE `lavoratione` (
  `Lavoratoine` int(11) NOT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`Lavoratoine`),
  KEY `LAVORATION` (`Lavoratoine`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of lavoratione
-- ----------------------------
INSERT INTO `lavoratione` VALUES ('108399', '2014-09-22 12:42:41');
INSERT INTO `lavoratione` VALUES ('108400', '2014-09-22 12:42:41');
INSERT INTO `lavoratione` VALUES ('108535', '2014-09-21 16:04:41');
INSERT INTO `lavoratione` VALUES ('108536', '2014-09-21 16:04:41');
INSERT INTO `lavoratione` VALUES ('108537', '2014-09-21 16:04:41');
INSERT INTO `lavoratione` VALUES ('108538', '2014-09-21 16:04:41');
INSERT INTO `lavoratione` VALUES ('108539', '2014-09-21 16:04:41');
INSERT INTO `lavoratione` VALUES ('108540', '2014-09-21 16:04:41');
INSERT INTO `lavoratione` VALUES ('108541', '2014-09-21 16:04:41');
INSERT INTO `lavoratione` VALUES ('108542', '2014-09-21 19:49:45');
INSERT INTO `lavoratione` VALUES ('108672', '2014-09-22 12:43:34');
INSERT INTO `lavoratione` VALUES ('108673', '2014-09-22 12:43:34');
INSERT INTO `lavoratione` VALUES ('108674', '2014-09-22 13:07:25');
INSERT INTO `lavoratione` VALUES ('108675', '2014-09-22 12:43:34');
INSERT INTO `lavoratione` VALUES ('108676', '2014-09-22 12:43:34');
INSERT INTO `lavoratione` VALUES ('108857', '2014-10-01 10:28:56');
INSERT INTO `lavoratione` VALUES ('108858', '2014-10-01 10:28:56');
INSERT INTO `lavoratione` VALUES ('108859', '2014-10-01 10:28:56');
INSERT INTO `lavoratione` VALUES ('108860', '2014-10-01 10:28:56');
INSERT INTO `lavoratione` VALUES ('108861', '2014-10-01 10:28:56');
INSERT INTO `lavoratione` VALUES ('108862', '2014-10-01 10:28:56');

-- ----------------------------
-- Table structure for leave
-- ----------------------------
DROP TABLE IF EXISTS `leave`;
CREATE TABLE `leave` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bu_ID` int(11) NOT NULL,
  `Article_ID` int(11) NOT NULL,
  `Lavoratione_ID` int(11) NOT NULL,
  `Versions_ID` int(11) NOT NULL,
  `Foundo_ID` int(11) NOT NULL,
  `Linia_ID` int(11) NOT NULL,
  `No_39` int(11) NOT NULL,
  `No_40` int(11) NOT NULL,
  `No_41` int(11) NOT NULL,
  `No_42` int(11) NOT NULL,
  `No_43` int(11) NOT NULL,
  `No_44` int(11) NOT NULL,
  `No_45` int(11) NOT NULL,
  `No_46` int(11) NOT NULL,
  `Total` int(11) DEFAULT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_bu_idx` (`Bu_ID`),
  KEY `fk_lavoratione_idx` (`Lavoratione_ID`),
  KEY `fk_versions_idx` (`Versions_ID`),
  KEY `fk_foundo_idx` (`Foundo_ID`),
  KEY `fk_linia_idx` (`Linia_ID`),
  KEY `fk_article_idx` (`Article_ID`),
  CONSTRAINT `leave_ibfk_1` FOREIGN KEY (`Foundo_ID`) REFERENCES `foundo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `leave_ibfk_2` FOREIGN KEY (`Lavoratione_ID`) REFERENCES `lavoratione` (`Lavoratoine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `leave_ibfk_3` FOREIGN KEY (`Versions_ID`) REFERENCES `versions` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `leave_ibfk_4` FOREIGN KEY (`Bu_ID`) REFERENCES `bu` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `leave_ibfk_5` FOREIGN KEY (`Linia_ID`) REFERENCES `linia` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `leave_ibfk_6` FOREIGN KEY (`Article_ID`) REFERENCES `article` (`ArticleNo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of leave
-- ----------------------------
INSERT INTO `leave` VALUES ('1', '477', '31600', '108399', '2', '2', '10', '18', '297', '396', '795', '794', '793', '392', '291', '3776', '2015-03-17 22:37:25');
INSERT INTO `leave` VALUES ('2', '481', '31600', '108400', '2', '2', '10', '65', '755', '0', '47', '47', '47', '26', '0', '987', '2015-03-17 20:24:40');

-- ----------------------------
-- Table structure for linia
-- ----------------------------
DROP TABLE IF EXISTS `linia`;
CREATE TABLE `linia` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Linia` varchar(15) DEFAULT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of linia
-- ----------------------------
INSERT INTO `linia` VALUES ('1', 'Няма', '2014-09-21 15:54:22');
INSERT INTO `linia` VALUES ('2', 'Администрация', '2014-09-21 15:54:24');
INSERT INTO `linia` VALUES ('3', 'Пом Персонал', '2014-09-21 15:54:26');
INSERT INTO `linia` VALUES ('4', 'Няма', '2014-09-21 15:54:02');
INSERT INTO `linia` VALUES ('5', 'Кроячи', '2014-09-21 15:54:08');
INSERT INTO `linia` VALUES ('6', 'Трашачи', '2014-09-21 15:54:10');
INSERT INTO `linia` VALUES ('7', '7 Шивалня', '2014-09-21 15:54:12');
INSERT INTO `linia` VALUES ('8', '8 Шивалня', '2014-09-21 15:54:14');
INSERT INTO `linia` VALUES ('9', '9 Шивалня', '2014-09-21 15:54:15');
INSERT INTO `linia` VALUES ('10', '10 Шивалня', '2014-09-21 15:54:17');
INSERT INTO `linia` VALUES ('11', '11 Шивалня', '2014-09-21 15:54:20');

-- ----------------------------
-- Table structure for manufactured
-- ----------------------------
DROP TABLE IF EXISTS `manufactured`;
CREATE TABLE `manufactured` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Bu_ID` int(11) NOT NULL,
  `Article_ID` int(11) NOT NULL,
  `Lavoratione_ID` int(11) NOT NULL,
  `Foundo_ID` int(11) NOT NULL,
  `Linia_ID` int(11) DEFAULT NULL,
  `No_39` int(11) NOT NULL,
  `No_40` int(11) NOT NULL,
  `No_41` int(11) NOT NULL,
  `No_42` int(11) NOT NULL,
  `No_43` int(11) NOT NULL,
  `No_44` int(11) NOT NULL,
  `No_45` int(11) NOT NULL,
  `No_46` int(11) NOT NULL,
  `Total` int(11) NOT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_Mani_Bu` (`Bu_ID`),
  KEY `fk_Mani_Art` (`Article_ID`),
  KEY `fk_Mani_Lav` (`Lavoratione_ID`),
  KEY `fk_Mani_Found` (`Foundo_ID`),
  KEY `fk_Mani_Linia` (`Linia_ID`),
  CONSTRAINT `fk_Mani_Art` FOREIGN KEY (`Article_ID`) REFERENCES `article` (`ArticleNo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Mani_Bu` FOREIGN KEY (`Bu_ID`) REFERENCES `bu` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Mani_Found` FOREIGN KEY (`Foundo_ID`) REFERENCES `foundo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Mani_Lav` FOREIGN KEY (`Lavoratione_ID`) REFERENCES `lavoratione` (`Lavoratoine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Mani_Linia` FOREIGN KEY (`Linia_ID`) REFERENCES `linia` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=135 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of manufactured
-- ----------------------------
INSERT INTO `manufactured` VALUES ('1', '2014-09-20', '477', '31600', '108399', '2', '10', '0', '0', '0', '70', '0', '0', '0', '0', '70', '2014-09-22 14:57:05');
INSERT INTO `manufactured` VALUES ('2', '2014-09-22', '478', '37159', '108535', '4', '9', '90', '10', '0', '0', '0', '0', '0', '0', '100', '2014-09-23 11:43:07');
INSERT INTO `manufactured` VALUES ('3', '2014-09-22', '477', '31600', '108399', '2', '10', '0', '0', '0', '20', '90', '0', '0', '30', '140', '2014-09-23 11:48:20');
INSERT INTO `manufactured` VALUES ('4', '2014-09-22', '477', '31600', '108399', '2', '11', '0', '90', '50', '0', '0', '0', '0', '0', '140', '2014-09-23 11:48:23');
INSERT INTO `manufactured` VALUES ('5', '2014-09-23', '478', '37159', '108535', '4', '9', '73', '100', '90', '0', '0', '0', '0', '0', '263', '2014-09-24 13:02:31');
INSERT INTO `manufactured` VALUES ('6', '2014-09-23', '477', '31600', '108399', '2', '10', '0', '0', '0', '90', '20', '0', '0', '60', '170', '2014-09-24 13:04:09');
INSERT INTO `manufactured` VALUES ('7', '2014-09-23', '477', '31600', '108399', '2', '11', '0', '0', '40', '0', '0', '90', '0', '0', '130', '2014-09-24 13:05:06');
INSERT INTO `manufactured` VALUES ('9', '2014-09-24', '478', '30420', '108538', '1', '7', '0', '55', '30', '0', '0', '0', '0', '0', '85', '2014-09-25 12:44:25');
INSERT INTO `manufactured` VALUES ('10', '2014-09-23', '478', '37152', '108537', '4', '8', '100', '92', '60', '0', '0', '0', '0', '0', '252', '2014-09-25 12:47:21');
INSERT INTO `manufactured` VALUES ('11', '2014-09-24', '478', '37152', '108537', '4', '8', '0', '100', '110', '40', '0', '0', '0', '0', '250', '2014-09-25 12:48:11');
INSERT INTO `manufactured` VALUES ('12', '2014-09-24', '478', '37159', '108535', '4', '9', '0', '160', '100', '0', '0', '0', '0', '0', '260', '2014-09-25 12:50:47');
INSERT INTO `manufactured` VALUES ('13', '2014-09-24', '477', '31600', '108399', '2', '10', '0', '0', '0', '20', '70', '0', '0', '0', '180', '2014-09-25 12:53:09');
INSERT INTO `manufactured` VALUES ('16', '2014-09-24', '477', '31600', '108399', '2', '11', '0', '90', '60', '0', '0', '0', '0', '0', '150', '2014-09-25 12:54:40');
INSERT INTO `manufactured` VALUES ('17', '2014-09-25', '478', '30420', '108538', '1', '7', '0', '0', '25', '164', '40', '0', '0', '0', '229', '2014-09-26 13:18:36');
INSERT INTO `manufactured` VALUES ('18', '2014-09-25', '478', '37152', '108537', '4', '8', '0', '0', '30', '130', '90', '0', '0', '0', '250', '2014-09-26 13:19:38');
INSERT INTO `manufactured` VALUES ('19', '2014-09-25', '478', '37159', '108535', '4', '9', '0', '63', '130', '90', '0', '0', '0', '0', '283', '2014-09-25 13:21:00');
INSERT INTO `manufactured` VALUES ('20', '2014-09-25', '477', '31600', '108399', '2', '10', '0', '0', '0', '70', '90', '0', '0', '20', '180', '2014-09-26 13:21:28');
INSERT INTO `manufactured` VALUES ('23', '2014-09-25', '477', '31600', '108399', '2', '11', '0', '60', '30', '0', '0', '90', '0', '0', '180', '2014-09-26 13:22:25');
INSERT INTO `manufactured` VALUES ('27', '2014-09-26', '478', '30420', '108538', '1', '7', '0', '0', '0', '0', '124', '60', '55', '0', '239', '2014-09-27 15:31:14');
INSERT INTO `manufactured` VALUES ('29', '2014-09-26', '478', '30421', '108539', '1', '7', '14', '31', '0', '0', '0', '0', '0', '0', '45', '2014-09-27 15:33:02');
INSERT INTO `manufactured` VALUES ('30', '2014-09-26', '478', '37152', '108537', '4', '8', '0', '0', '121', '90', '40', '0', '0', '0', '251', '2014-09-27 15:34:45');
INSERT INTO `manufactured` VALUES ('31', '2014-09-26', '478', '37159', '108535', '4', '9', '0', '0', '120', '90', '40', '0', '0', '0', '250', '2014-09-27 15:35:07');
INSERT INTO `manufactured` VALUES ('33', '2014-09-26', '477', '31600', '108399', '2', '10', '0', '0', '0', '100', '10', '0', '0', '70', '180', '2014-09-27 15:36:46');
INSERT INTO `manufactured` VALUES ('34', '2014-09-26', '477', '31600', '108399', '2', '11', '0', '30', '90', '0', '0', '60', '0', '0', '180', '2014-09-27 15:37:47');
INSERT INTO `manufactured` VALUES ('35', '2014-09-27', '478', '30421', '108539', '1', '7', '0', '0', '58', '81', '75', '50', '0', '0', '264', '2014-09-30 10:46:03');
INSERT INTO `manufactured` VALUES ('36', '2014-09-27', '478', '37152', '108537', '4', '8', '0', '0', '0', '90', '130', '30', '0', '0', '250', '2014-09-30 10:46:45');
INSERT INTO `manufactured` VALUES ('37', '2014-09-27', '478', '37159', '108535', '4', '9', '0', '0', '30', '90', '90', '0', '0', '210', '210', '2014-09-30 10:48:23');
INSERT INTO `manufactured` VALUES ('38', '2014-09-27', '477', '31600', '108399', '2', '10', '0', '0', '0', '50', '90', '0', '0', '43', '183', '2014-09-30 10:50:57');
INSERT INTO `manufactured` VALUES ('40', '2014-09-27', '477', '31600', '108399', '2', '11', '0', '43', '90', '0', '0', '30', '0', '0', '187', '2014-09-30 10:51:35');
INSERT INTO `manufactured` VALUES ('41', '2014-09-29', '478', '30421', '108539', '1', '7', '0', '0', '0', '0', '0', '0', '30', '10', '40', '2014-09-30 10:53:39');
INSERT INTO `manufactured` VALUES ('42', '2014-09-29', '478', '30421', '108540', '1', '7', '10', '26', '48', '65', '61', '0', '0', '0', '210', '2014-09-30 10:54:54');
INSERT INTO `manufactured` VALUES ('43', '2014-09-29', '478', '37152', '108537', '4', '8', '0', '0', '0', '21', '79', '180', '0', '0', '280', '2014-09-30 10:56:17');
INSERT INTO `manufactured` VALUES ('45', '2014-09-29', '478', '37159', '108535', '4', '9', '0', '0', '114', '90', '90', '0', '0', '0', '294', '2014-09-30 10:57:33');
INSERT INTO `manufactured` VALUES ('46', '2014-09-29', '478', '31600', '108399', '2', '10', '0', '0', '0', '100', '100', '0', '0', '0', '200', '2014-09-30 10:58:36');
INSERT INTO `manufactured` VALUES ('47', '2014-09-29', '478', '31600', '108399', '2', '11', '0', '0', '47', '0', '0', '90', '50', '0', '187', '2014-09-30 10:59:39');
INSERT INTO `manufactured` VALUES ('51', '2014-09-30', '478', '30421', '108540', '1', '7', '0', '0', '0', '0', '0', '40', '23', '6', '69', '2014-10-01 10:21:49');
INSERT INTO `manufactured` VALUES ('53', '2014-09-30', '478', '37152', '108537', '4', '8', '0', '0', '0', '0', '0', '44', '45', '66', '220', '2014-10-01 10:38:27');
INSERT INTO `manufactured` VALUES ('54', '2014-09-30', '478', '37159', '108535', '4', '9', '0', '0', '0', '90', '90', '0', '0', '0', '180', '2014-10-01 10:38:57');
INSERT INTO `manufactured` VALUES ('55', '2014-09-30', '477', '31600', '108399', '2', '10', '0', '0', '0', '90', '100', '0', '0', '0', '190', '2014-10-01 10:40:32');
INSERT INTO `manufactured` VALUES ('59', '2014-09-30', '477', '31600', '108399', '2', '11', '0', '0', '0', '0', '0', '100', '40', '0', '140', '2014-10-01 10:41:07');
INSERT INTO `manufactured` VALUES ('60', '2014-09-30', '481', '30421', '108860', '1', '7', '22', '55', '0', '0', '0', '0', '0', '0', '77', '2014-10-01 10:50:21');
INSERT INTO `manufactured` VALUES ('62', '2014-10-01', '477', '30420', '108538', '1', '7', '0', '0', '0', '0', '0', '50', '0', '0', '50', '2014-10-02 12:33:01');
INSERT INTO `manufactured` VALUES ('63', '2014-10-01', '481', '30421', '108860', '1', '7', '0', '0', '90', '90', '0', '0', '0', '0', '180', '2014-10-02 12:36:15');
INSERT INTO `manufactured` VALUES ('65', '2014-10-01', '478', '37159', '108535', '4', '9', '0', '0', '0', '90', '90', '90', '0', '0', '270', '2014-10-01 12:36:29');
INSERT INTO `manufactured` VALUES ('66', '2014-10-01', '477', '31600', '108399', '2', '10', '0', '0', '0', '100', '100', '0', '0', '0', '200', '2014-10-02 12:39:01');
INSERT INTO `manufactured` VALUES ('67', '2014-10-01', '477', '31600', '108399', '2', '11', '0', '0', '0', '0', '0', '100', '60', '0', '160', '2014-10-02 12:40:06');
INSERT INTO `manufactured` VALUES ('68', '2014-10-02', '477', '30420', '108538', '1', '7', '0', '0', '0', '0', '0', '0', '0', '55', '55', '2014-10-07 09:20:52');
INSERT INTO `manufactured` VALUES ('69', '2014-10-02', '481', '30421', '108860', '1', '7', '0', '0', '37', '70', '90', '0', '0', '0', '197', '2014-10-07 09:23:16');
INSERT INTO `manufactured` VALUES ('70', '2014-10-02', '480', '37155', '108672', '4', '8', '75', '100', '0', '0', '0', '0', '0', '0', '175', '2014-10-07 09:26:49');
INSERT INTO `manufactured` VALUES ('71', '2014-10-02', '478', '37159', '108535', '4', '9', '0', '0', '0', '90', '90', '90', '0', '0', '270', '2014-10-07 09:27:09');
INSERT INTO `manufactured` VALUES ('73', '2014-10-02', '477', '31600', '108399', '2', '10', '0', '0', '0', '60', '137', '0', '0', '0', '197', '2014-10-07 09:29:05');
INSERT INTO `manufactured` VALUES ('74', '2014-10-02', '477', '31600', '108399', '2', '11', '0', '0', '0', '0', '0', '70', '100', '0', '170', '2014-10-07 09:30:11');
INSERT INTO `manufactured` VALUES ('77', '2014-10-06', '481', '30421', '108860', '1', '7', '0', '0', '0', '41', '94', '98', '0', '0', '233', '2014-10-07 09:57:13');
INSERT INTO `manufactured` VALUES ('78', '2014-10-06', '480', '37155', '108672', '4', '8', '0', '60', '190', '0', '0', '0', '0', '0', '250', '2014-10-07 09:58:01');
INSERT INTO `manufactured` VALUES ('79', '2014-10-06', '478', '37159', '108535', '4', '9', '0', '0', '0', '74', '90', '90', '0', '0', '254', '2014-10-07 09:59:45');
INSERT INTO `manufactured` VALUES ('80', '2014-10-06', '477', '31600', '108399', '2', '10', '0', '0', '0', '37', '0', '0', '0', '0', '37', '2014-10-07 10:01:01');
INSERT INTO `manufactured` VALUES ('81', '2014-10-06', '478', '31600', '108400', '2', '10', '0', '0', '0', '90', '60', '0', '0', '0', '150', '2014-10-07 10:03:43');
INSERT INTO `manufactured` VALUES ('131', '2015-03-16', '477', '31600', '108399', '2', '10', '8', '3', '7', '7', '7', '6', '7', '13', '58', '2015-03-17 22:15:36');
INSERT INTO `manufactured` VALUES ('133', '2015-03-16', '477', '31600', '108399', '2', '10', '1', '2', '3', '4', '5', '6', '7', '8', '36', '2015-03-17 22:22:30');
INSERT INTO `manufactured` VALUES ('134', '2015-03-16', '477', '31600', '108399', '2', '10', '1', '1', '1', '1', '1', '1', '1', '1', '8', '2015-03-17 22:32:30');

-- ----------------------------
-- Table structure for materialprice
-- ----------------------------
DROP TABLE IF EXISTS `materialprice`;
CREATE TABLE `materialprice` (
  `Article` int(11) NOT NULL AUTO_INCREMENT,
  `MaterialsPrice` double(4,2) unsigned zerofill NOT NULL,
  PRIMARY KEY (`Article`),
  CONSTRAINT `fk_Arti` FOREIGN KEY (`Article`) REFERENCES `article` (`ArticleNo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of materialprice
-- ----------------------------

-- ----------------------------
-- Table structure for tableinfo
-- ----------------------------
DROP TABLE IF EXISTS `tableinfo`;
CREATE TABLE `tableinfo` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` int(10) NOT NULL,
  `age` int(10) NOT NULL,
  `sum` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tableinfo
-- ----------------------------
INSERT INTO `tableinfo` VALUES ('1', '1', '22', '0');
INSERT INTO `tableinfo` VALUES ('2', '1', '22', '0');
INSERT INTO `tableinfo` VALUES ('3', '1', '22', '0');
INSERT INTO `tableinfo` VALUES ('4', '1', '22', '0');

-- ----------------------------
-- Table structure for versions
-- ----------------------------
DROP TABLE IF EXISTS `versions`;
CREATE TABLE `versions` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Version` varchar(10) NOT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `VERSION` (`Version`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of versions
-- ----------------------------
INSERT INTO `versions` VALUES ('1', '7638/013', '2014-09-21 19:29:58');
INSERT INTO `versions` VALUES ('2', '1000/011', '2014-09-21 19:30:55');
INSERT INTO `versions` VALUES ('3', '2820/041', '2014-09-21 19:30:55');
INSERT INTO `versions` VALUES ('4', '7636/018', '2014-09-21 19:30:55');
INSERT INTO `versions` VALUES ('5', '3019/018', '2014-09-22 12:44:46');
INSERT INTO `versions` VALUES ('6', '3054/013', '2014-09-22 12:44:46');
INSERT INTO `versions` VALUES ('7', '3090/018', '2014-09-22 12:44:46');
INSERT INTO `versions` VALUES ('8', '7601/009', '2014-10-01 10:53:24');

-- ----------------------------
-- Table structure for worck
-- ----------------------------
DROP TABLE IF EXISTS `worck`;
CREATE TABLE `worck` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bu_ID` int(11) NOT NULL,
  `Article_ID` int(11) NOT NULL,
  `Lavoratione_ID` int(11) NOT NULL,
  `Versions_ID` int(11) NOT NULL,
  `Foundo_ID` int(11) NOT NULL,
  `Linia_ID` int(11) NOT NULL,
  `No_39` int(11) NOT NULL,
  `No_40` int(11) NOT NULL,
  `No_41` int(11) NOT NULL,
  `No_42` int(11) NOT NULL,
  `No_43` int(11) NOT NULL,
  `No_44` int(11) NOT NULL,
  `No_45` int(11) NOT NULL,
  `No_46` int(11) NOT NULL,
  `Total` int(11) DEFAULT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_bu_idx` (`Bu_ID`),
  KEY `fk_lavoratione_idx` (`Lavoratione_ID`),
  KEY `fk_versions_idx` (`Versions_ID`),
  KEY `fk_foundo_idx` (`Foundo_ID`),
  KEY `fk_linia_idx` (`Linia_ID`),
  KEY `fk_article_idx` (`Article_ID`),
  CONSTRAINT `fk_Foundo` FOREIGN KEY (`Foundo_ID`) REFERENCES `foundo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Lavoration` FOREIGN KEY (`Lavoratione_ID`) REFERENCES `lavoratione` (`Lavoratoine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Versions` FOREIGN KEY (`Versions_ID`) REFERENCES `versions` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_bu` FOREIGN KEY (`Bu_ID`) REFERENCES `bu` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_linia` FOREIGN KEY (`Linia_ID`) REFERENCES `linia` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `worck_ibfk_1` FOREIGN KEY (`Article_ID`) REFERENCES `article` (`ArticleNo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of worck
-- ----------------------------
INSERT INTO `worck` VALUES ('1', '477', '31600', '108399', '2', '2', '10', '50', '313', '407', '807', '807', '806', '407', '313', '3910', '2015-01-15 23:20:32');
INSERT INTO `worck` VALUES ('4', '478', '31601', '108541', '1', '1', '10', '50', '50', '50', '50', '50', '50', '50', '50', '400', '2015-03-04 21:29:54');
