/*
Navicat MySQL Data Transfer

Source Server         : NEV
Source Server Version : 50616
Source Host           : localhost:3306
Source Database       : expeditions

Target Server Type    : MYSQL
Target Server Version : 50616
File Encoding         : 65001

Date: 2015-04-03 15:50:52
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `article`
-- ----------------------------
DROP TABLE IF EXISTS `article`;
CREATE TABLE `article` (
  `ArticleNo` int(11) NOT NULL,
  `MaterialPrice` decimal(4,2) DEFAULT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ArticleNo`),
  KEY `article` (`ArticleNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of article
-- ----------------------------
INSERT INTO `article` VALUES ('40770', '6.30', '2015-04-03 14:35:49');
INSERT INTO `article` VALUES ('40780', '6.76', '2015-04-03 14:37:22');
INSERT INTO `article` VALUES ('40783', '6.74', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('40790', '5.68', '2015-04-03 14:33:51');
INSERT INTO `article` VALUES ('40830', '7.39', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('40834', '5.58', '2015-04-03 14:31:43');
INSERT INTO `article` VALUES ('40970', '7.81', '2015-03-31 13:10:39');
INSERT INTO `article` VALUES ('40971', '5.91', '2015-03-31 13:03:53');
INSERT INTO `article` VALUES ('41060', '7.31', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('41578', '8.05', '2015-04-03 13:19:00');
INSERT INTO `article` VALUES ('41585', '9.74', '2015-04-03 13:19:00');
INSERT INTO `article` VALUES ('41588', '9.71', '2015-04-03 13:19:00');
INSERT INTO `article` VALUES ('41598', '7.62', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47230', '8.02', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47231', '8.67', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47235', '6.05', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47236', '6.25', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47380', '5.77', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47381', '5.79', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47382', '5.74', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47660', '8.43', '2015-04-03 12:49:54');
INSERT INTO `article` VALUES ('47662', '7.90', '2015-04-03 13:19:00');

-- ----------------------------
-- Table structure for `bu`
-- ----------------------------
DROP TABLE IF EXISTS `bu`;
CREATE TABLE `bu` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Date` (`Date`)
) ENGINE=InnoDB AUTO_INCREMENT=514 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bu
-- ----------------------------
INSERT INTO `bu` VALUES ('496', '2015-01-07', '2015-03-20 09:05:44');
INSERT INTO `bu` VALUES ('499', '2015-01-21', '2015-03-20 09:07:35');
INSERT INTO `bu` VALUES ('500', '2015-01-28', '2015-03-20 09:08:46');
INSERT INTO `bu` VALUES ('501', '2015-01-04', '2015-03-20 09:09:18');
INSERT INTO `bu` VALUES ('502', '2015-02-11', '2015-03-20 09:10:59');
INSERT INTO `bu` VALUES ('504', '2015-02-18', '2015-03-20 09:11:26');
INSERT INTO `bu` VALUES ('505', '2015-02-25', '2015-03-20 09:11:46');
INSERT INTO `bu` VALUES ('506', '2015-02-27', '2015-03-20 09:12:09');
INSERT INTO `bu` VALUES ('507', '2015-03-04', '2015-03-26 12:46:03');
INSERT INTO `bu` VALUES ('510', '2015-03-11', '2015-03-24 12:15:53');
INSERT INTO `bu` VALUES ('511', '2015-03-18', '2015-04-03 12:54:03');
INSERT INTO `bu` VALUES ('513', '2015-03-25', '2015-04-03 12:52:33');

-- ----------------------------
-- Table structure for `expedirani`
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of expedirani
-- ----------------------------

-- ----------------------------
-- Table structure for `foundo`
-- ----------------------------
DROP TABLE IF EXISTS `foundo`;
CREATE TABLE `foundo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `F_Name` varchar(15) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `F_Name` (`F_Name`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of foundo
-- ----------------------------
INSERT INTO `foundo` VALUES ('1', 'RELAY', '2014-09-21 16:10:30');
INSERT INTO `foundo` VALUES ('2', 'HANDEL GALLUS', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('3', 'FREETIME', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('4', 'FLEXTIME IGI', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('5', 'RELAY ENVAL', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('6', 'TRAVELER ENVAL', '2014-09-22 11:53:41');
INSERT INTO `foundo` VALUES ('7', 'TRAV. TI 42', '2015-03-20 10:12:40');
INSERT INTO `foundo` VALUES ('8', 'PATH 42', '2015-03-26 13:07:41');
INSERT INTO `foundo` VALUES ('9', 'PATH 42 / TEX', '2015-03-26 13:08:04');
INSERT INTO `foundo` VALUES ('10', 'TOURAN GALLUS', '2015-03-26 13:08:24');
INSERT INTO `foundo` VALUES ('11', 'FREELIFE', '2015-03-31 13:15:41');
INSERT INTO `foundo` VALUES ('12', 'STROLL IGI', '2015-04-03 12:51:39');
INSERT INTO `foundo` VALUES ('13', 'FREELIFE IGI', '2015-04-03 15:26:03');

-- ----------------------------
-- Table structure for `lavoratione`
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
INSERT INTO `lavoratione` VALUES ('113113', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113114', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113115', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113116', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113117', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113118', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113502', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113503', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113648', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113649', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113650', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113651', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113739', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113740', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113741', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113742', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113743', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113744', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113745', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113841', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113842', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('113843', '2015-03-20 09:40:52');
INSERT INTO `lavoratione` VALUES ('113844', '2015-03-20 09:41:00');
INSERT INTO `lavoratione` VALUES ('113845', '2015-03-20 09:41:09');
INSERT INTO `lavoratione` VALUES ('113936', '2015-03-20 09:42:36');
INSERT INTO `lavoratione` VALUES ('113937', '2015-03-20 09:42:44');
INSERT INTO `lavoratione` VALUES ('114048', '2015-03-20 09:43:32');
INSERT INTO `lavoratione` VALUES ('114049', '2015-03-20 09:54:24');
INSERT INTO `lavoratione` VALUES ('114050', '2015-03-20 10:07:51');
INSERT INTO `lavoratione` VALUES ('114051', '2015-03-20 10:08:01');
INSERT INTO `lavoratione` VALUES ('114052', '2015-03-20 10:08:09');
INSERT INTO `lavoratione` VALUES ('114053', '2015-03-20 10:08:17');
INSERT INTO `lavoratione` VALUES ('114054', '2015-03-20 10:08:28');
INSERT INTO `lavoratione` VALUES ('114055', '2015-03-20 10:08:59');
INSERT INTO `lavoratione` VALUES ('114056', '2015-03-20 10:09:07');
INSERT INTO `lavoratione` VALUES ('114057', '2015-03-20 10:09:15');
INSERT INTO `lavoratione` VALUES ('114058', '2015-03-20 10:09:23');
INSERT INTO `lavoratione` VALUES ('114059', '2015-03-20 10:09:33');
INSERT INTO `lavoratione` VALUES ('114060', '2015-03-20 10:09:42');
INSERT INTO `lavoratione` VALUES ('114230', '2015-03-26 13:12:03');
INSERT INTO `lavoratione` VALUES ('114231', '2015-03-26 13:12:03');
INSERT INTO `lavoratione` VALUES ('114232', '2015-03-26 13:12:03');
INSERT INTO `lavoratione` VALUES ('114233', '2015-03-26 13:12:03');
INSERT INTO `lavoratione` VALUES ('114234', '2015-03-26 13:12:03');
INSERT INTO `lavoratione` VALUES ('114235', '2015-03-26 13:12:03');
INSERT INTO `lavoratione` VALUES ('114236', '2015-03-26 13:12:03');
INSERT INTO `lavoratione` VALUES ('114237', '2015-03-26 13:12:23');
INSERT INTO `lavoratione` VALUES ('114238', '2015-03-26 13:12:26');
INSERT INTO `lavoratione` VALUES ('114239', '2015-03-26 13:12:29');
INSERT INTO `lavoratione` VALUES ('114240', '2015-03-26 13:12:31');
INSERT INTO `lavoratione` VALUES ('114378', '2015-03-24 12:15:13');
INSERT INTO `lavoratione` VALUES ('114379', '2015-03-26 13:27:25');
INSERT INTO `lavoratione` VALUES ('114380', '2015-03-26 13:27:29');
INSERT INTO `lavoratione` VALUES ('114381', '2015-03-26 13:27:32');
INSERT INTO `lavoratione` VALUES ('114382', '2015-03-26 13:27:35');
INSERT INTO `lavoratione` VALUES ('114569', '2015-04-03 13:16:30');
INSERT INTO `lavoratione` VALUES ('114570', '2015-03-31 13:04:07');
INSERT INTO `lavoratione` VALUES ('114571', '2015-04-01 14:20:23');
INSERT INTO `lavoratione` VALUES ('114572', '2015-03-31 13:10:57');
INSERT INTO `lavoratione` VALUES ('114573', '2015-03-31 13:13:12');
INSERT INTO `lavoratione` VALUES ('114574', '2015-04-03 13:16:58');
INSERT INTO `lavoratione` VALUES ('114575', '2015-04-03 13:17:15');
INSERT INTO `lavoratione` VALUES ('114576', '2015-04-01 14:48:48');
INSERT INTO `lavoratione` VALUES ('114577', '2015-04-03 13:17:44');
INSERT INTO `lavoratione` VALUES ('114578', '2015-04-03 14:38:54');
INSERT INTO `lavoratione` VALUES ('114579', '2015-04-03 13:18:09');
INSERT INTO `lavoratione` VALUES ('114768', '2015-04-03 12:50:16');
INSERT INTO `lavoratione` VALUES ('114769', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114770', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114771', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114772', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114773', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114774', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114775', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114776', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114777', '2015-04-03 13:19:00');
INSERT INTO `lavoratione` VALUES ('114778', '2015-04-03 13:19:00');

-- ----------------------------
-- Table structure for `leave`
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of leave
-- ----------------------------
INSERT INTO `leave` VALUES ('1', '507', '47231', '114230', '9', '4', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:05:02');
INSERT INTO `leave` VALUES ('2', '511', '40971', '114570', '15', '7', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:03:58');
INSERT INTO `leave` VALUES ('3', '507', '47235', '114232', '14', '4', '8', '0', '0', '0', '0', '0', '60', '104', '0', '164', '2015-04-03 13:02:36');
INSERT INTO `leave` VALUES ('4', '511', '40970', '114572', '9', '7', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:00:54');
INSERT INTO `leave` VALUES ('5', '511', '40970', '114573', '9', '7', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:00:48');
INSERT INTO `leave` VALUES ('6', '510', '41060', '114379', '13', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:00:37');
INSERT INTO `leave` VALUES ('7', '510', '41060', '114380', '12', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 12:59:09');
INSERT INTO `leave` VALUES ('8', '510', '40783', '114378', '2', '1', '11', '0', '0', '0', '527', '637', '0', '40', '0', '1204', '2015-04-03 12:57:43');
INSERT INTO `leave` VALUES ('9', '511', '40971', '114571', '11', '7', '7', '0', '0', '0', '32', '10', '32', '0', '7', '81', '2015-04-03 12:56:29');
INSERT INTO `leave` VALUES ('10', '511', '40970', '114576', '2', '1', '10', '0', '0', '50', '0', '97', '98', '52', '20', '317', '2015-04-03 12:55:04');
INSERT INTO `leave` VALUES ('11', '513', '47660', '114768', '10', '12', '7', '0', '0', '61', '113', '109', '68', '50', '19', '420', '2015-04-03 13:06:00');

-- ----------------------------
-- Table structure for `linia`
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
-- Table structure for `manufactured`
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
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of manufactured
-- ----------------------------
INSERT INTO `manufactured` VALUES ('1', '2015-03-25', '507', '47231', '114230', '4', '9', '0', '0', '74', '98', '30', '0', '0', '0', '268', '2015-04-02 14:09:30');
INSERT INTO `manufactured` VALUES ('2', '2015-03-26', '507', '47231', '114230', '4', '9', '0', '0', '0', '0', '56', '54', '25', '13', '148', '2015-03-27 10:39:51');
INSERT INTO `manufactured` VALUES ('3', '2015-03-27', '511', '40971', '114570', '7', '7', '15', '42', '66', '0', '0', '0', '0', '0', '123', '2015-03-31 13:05:36');
INSERT INTO `manufactured` VALUES ('4', '2015-03-30', '511', '40971', '114570', '7', '7', '0', '0', '0', '87', '78', '52', '0', '0', '217', '2015-03-31 13:06:03');
INSERT INTO `manufactured` VALUES ('5', '2015-03-27', '507', '47235', '114232', '4', '8', '104', '90', '70', '0', '0', '0', '0', '0', '264', '2015-03-31 13:08:39');
INSERT INTO `manufactured` VALUES ('6', '2015-03-30', '507', '47235', '114232', '4', '8', '0', '44', '95', '100', '45', '0', '0', '0', '284', '2015-03-31 13:09:22');
INSERT INTO `manufactured` VALUES ('7', '2015-03-28', '511', '40970', '114572', '7', '9', '11', '24', '40', '53', '0', '0', '0', '0', '128', '2015-03-31 13:12:10');
INSERT INTO `manufactured` VALUES ('8', '2015-03-30', '511', '40970', '114572', '7', '9', '0', '0', '0', '0', '43', '27', '12', '6', '88', '2015-03-31 13:12:37');
INSERT INTO `manufactured` VALUES ('9', '2015-03-30', '511', '40970', '114573', '7', '9', '23', '52', '88', '0', '0', '0', '0', '0', '163', '2015-03-31 13:14:11');
INSERT INTO `manufactured` VALUES ('10', '2015-03-27', '510', '41060', '114379', '11', '10', '0', '31', '57', '30', '0', '0', '0', '0', '118', '2015-03-31 13:19:09');
INSERT INTO `manufactured` VALUES ('11', '2015-03-28', '510', '41060', '114379', '11', '10', '0', '0', '0', '58', '93', '62', '20', '0', '233', '2015-03-31 13:19:36');
INSERT INTO `manufactured` VALUES ('12', '2015-03-30', '510', '41060', '114379', '11', '10', '0', '0', '0', '0', '0', '0', '22', '26', '48', '2015-03-31 13:20:06');
INSERT INTO `manufactured` VALUES ('13', '2015-03-30', '507', '41060', '114380', '11', '10', '0', '21', '37', '62', '67', '0', '0', '0', '187', '2015-03-31 13:20:31');
INSERT INTO `manufactured` VALUES ('14', '2015-03-28', '510', '40783', '114378', '1', '11', '0', '0', '0', '90', '0', '0', '0', '0', '90', '2015-03-31 13:24:24');
INSERT INTO `manufactured` VALUES ('15', '2015-03-30', '510', '40783', '114378', '1', '11', '0', '0', '0', '90', '90', '0', '90', '0', '270', '2015-03-31 13:24:50');
INSERT INTO `manufactured` VALUES ('16', '2015-03-31', '511', '40971', '114570', '7', '7', '0', '0', '0', '0', '0', '0', '29', '13', '42', '2015-04-01 14:19:23');
INSERT INTO `manufactured` VALUES ('17', '2015-03-31', '511', '40971', '114571', '7', '7', '11', '27', '49', '30', '43', '0', '16', '0', '176', '2015-04-01 14:21:52');
INSERT INTO `manufactured` VALUES ('18', '2015-03-31', '507', '47235', '114232', '4', '8', '0', '0', '0', '96', '120', '74', '0', '0', '290', '2015-04-03 13:06:53');
INSERT INTO `manufactured` VALUES ('19', '2015-03-31', '511', '40970', '114573', '7', '9', '0', '0', '0', '108', '96', '61', '33', '25', '323', '2015-04-01 14:44:56');
INSERT INTO `manufactured` VALUES ('20', '2015-03-31', '507', '41060', '114380', '11', '10', '0', '0', '0', '0', '0', '42', '31', '21', '94', '2015-04-01 14:45:24');
INSERT INTO `manufactured` VALUES ('21', '2015-03-31', '511', '40970', '114576', '1', '10', '14', '54', '50', '0', '0', '0', '0', '0', '118', '2015-04-01 14:50:19');
INSERT INTO `manufactured` VALUES ('22', '2015-03-31', '510', '40783', '114378', '1', '11', '0', '0', '0', '90', '90', '0', '90', '0', '270', '2015-04-01 14:51:48');
INSERT INTO `manufactured` VALUES ('23', '2015-04-01', '511', '40970', '114576', '1', '10', '0', '50', '0', '146', '50', '0', '0', '0', '246', '2015-04-02 14:09:30');
INSERT INTO `manufactured` VALUES ('24', '2015-04-02', '513', '47660', '114768', '12', '7', '19', '50', '30', '0', '0', '0', '0', '0', '99', '2015-04-03 13:06:00');

-- ----------------------------
-- Table structure for `tableinfo`
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
-- Table structure for `versions`
-- ----------------------------
DROP TABLE IF EXISTS `versions`;
CREATE TABLE `versions` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Version` varchar(10) NOT NULL,
  `Updated_Dt` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `VERSION` (`Version`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

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
INSERT INTO `versions` VALUES ('9', '1966/017', '2015-03-26 13:15:07');
INSERT INTO `versions` VALUES ('10', '11340/011', '2015-04-03 12:51:15');
INSERT INTO `versions` VALUES ('11', '7641/009', '2015-04-03 12:56:19');
INSERT INTO `versions` VALUES ('12', '3500/011', '2015-04-03 12:58:39');
INSERT INTO `versions` VALUES ('13', '3503/017', '2015-04-03 12:59:40');
INSERT INTO `versions` VALUES ('14', '7618/017', '2015-04-03 13:01:57');
INSERT INTO `versions` VALUES ('15', '7618/013', '2015-04-03 13:03:33');
INSERT INTO `versions` VALUES ('16', '7604/018', '2015-04-03 13:56:30');
INSERT INTO `versions` VALUES ('17', '1968/011', '2015-04-03 14:07:55');
INSERT INTO `versions` VALUES ('18', '7625/017', '2015-04-03 14:09:21');
INSERT INTO `versions` VALUES ('19', '3550/009', '2015-04-03 14:10:11');
INSERT INTO `versions` VALUES ('20', '3551/045', '2015-04-03 14:49:23');
INSERT INTO `versions` VALUES ('21', '3550/049', '2015-04-03 14:49:58');
INSERT INTO `versions` VALUES ('22', '11345/017', '2015-04-03 14:51:08');
INSERT INTO `versions` VALUES ('23', '3551/017', '2015-04-03 14:51:51');
INSERT INTO `versions` VALUES ('24', '3550/011', '2015-04-03 14:53:19');
INSERT INTO `versions` VALUES ('25', '3552/016', '2015-04-03 14:54:19');
INSERT INTO `versions` VALUES ('26', '7618/017', '2015-04-03 15:19:25');
INSERT INTO `versions` VALUES ('27', '1500/011', '2015-04-03 15:21:43');
INSERT INTO `versions` VALUES ('28', '7604/011', '2015-04-03 15:22:31');
INSERT INTO `versions` VALUES ('29', '3551/015', '2015-04-03 15:23:18');
INSERT INTO `versions` VALUES ('30', '3552/003', '2015-04-03 15:23:57');

-- ----------------------------
-- Table structure for `worck`
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
  CONSTRAINT `fk_bu` FOREIGN KEY (`Bu_ID`) REFERENCES `bu` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Foundo` FOREIGN KEY (`Foundo_ID`) REFERENCES `foundo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Lavoration` FOREIGN KEY (`Lavoratione_ID`) REFERENCES `lavoratione` (`Lavoratoine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_linia` FOREIGN KEY (`Linia_ID`) REFERENCES `linia` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Versions` FOREIGN KEY (`Versions_ID`) REFERENCES `versions` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `worck_ibfk_1` FOREIGN KEY (`Article_ID`) REFERENCES `article` (`ArticleNo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of worck
-- ----------------------------
INSERT INTO `worck` VALUES ('1', '511', '40971', '114569', '16', '7', '1', '583', '0', '0', '0', '0', '0', '0', '0', '583', '2015-04-03 15:45:00');
INSERT INTO `worck` VALUES ('2', '511', '40971', '114570', '15', '7', '1', '382', '0', '0', '0', '0', '0', '0', '0', '382', '2015-04-03 15:45:07');
INSERT INTO `worck` VALUES ('3', '511', '40971', '114571', '11', '7', '1', '257', '0', '0', '0', '0', '0', '0', '0', '257', '2015-04-03 15:45:13');
INSERT INTO `worck` VALUES ('4', '511', '40970', '114572', '9', '7', '1', '216', '0', '0', '0', '0', '0', '0', '0', '216', '2015-04-03 15:45:20');
INSERT INTO `worck` VALUES ('5', '511', '40970', '114573', '17', '7', '1', '486', '0', '0', '0', '0', '0', '0', '0', '486', '2015-04-03 15:45:30');
INSERT INTO `worck` VALUES ('6', '511', '40834', '114574', '14', '1', '1', '727', '0', '0', '0', '0', '0', '0', '0', '727', '2015-04-03 15:45:25');
INSERT INTO `worck` VALUES ('7', '511', '40834', '114575', '18', '1', '1', '620', '0', '0', '0', '0', '0', '0', '0', '620', '2015-04-03 15:45:35');
INSERT INTO `worck` VALUES ('8', '511', '40790', '114576', '2', '1', '1', '631', '0', '0', '0', '0', '0', '0', '0', '631', '2015-04-03 15:45:45');
INSERT INTO `worck` VALUES ('9', '511', '40770', '114577', '2', '1', '1', '333', '0', '0', '0', '0', '0', '0', '0', '333', '2015-04-03 15:45:50');
INSERT INTO `worck` VALUES ('10', '511', '40780', '114578', '2', '1', '1', '831', '0', '0', '0', '0', '0', '0', '0', '831', '2015-04-03 15:45:54');
INSERT INTO `worck` VALUES ('11', '511', '41598', '114579', '19', '8', '1', '676', '0', '0', '0', '0', '0', '0', '0', '676', '2015-04-03 15:45:59');
INSERT INTO `worck` VALUES ('12', '510', '40783', '114378', '2', '1', '1', '4536', '0', '0', '0', '0', '0', '0', '0', '4536', '2015-04-03 15:46:04');
INSERT INTO `worck` VALUES ('13', '510', '41060', '114379', '13', '11', '1', '399', '0', '0', '0', '0', '0', '0', '0', '399', '2015-04-03 15:46:04');
INSERT INTO `worck` VALUES ('14', '510', '41060', '114380', '12', '11', '1', '281', '0', '0', '0', '0', '0', '0', '0', '281', '2015-04-03 15:46:14');
INSERT INTO `worck` VALUES ('15', '510', '41598', '114381', '20', '8', '1', '1104', '0', '0', '0', '0', '0', '0', '0', '1104', '2015-04-03 15:46:21');
INSERT INTO `worck` VALUES ('16', '510', '41598', '114382', '21', '8', '1', '1104', '0', '0', '0', '0', '0', '0', '0', '1104', '2015-04-03 15:46:21');
INSERT INTO `worck` VALUES ('17', '513', '47660', '114768', '10', '12', '1', '519', '0', '0', '0', '0', '0', '0', '0', '519', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('18', '513', '47662', '114769', '22', '12', '1', '1240', '0', '0', '0', '0', '0', '0', '0', '1240', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('19', '513', '41585', '114770', '23', '8', '1', '622', '0', '0', '0', '0', '0', '0', '0', '622', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('20', '513', '41585', '114771', '24', '8', '1', '869', '0', '0', '0', '0', '0', '0', '0', '869', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('21', '513', '41578', '114772', '23', '8', '1', '623', '0', '0', '0', '0', '0', '0', '0', '623', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('22', '513', '41578', '114773', '24', '8', '1', '611', '0', '0', '0', '0', '0', '0', '0', '611', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('23', '513', '41588', '114774', '25', '8', '1', '498', '0', '0', '0', '0', '0', '0', '0', '498', '2015-04-03 15:44:44');
INSERT INTO `worck` VALUES ('24', '513', '41588', '114775', '24', '8', '1', '498', '0', '0', '0', '0', '0', '0', '0', '498', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('25', '513', '41588', '114776', '25', '8', '1', '819', '0', '0', '0', '0', '0', '0', '0', '819', '2015-04-03 15:47:57');
INSERT INTO `worck` VALUES ('26', '513', '41588', '114777', '24', '8', '1', '400', '0', '0', '0', '0', '0', '0', '0', '400', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('27', '513', '41588', '114778', '24', '8', '1', '766', '0', '0', '0', '0', '0', '0', '0', '766', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('28', '507', '47231', '114230', '9', '4', '1', '416', '0', '0', '0', '0', '0', '0', '0', '416', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('29', '507', '47236', '114231', '11', '4', '1', '673', '0', '0', '0', '0', '0', '0', '0', '673', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('30', '507', '47235', '114232', '26', '4', '1', '1002', '0', '0', '0', '0', '0', '0', '0', '1002', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('31', '507', '47230', '114233', '17', '4', '1', '1002', '0', '0', '0', '0', '0', '0', '0', '1002', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('32', '507', '40830', '114234', '27', '1', '1', '375', '0', '0', '0', '0', '0', '0', '0', '375', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('33', '507', '47380', '114235', '28', '13', '1', '602', '0', '0', '0', '0', '0', '0', '0', '602', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('34', '507', '47381', '114236', '18', '13', '1', '447', '0', '0', '0', '0', '0', '0', '0', '447', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('35', '507', '47382', '114237', '14', '13', '1', '601', '0', '0', '0', '0', '0', '0', '0', '601', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('36', '507', '41598', '114238', '29', '8', '1', '285', '0', '0', '0', '0', '0', '0', '0', '2598', '2015-03-20 10:13:03');
INSERT INTO `worck` VALUES ('37', '507', '41598', '114239', '19', '8', '1', '440', '0', '0', '0', '0', '0', '0', '0', '440', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('38', '507', '41598', '114240', '30', '8', '1', '631', '0', '0', '0', '0', '0', '0', '0', '631', '2015-04-03 15:47:06');
