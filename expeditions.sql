/*
Navicat MySQL Data Transfer

Source Server         : NEV
Source Server Version : 50616
Source Host           : localhost:3306
Source Database       : expeditions

Target Server Type    : MYSQL
Target Server Version : 50616
File Encoding         : 65001

Date: 2015-05-29 15:28:33
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for article
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
INSERT INTO `article` VALUES ('41021', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('41022', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('41050', '6.75', '2015-08-04 10:30:00');
INSERT INTO `article` VALUES ('41060', '7.31', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('41070', '0.00', '2015-04-23 13:33:27');
INSERT INTO `article` VALUES ('41071', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('41080', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('41578', '8.05', '2015-04-03 13:19:00');
INSERT INTO `article` VALUES ('41585', '9.74', '2015-04-03 13:19:00');
INSERT INTO `article` VALUES ('41588', '9.71', '2015-04-03 13:19:00');
INSERT INTO `article` VALUES ('41593', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('41598', '7.62', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('41891', '6.59', '2015-08-04 10:30:00');
INSERT INTO `article` VALUES ('47230', '8.02', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47231', '8.67', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47233', '0.00', '2015-04-23 13:30:29');
INSERT INTO `article` VALUES ('47235', '6.05', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47236', '6.25', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47380', '5.77', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47381', '5.79', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47382', '5.74', '2015-03-26 09:15:00');
INSERT INTO `article` VALUES ('47650', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('47651', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('47660', '8.43', '2015-04-03 12:49:54');
INSERT INTO `article` VALUES ('47661', '0.00', '2015-06-06 10:30:00');
INSERT INTO `article` VALUES ('47662', '7.90', '2015-04-03 13:19:00');
INSERT INTO `article` VALUES ('49060', '7.60', '2015-04-20 00:00:00');
INSERT INTO `article` VALUES ('49061', '8.07', '2015-04-20 00:00:00');
INSERT INTO `article` VALUES ('49070', '5.92', '2015-08-04 10:30:00');
INSERT INTO `article` VALUES ('49072', '5.38', '2015-08-04 10:30:00');
INSERT INTO `article` VALUES ('49080', '7.50', '2015-08-04 10:30:00');
INSERT INTO `article` VALUES ('49083', '5.34', '2015-08-04 10:30:00');
INSERT INTO `article` VALUES ('49084', '5.29', '2015-08-04 10:30:00');

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
) ENGINE=InnoDB AUTO_INCREMENT=521 DEFAULT CHARSET=utf8;

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
INSERT INTO `bu` VALUES ('514', '2015-04-01', '2015-04-09 14:05:48');
INSERT INTO `bu` VALUES ('516', '2015-04-08', '2015-04-09 14:06:05');
INSERT INTO `bu` VALUES ('517', '2015-04-15', '2015-04-23 13:25:23');
INSERT INTO `bu` VALUES ('518', '2015-04-22', '2015-05-06 13:34:43');
INSERT INTO `bu` VALUES ('519', '2015-04-29', '2015-05-06 13:35:46');
INSERT INTO `bu` VALUES ('520', '2015-05-06', '2015-05-27 11:59:22');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of expedirani
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

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
INSERT INTO `foundo` VALUES ('14', 'TRAVEL ENVAL', '2015-04-09 15:39:01');
INSERT INTO `foundo` VALUES ('15', 'TWINGO GALLUS', '2015-04-09 15:45:20');

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
INSERT INTO `lavoratione` VALUES ('114969', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114970', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114971', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114972', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114973', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114974', '2015-04-09 15:53:35');
INSERT INTO `lavoratione` VALUES ('114975', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114976', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114977', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114978', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114979', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114980', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114981', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114982', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('114983', '2015-08-04 10:35:00');
INSERT INTO `lavoratione` VALUES ('115134', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115135', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115136', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115137', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115138', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115139', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115140', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115141', '2015-04-09 13:56:00');
INSERT INTO `lavoratione` VALUES ('115320', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115321', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115322', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115323', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115324', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115325', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115326', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115327', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115328', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115329', '2015-04-23 13:04:03');
INSERT INTO `lavoratione` VALUES ('115655', '2015-05-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115656', '2015-04-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115657', '2015-04-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115658', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115659', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115660', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115661', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115662', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115663', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115664', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115665', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115666', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115866', '2015-05-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115867', '2015-04-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115868', '2015-04-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115869', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115870', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115871', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('115872', '2015-06-06 13:56:00');
INSERT INTO `lavoratione` VALUES ('116184', '2015-05-27 11:59:55');

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
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of leave
-- ----------------------------
INSERT INTO `leave` VALUES ('1', '507', '47231', '114230', '9', '4', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-09 11:40:51');
INSERT INTO `leave` VALUES ('2', '511', '40971', '114570', '15', '7', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:03:58');
INSERT INTO `leave` VALUES ('3', '507', '47235', '114232', '14', '4', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-09 11:40:09');
INSERT INTO `leave` VALUES ('4', '511', '40970', '114572', '9', '7', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:00:54');
INSERT INTO `leave` VALUES ('5', '511', '40970', '114573', '9', '7', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:00:48');
INSERT INTO `leave` VALUES ('6', '510', '41060', '114379', '13', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 13:00:37');
INSERT INTO `leave` VALUES ('7', '510', '41060', '114380', '12', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-03 12:59:09');
INSERT INTO `leave` VALUES ('8', '510', '40783', '114378', '2', '1', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-10 10:31:21');
INSERT INTO `leave` VALUES ('9', '511', '40971', '114571', '11', '7', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-09 11:43:34');
INSERT INTO `leave` VALUES ('10', '511', '40970', '114576', '2', '1', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-06 12:52:32');
INSERT INTO `leave` VALUES ('11', '513', '47660', '114768', '10', '12', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-09 11:44:02');
INSERT INTO `leave` VALUES ('12', '511', '40770', '114577', '2', '1', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-09 12:44:37');
INSERT INTO `leave` VALUES ('13', '505', '41578', '114058', '23', '8', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-14 14:57:52');
INSERT INTO `leave` VALUES ('14', '513', '47662', '114769', '22', '12', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-21 15:20:13');
INSERT INTO `leave` VALUES ('15', '507', '41598', '114239', '19', '8', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-11 09:33:03');
INSERT INTO `leave` VALUES ('16', '511', '40780', '114578', '2', '1', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-11 09:38:10');
INSERT INTO `leave` VALUES ('17', '514', '40770', '114975', '2', '1', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-17 11:14:34');
INSERT INTO `leave` VALUES ('18', '507', '41598', '114238', '29', '8', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-14 15:25:52');
INSERT INTO `leave` VALUES ('19', '514', '41891', '114983', '33', '15', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-30 16:52:03');
INSERT INTO `leave` VALUES ('20', '505', '41578', '114059', '23', '8', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-17 11:05:42');
INSERT INTO `leave` VALUES ('21', '507', '41598', '114240', '30', '8', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-20 12:33:14');
INSERT INTO `leave` VALUES ('22', '514', '49080', '114969', '2', '14', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-21 12:41:15');
INSERT INTO `leave` VALUES ('23', '505', '41578', '114060', '24', '8', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-21 12:41:56');
INSERT INTO `leave` VALUES ('24', '516', '40770', '115136', '2', '1', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-22 13:41:16');
INSERT INTO `leave` VALUES ('25', '510', '41598', '114381', '20', '8', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-08 11:48:28');
INSERT INTO `leave` VALUES ('26', '513', '41578', '114773', '24', '8', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-28 11:28:08');
INSERT INTO `leave` VALUES ('27', '514', '49083', '114970', '18', '14', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-23 11:17:26');
INSERT INTO `leave` VALUES ('28', '514', '49084', '114971', '15', '14', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-28 12:38:28');
INSERT INTO `leave` VALUES ('29', '516', '41891', '115141', '33', '15', '11', '0', '0', '0', '0', '0', '114', '20', '190', '324', '2015-05-18 13:31:51');
INSERT INTO `leave` VALUES ('30', '513', '41588', '114777', '24', '8', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-06 15:21:34');
INSERT INTO `leave` VALUES ('31', '516', '40971', '115135', '15', '7', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-28 12:51:29');
INSERT INTO `leave` VALUES ('32', '514', '40971', '114972', '31', '7', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-06 14:44:00');
INSERT INTO `leave` VALUES ('33', '513', '41578', '114772', '23', '8', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-04-30 16:43:32');
INSERT INTO `leave` VALUES ('34', '513', '40971', '114973', '24', '8', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-09 11:23:08');
INSERT INTO `leave` VALUES ('35', '514', '49072', '114977', '18', '5', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-06 14:48:56');
INSERT INTO `leave` VALUES ('36', '514', '41598', '114382', '21', '8', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-12 14:14:15');
INSERT INTO `leave` VALUES ('37', '514', '41050', '114979', '12', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-06 15:03:27');
INSERT INTO `leave` VALUES ('38', '514', '41060', '114981', '13', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-08 11:55:57');
INSERT INTO `leave` VALUES ('39', '514', '40970', '114974', '17', '7', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-08 11:44:06');
INSERT INTO `leave` VALUES ('40', '514', '49070', '114976', '27', '5', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-06 14:55:33');
INSERT INTO `leave` VALUES ('41', '514', '40830', '114978', '27', '1', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-08 11:44:35');
INSERT INTO `leave` VALUES ('42', '513', '41588', '114775', '24', '9', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-06 15:45:52');
INSERT INTO `leave` VALUES ('43', '517', '40830', '115324', '27', '1', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-08 11:48:09');
INSERT INTO `leave` VALUES ('44', '517', '41060', '115327', '36', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-11 12:51:30');
INSERT INTO `leave` VALUES ('45', '513', '41588', '114778', '24', '8', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-13 13:38:28');
INSERT INTO `leave` VALUES ('46', '516', '47230', '115140', '17', '4', '7', '0', '0', '0', '89', '110', '153', '157', '64', '573', '2015-05-18 13:25:24');
INSERT INTO `leave` VALUES ('47', '517', '41891', '115329', '39', '15', '8', '0', '0', '0', '276', '665', '481', '320', '137', '1879', '2015-05-18 13:25:46');
INSERT INTO `leave` VALUES ('48', '514', '41578', '114579', '19', '8', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-14 13:12:15');
INSERT INTO `leave` VALUES ('49', '514', '41060', '114982', '12', '12', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-13 13:25:42');
INSERT INTO `leave` VALUES ('50', '517', '41060', '115326', '35', '11', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-15 10:36:55');
INSERT INTO `leave` VALUES ('51', '513', '41588', '114774', '25', '8', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-15 10:37:59');
INSERT INTO `leave` VALUES ('52', '518', '41593', '115661', '19', '9', '9', '0', '0', '0', '0', '0', '0', '37', '37', '74', '2015-05-15 10:36:27');
INSERT INTO `leave` VALUES ('53', '518', '41593', '115660', '9', '9', '9', '0', '0', '0', '30', '83', '47', '42', '0', '202', '2015-05-18 13:28:42');
INSERT INTO `leave` VALUES ('54', '517', '41070', '115325', '12', '11', '10', '0', '0', '0', '0', '0', '50', '30', '13', '93', '2015-05-18 13:31:11');
INSERT INTO `leave` VALUES ('55', '518', '41891', '115659', '33', '15', '11', '0', '214', '190', '555', '555', '555', '280', '214', '2563', '2015-05-18 13:34:44');
INSERT INTO `leave` VALUES ('56', '513', '41588', '114776', '25', '8', '5', '5', '21', '95', '154', '194', '114', '20', '10', '613', '2015-05-18 13:40:24');
INSERT INTO `leave` VALUES ('58', '518', '41022', '115658', '39', '11', '6', '0', '42', '83', '124', '124', '124', '83', '42', '622', '2015-05-27 12:44:59');
INSERT INTO `leave` VALUES ('59', '520', '41022', '116184', '39', '11', '6', '0', '0', '9', '215', '268', '318', '169', '169', '1148', '2015-05-28 16:42:05');
INSERT INTO `leave` VALUES ('61', '513', '41585', '114771', '24', '8', '5', '0', '0', '19', '106', '111', '150', '104', '52', '542', '2015-05-28 16:41:24');
INSERT INTO `leave` VALUES ('62', '518', '41021', '115657', '39', '8', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-27 13:34:20');
INSERT INTO `leave` VALUES ('63', '513', '41585', '114770', '23', '8', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2015-05-27 13:19:51');

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
INSERT INTO `linia` VALUES ('5', '5 ШивалняМария', '2014-09-21 15:54:08');
INSERT INTO `linia` VALUES ('6', '6 ШивалняКалина', '2015-04-17 10:34:30');
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
) ENGINE=InnoDB AUTO_INCREMENT=251 DEFAULT CHARSET=utf8;

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
INSERT INTO `manufactured` VALUES ('23', '2015-04-01', '511', '40970', '114576', '1', '10', '0', '0', '50', '146', '50', '0', '0', '0', '246', '2015-04-03 16:03:27');
INSERT INTO `manufactured` VALUES ('24', '2015-04-02', '513', '47660', '114768', '12', '7', '19', '50', '30', '0', '0', '0', '0', '0', '99', '2015-04-03 13:06:00');
INSERT INTO `manufactured` VALUES ('25', '2015-04-02', '511', '40970', '114576', '1', '10', '0', '0', '0', '0', '97', '98', '52', '0', '247', '2015-04-03 16:07:17');
INSERT INTO `manufactured` VALUES ('26', '2015-04-01', '510', '40783', '114378', '1', '11', '0', '0', '0', '90', '100', '0', '40', '0', '230', '2015-04-03 16:08:28');
INSERT INTO `manufactured` VALUES ('27', '2015-04-02', '510', '40783', '114378', '1', '11', '0', '0', '0', '110', '120', '0', '0', '0', '230', '2015-04-03 16:08:57');
INSERT INTO `manufactured` VALUES ('28', '2015-04-03', '513', '47660', '114768', '12', '7', '0', '0', '61', '50', '0', '0', '0', '0', '111', '2015-04-06 12:47:53');
INSERT INTO `manufactured` VALUES ('29', '2015-04-03', '511', '40770', '114577', '1', '10', '6', '32', '49', '0', '0', '0', '0', '0', '87', '2015-04-06 12:52:03');
INSERT INTO `manufactured` VALUES ('30', '2015-04-03', '511', '40970', '114576', '1', '10', '0', '0', '0', '0', '0', '0', '0', '20', '20', '2015-04-06 12:52:32');
INSERT INTO `manufactured` VALUES ('31', '2015-04-03', '510', '40783', '114378', '1', '11', '0', '0', '0', '100', '130', '0', '0', '0', '230', '2015-04-06 12:53:51');
INSERT INTO `manufactured` VALUES ('32', '2015-04-06', '513', '47660', '114768', '12', '7', '0', '0', '0', '63', '70', '0', '0', '0', '133', '2015-04-09 11:16:42');
INSERT INTO `manufactured` VALUES ('33', '2015-04-06', '505', '41578', '114058', '8', '8', '0', '25', '50', '40', '0', '0', '0', '0', '115', '2015-04-09 11:31:44');
INSERT INTO `manufactured` VALUES ('34', '2015-04-07', '513', '47660', '114768', '12', '7', '0', '0', '0', '0', '39', '68', '0', '19', '126', '2015-04-09 11:32:45');
INSERT INTO `manufactured` VALUES ('35', '2015-04-08', '513', '47662', '114769', '12', '7', '45', '90', '0', '0', '0', '0', '0', '0', '135', '2015-04-09 11:38:26');
INSERT INTO `manufactured` VALUES ('36', '2015-04-07', '505', '41578', '114058', '8', '8', '0', '0', '0', '30', '74', '0', '0', '0', '104', '2015-04-09 11:39:41');
INSERT INTO `manufactured` VALUES ('37', '2015-04-08', '507', '47235', '114232', '4', '8', '0', '0', '0', '0', '0', '60', '104', '0', '164', '2015-04-09 11:40:09');
INSERT INTO `manufactured` VALUES ('38', '2015-04-06', '507', '41598', '114239', '8', '9', '3', '17', '20', '0', '0', '0', '0', '0', '40', '2015-04-09 11:44:47');
INSERT INTO `manufactured` VALUES ('39', '2015-04-07', '507', '41598', '114239', '8', '9', '0', '0', '26', '77', '0', '0', '0', '0', '103', '2015-04-09 11:45:36');
INSERT INTO `manufactured` VALUES ('40', '2015-04-08', '507', '41598', '114239', '8', '9', '0', '0', '0', '0', '107', '0', '0', '0', '107', '2015-04-09 11:46:01');
INSERT INTO `manufactured` VALUES ('41', '2015-04-07', '511', '40780', '114578', '1', '10', '0', '13', '77', '90', '50', '0', '0', '0', '230', '2015-04-09 11:58:39');
INSERT INTO `manufactured` VALUES ('42', '2015-04-08', '511', '40780', '114578', '1', '10', '0', '0', '0', '56', '130', '50', '0', '0', '236', '2015-04-09 11:59:30');
INSERT INTO `manufactured` VALUES ('43', '2015-04-06', '510', '40783', '114378', '1', '11', '0', '0', '0', '100', '50', '0', '0', '0', '150', '2015-04-09 12:00:00');
INSERT INTO `manufactured` VALUES ('44', '2015-04-07', '510', '40783', '114378', '1', '11', '0', '0', '0', '0', '50', '0', '0', '0', '50', '2015-04-09 12:00:49');
INSERT INTO `manufactured` VALUES ('45', '2015-04-08', '510', '40783', '114378', '1', '11', '0', '0', '0', '100', '120', '0', '0', '0', '220', '2015-04-09 12:01:10');
INSERT INTO `manufactured` VALUES ('46', '2015-04-06', '511', '40770', '114577', '1', '10', '0', '0', '0', '82', '71', '50', '25', '18', '246', '2015-04-09 12:44:37');
INSERT INTO `manufactured` VALUES ('47', '2015-04-09', '511', '40971', '114569', '7', '7', '0', '0', '0', '0', '0', '0', '0', '28', '28', '2015-04-10 10:20:48');
INSERT INTO `manufactured` VALUES ('48', '2015-04-09', '511', '40971', '114571', '7', '7', '0', '0', '0', '32', '10', '20', '0', '7', '69', '2015-04-10 10:21:31');
INSERT INTO `manufactured` VALUES ('49', '2015-04-09', '513', '47662', '114769', '12', '7', '0', '0', '60', '0', '0', '0', '0', '0', '60', '2015-04-10 10:23:33');
INSERT INTO `manufactured` VALUES ('50', '2015-04-09', '505', '41578', '114058', '8', '8', '0', '0', '0', '54', '60', '0', '0', '0', '114', '2015-04-10 10:27:18');
INSERT INTO `manufactured` VALUES ('51', '2015-04-09', '507', '41598', '114239', '8', '9', '0', '0', '0', '0', '0', '92', '10', '0', '102', '2015-04-10 10:28:36');
INSERT INTO `manufactured` VALUES ('52', '2015-04-09', '511', '40780', '114578', '1', '10', '0', '0', '0', '0', '25', '148', '70', '0', '243', '2015-04-10 10:30:03');
INSERT INTO `manufactured` VALUES ('53', '2015-04-09', '510', '40783', '114378', '1', '11', '0', '0', '0', '27', '67', '0', '0', '0', '94', '2015-04-10 10:31:21');
INSERT INTO `manufactured` VALUES ('54', '2015-04-09', '514', '40770', '114975', '1', '11', '0', '90', '0', '0', '0', '0', '0', '0', '90', '2015-04-10 10:31:44');
INSERT INTO `manufactured` VALUES ('55', '2015-04-10', '513', '47662', '114769', '12', '7', '0', '49', '30', '48', '0', '0', '0', '0', '127', '2015-04-11 09:29:52');
INSERT INTO `manufactured` VALUES ('56', '2015-04-10', '505', '41578', '114058', '8', '8', '0', '0', '0', '0', '40', '74', '0', '0', '114', '2015-04-11 09:30:23');
INSERT INTO `manufactured` VALUES ('57', '2015-04-10', '507', '41598', '114239', '8', '9', '0', '0', '0', '0', '0', '0', '46', '42', '88', '2015-04-11 09:33:03');
INSERT INTO `manufactured` VALUES ('58', '2015-04-10', '507', '41598', '114238', '8', '9', '7', '24', '0', '0', '0', '0', '0', '0', '31', '2015-04-11 09:36:55');
INSERT INTO `manufactured` VALUES ('59', '2015-04-10', '511', '40780', '114578', '1', '10', '0', '0', '0', '0', '0', '0', '58', '64', '122', '2015-04-11 09:38:10');
INSERT INTO `manufactured` VALUES ('60', '2015-04-10', '514', '41891', '114983', '15', '10', '0', '90', '50', '0', '0', '0', '0', '0', '140', '2015-04-11 09:41:51');
INSERT INTO `manufactured` VALUES ('61', '2015-04-10', '514', '40770', '114975', '1', '11', '0', '44', '130', '90', '0', '0', '0', '0', '264', '2015-04-11 09:42:23');
INSERT INTO `manufactured` VALUES ('62', '2015-04-11', '513', '47662', '114769', '12', '7', '0', '0', '90', '70', '0', '0', '0', '0', '160', '2015-04-13 14:34:38');
INSERT INTO `manufactured` VALUES ('63', '2015-04-11', '505', '41578', '114058', '8', '8', '0', '0', '0', '0', '0', '50', '70', '0', '120', '2015-04-13 14:35:12');
INSERT INTO `manufactured` VALUES ('64', '2015-04-11', '507', '41598', '114238', '8', '9', '0', '0', '42', '63', '20', '0', '0', '0', '125', '2015-04-13 14:36:43');
INSERT INTO `manufactured` VALUES ('65', '2015-04-11', '514', '41891', '114983', '15', '10', '0', '20', '40', '90', '0', '0', '0', '0', '150', '2015-04-13 14:37:08');
INSERT INTO `manufactured` VALUES ('66', '2015-04-11', '514', '40770', '114975', '1', '11', '0', '0', '110', '90', '52', '0', '0', '0', '252', '2015-04-13 14:37:49');
INSERT INTO `manufactured` VALUES ('67', '2015-04-13', '513', '47662', '114769', '12', '7', '0', '0', '55', '90', '49', '0', '0', '0', '194', '2015-04-14 14:57:18');
INSERT INTO `manufactured` VALUES ('68', '2015-04-13', '505', '41578', '114058', '8', '8', '0', '0', '0', '0', '0', '0', '29', '50', '79', '2015-04-14 14:57:52');
INSERT INTO `manufactured` VALUES ('69', '2015-04-13', '505', '41578', '114059', '8', '8', '0', '13', '25', '32', '0', '0', '0', '0', '70', '2015-04-14 15:24:02');
INSERT INTO `manufactured` VALUES ('70', '2015-04-13', '507', '41598', '114238', '8', '9', '0', '0', '0', '0', '44', '46', '24', '15', '129', '2015-04-14 15:25:52');
INSERT INTO `manufactured` VALUES ('71', '2015-04-13', '507', '41598', '114240', '8', '9', '2', '17', '7', '0', '0', '0', '0', '0', '26', '2015-04-14 15:41:55');
INSERT INTO `manufactured` VALUES ('72', '2015-04-13', '514', '41891', '114983', '15', '10', '0', '70', '90', '20', '0', '0', '0', '0', '180', '2015-04-14 15:42:21');
INSERT INTO `manufactured` VALUES ('73', '2015-04-13', '514', '40770', '114975', '1', '11', '0', '0', '28', '150', '90', '0', '0', '0', '268', '2015-04-14 15:43:01');
INSERT INTO `manufactured` VALUES ('74', '2015-04-14', '513', '47662', '114769', '12', '7', '0', '0', '0', '90', '90', '36', '0', '0', '216', '2015-04-15 11:47:33');
INSERT INTO `manufactured` VALUES ('75', '2015-04-14', '505', '41578', '114059', '8', '8', '0', '0', '0', '30', '87', '50', '0', '0', '167', '2015-04-15 11:48:19');
INSERT INTO `manufactured` VALUES ('76', '2015-04-14', '507', '41598', '114240', '8', '9', '0', '0', '60', '80', '30', '0', '0', '0', '170', '2015-04-15 11:48:55');
INSERT INTO `manufactured` VALUES ('77', '2015-04-14', '514', '41891', '114983', '15', '10', '0', '87', '40', '70', '0', '0', '0', '0', '197', '2015-04-15 11:50:42');
INSERT INTO `manufactured` VALUES ('78', '2015-04-14', '514', '40770', '114975', '1', '11', '0', '0', '0', '72', '90', '96', '0', '0', '258', '2015-04-15 11:51:52');
INSERT INTO `manufactured` VALUES ('79', '2015-04-15', '513', '47662', '114769', '12', '7', '0', '0', '0', '0', '90', '90', '0', '18', '198', '2015-04-17 11:00:47');
INSERT INTO `manufactured` VALUES ('80', '2015-04-16', '514', '49080', '114969', '14', '7', '43', '80', '100', '0', '0', '0', '0', '0', '223', '2015-04-17 11:05:17');
INSERT INTO `manufactured` VALUES ('81', '2015-04-15', '505', '41578', '114059', '8', '8', '0', '0', '0', '0', '0', '0', '38', '25', '63', '2015-04-17 11:05:42');
INSERT INTO `manufactured` VALUES ('82', '2015-04-15', '505', '41578', '114060', '8', '8', '0', '27', '50', '31', '0', '0', '0', '0', '108', '2015-04-17 11:11:20');
INSERT INTO `manufactured` VALUES ('83', '2015-04-16', '505', '41578', '114060', '8', '8', '0', '0', '0', '60', '50', '0', '0', '0', '110', '2015-04-17 11:11:38');
INSERT INTO `manufactured` VALUES ('84', '2015-04-15', '507', '41598', '114240', '8', '9', '0', '0', '0', '47', '120', '0', '0', '0', '167', '2015-04-17 11:12:13');
INSERT INTO `manufactured` VALUES ('85', '2015-04-16', '507', '41598', '114240', '8', '9', '0', '0', '0', '0', '0', '128', '0', '0', '128', '2015-04-17 11:12:34');
INSERT INTO `manufactured` VALUES ('86', '2015-04-15', '514', '41891', '114983', '15', '10', '0', '0', '116', '95', '0', '0', '0', '0', '211', '2015-04-17 11:13:01');
INSERT INTO `manufactured` VALUES ('87', '2015-04-16', '514', '41891', '114983', '15', '10', '0', '0', '0', '90', '90', '30', '0', '0', '210', '2015-04-17 11:13:29');
INSERT INTO `manufactured` VALUES ('88', '2015-04-15', '514', '40770', '114975', '1', '11', '0', '0', '0', '0', '110', '100', '44', '0', '254', '2015-04-17 11:14:05');
INSERT INTO `manufactured` VALUES ('89', '2015-04-16', '514', '40770', '114975', '1', '11', '0', '0', '0', '0', '60', '0', '90', '73', '223', '2015-04-17 11:14:34');
INSERT INTO `manufactured` VALUES ('90', '2015-04-16', '516', '40770', '115136', '1', '11', '30', '0', '0', '0', '0', '0', '0', '0', '30', '2015-04-17 11:18:33');
INSERT INTO `manufactured` VALUES ('91', '2015-04-17', '514', '49080', '114969', '14', '7', '0', '0', '23', '139', '80', '0', '0', '0', '242', '2015-04-20 12:32:05');
INSERT INTO `manufactured` VALUES ('92', '2015-04-17', '505', '41578', '114060', '8', '8', '0', '0', '0', '0', '50', '79', '20', '0', '149', '2015-04-20 12:32:50');
INSERT INTO `manufactured` VALUES ('93', '2015-04-17', '507', '41598', '114240', '8', '9', '0', '0', '0', '0', '0', '0', '88', '52', '140', '2015-04-20 12:33:14');
INSERT INTO `manufactured` VALUES ('94', '2015-04-17', '510', '41598', '114381', '8', '9', '0', '30', '0', '0', '0', '0', '0', '0', '30', '2015-04-20 12:36:47');
INSERT INTO `manufactured` VALUES ('95', '2015-04-17', '514', '41891', '114983', '15', '10', '0', '0', '0', '90', '90', '40', '0', '0', '220', '2015-04-20 12:37:11');
INSERT INTO `manufactured` VALUES ('96', '2015-04-17', '516', '40770', '115136', '1', '11', '0', '90', '57', '91', '0', '0', '0', '0', '238', '2015-04-20 12:37:35');
INSERT INTO `manufactured` VALUES ('97', '2015-04-20', '514', '49080', '114969', '14', '7', '0', '0', '0', '0', '30', '51', '21', '5', '107', '2015-04-21 12:41:15');
INSERT INTO `manufactured` VALUES ('98', '2015-04-20', '505', '41578', '114060', '8', '8', '0', '0', '0', '0', '0', '0', '27', '27', '54', '2015-04-21 12:41:56');
INSERT INTO `manufactured` VALUES ('99', '2015-04-20', '513', '41578', '114773', '8', '8', '4', '9', '56', '40', '0', '0', '0', '0', '109', '2015-04-21 12:47:16');
INSERT INTO `manufactured` VALUES ('100', '2015-04-20', '510', '41598', '114381', '8', '9', '0', '62', '70', '20', '0', '0', '0', '0', '152', '2015-04-21 12:47:44');
INSERT INTO `manufactured` VALUES ('101', '2015-04-20', '514', '41891', '114983', '15', '10', '0', '0', '0', '90', '90', '50', '0', '0', '230', '2015-04-21 12:48:08');
INSERT INTO `manufactured` VALUES ('102', '2015-04-20', '516', '40770', '115136', '1', '11', '0', '0', '80', '80', '100', '0', '0', '0', '260', '2015-04-21 12:48:32');
INSERT INTO `manufactured` VALUES ('103', '2015-04-20', '513', '47662', '114769', '12', '7', '0', '0', '0', '0', '30', '30', '90', '0', '150', '2015-04-21 15:20:13');
INSERT INTO `manufactured` VALUES ('104', '2015-04-21', '514', '49083', '114970', '14', '7', '24', '51', '83', '60', '0', '0', '0', '0', '218', '2015-04-22 13:39:20');
INSERT INTO `manufactured` VALUES ('105', '2015-04-21', '513', '41578', '114773', '8', '8', '0', '0', '0', '67', '49', '0', '0', '0', '116', '2015-04-22 13:39:51');
INSERT INTO `manufactured` VALUES ('106', '2015-04-21', '510', '41598', '114381', '8', '9', '0', '0', '70', '50', '0', '0', '0', '0', '120', '2015-04-22 13:40:20');
INSERT INTO `manufactured` VALUES ('107', '2015-04-21', '514', '41891', '114983', '15', '10', '0', '0', '0', '90', '70', '90', '0', '0', '250', '2015-04-22 13:40:47');
INSERT INTO `manufactured` VALUES ('108', '2015-04-21', '516', '40770', '115136', '1', '11', '0', '0', '0', '0', '65', '109', '54', '14', '242', '2015-04-22 13:41:16');
INSERT INTO `manufactured` VALUES ('109', '2015-04-22', '514', '49083', '114970', '14', '7', '0', '0', '0', '38', '84', '53', '30', '13', '218', '2015-04-23 11:17:26');
INSERT INTO `manufactured` VALUES ('110', '2015-04-22', '514', '49084', '114971', '14', '7', '27', '50', '0', '0', '0', '0', '0', '0', '77', '2015-04-23 11:20:49');
INSERT INTO `manufactured` VALUES ('111', '2015-04-22', '513', '41578', '114773', '8', '8', '0', '0', '0', '0', '100', '60', '0', '0', '160', '2015-04-23 11:21:36');
INSERT INTO `manufactured` VALUES ('112', '2015-04-22', '510', '41598', '114381', '8', '9', '0', '0', '10', '80', '10', '0', '0', '0', '100', '2015-04-23 11:22:20');
INSERT INTO `manufactured` VALUES ('113', '2015-04-22', '514', '41891', '114983', '15', '10', '0', '0', '0', '30', '110', '110', '0', '0', '250', '2015-04-23 11:23:46');
INSERT INTO `manufactured` VALUES ('114', '2015-04-22', '516', '41891', '115141', '15', '11', '0', '50', '0', '0', '0', '0', '0', '0', '50', '2015-04-23 11:28:44');
INSERT INTO `manufactured` VALUES ('115', '2015-04-23', '514', '49084', '114971', '14', '7', '0', '0', '78', '88', '78', '49', '0', '0', '293', '2015-04-24 13:11:37');
INSERT INTO `manufactured` VALUES ('116', '2015-04-23', '513', '41578', '114773', '8', '8', '0', '0', '0', '0', '0', '84', '0', '48', '132', '2015-04-24 13:12:08');
INSERT INTO `manufactured` VALUES ('117', '2015-04-23', '510', '41598', '114381', '8', '9', '0', '0', '34', '34', '90', '0', '0', '0', '158', '2015-04-24 13:12:38');
INSERT INTO `manufactured` VALUES ('118', '2015-04-23', '514', '41891', '114983', '15', '10', '0', '0', '0', '0', '120', '70', '66', '0', '256', '2015-04-24 13:13:02');
INSERT INTO `manufactured` VALUES ('119', '2015-04-23', '516', '41891', '115141', '15', '11', '0', '40', '90', '20', '0', '0', '0', '0', '150', '2015-04-24 13:13:27');
INSERT INTO `manufactured` VALUES ('120', '2015-04-24', '513', '41578', '114773', '8', '8', '0', '0', '0', '0', '0', '0', '94', '0', '94', '2015-04-28 11:41:46');
INSERT INTO `manufactured` VALUES ('121', '2015-04-25', '510', '41598', '114381', '8', '9', '0', '0', '0', '0', '70', '70', '10', '0', '150', '2015-04-28 12:35:31');
INSERT INTO `manufactured` VALUES ('122', '2015-04-27', '510', '41598', '114381', '8', '9', '0', '0', '0', '0', '26', '24', '82', '40', '172', '2015-04-28 12:36:53');
INSERT INTO `manufactured` VALUES ('123', '2015-04-24', '514', '49084', '114971', '14', '7', '0', '0', '0', '0', '0', '0', '32', '14', '46', '2015-04-28 12:38:28');
INSERT INTO `manufactured` VALUES ('124', '2015-04-24', '514', '40971', '114972', '7', '7', '31', '81', '80', '0', '0', '0', '0', '0', '192', '2015-04-28 12:41:47');
INSERT INTO `manufactured` VALUES ('125', '2015-04-25', '514', '40971', '114972', '7', '7', '0', '0', '76', '130', '0', '0', '0', '0', '206', '2015-04-28 12:42:08');
INSERT INTO `manufactured` VALUES ('126', '2015-04-27', '514', '40971', '114972', '7', '7', '0', '0', '0', '96', '161', '0', '0', '0', '257', '2015-04-28 12:42:32');
INSERT INTO `manufactured` VALUES ('127', '2015-04-24', '513', '41578', '114772', '8', '8', '5', '9', '56', '0', '0', '0', '0', '0', '70', '2015-04-28 12:45:53');
INSERT INTO `manufactured` VALUES ('128', '2015-04-25', '513', '41578', '114772', '8', '8', '0', '0', '0', '107', '50', '0', '0', '0', '157', '2015-04-28 12:46:11');
INSERT INTO `manufactured` VALUES ('129', '2015-04-27', '513', '41578', '114772', '8', '8', '0', '0', '0', '0', '30', '46', '80', '0', '156', '2015-04-28 12:46:31');
INSERT INTO `manufactured` VALUES ('130', '2015-04-24', '514', '41891', '114983', '15', '10', '0', '0', '0', '0', '60', '90', '90', '0', '240', '2015-04-28 12:47:42');
INSERT INTO `manufactured` VALUES ('131', '2015-04-25', '514', '41891', '114983', '15', '10', '0', '0', '0', '0', '35', '90', '90', '55', '270', '2015-04-28 12:48:08');
INSERT INTO `manufactured` VALUES ('132', '2015-04-27', '514', '41891', '114983', '15', '10', '0', '0', '0', '0', '0', '95', '90', '65', '250', '2015-04-28 12:48:59');
INSERT INTO `manufactured` VALUES ('133', '2015-04-24', '516', '41891', '115141', '15', '11', '0', '90', '0', '70', '0', '0', '0', '0', '160', '2015-04-28 12:49:29');
INSERT INTO `manufactured` VALUES ('134', '2015-04-25', '516', '41891', '115141', '15', '11', '0', '0', '90', '90', '0', '0', '0', '0', '180', '2015-04-28 12:49:53');
INSERT INTO `manufactured` VALUES ('135', '2015-04-27', '516', '41891', '115141', '15', '11', '0', '90', '90', '0', '0', '0', '0', '0', '180', '2015-04-28 12:50:17');
INSERT INTO `manufactured` VALUES ('136', '2015-04-25', '516', '40971', '115135', '7', '6', '22', '51', '16', '60', '30', '40', '11', '13', '243', '2015-04-28 12:51:05');
INSERT INTO `manufactured` VALUES ('137', '2015-04-27', '516', '40971', '115135', '7', '6', '0', '0', '60', '24', '38', '0', '10', '0', '132', '2015-04-28 12:51:29');
INSERT INTO `manufactured` VALUES ('138', '2015-04-28', '514', '40971', '114972', '7', '7', '0', '0', '0', '0', '0', '0', '0', '26', '26', '2015-04-30 16:31:41');
INSERT INTO `manufactured` VALUES ('139', '2015-04-28', '513', '40971', '114973', '8', '7', '31', '81', '90', '0', '0', '0', '0', '0', '202', '2015-04-30 16:33:39');
INSERT INTO `manufactured` VALUES ('140', '2015-04-29', '513', '40971', '114973', '8', '7', '0', '0', '66', '170', '0', '0', '0', '0', '236', '2015-04-30 16:42:32');
INSERT INTO `manufactured` VALUES ('141', '2015-04-28', '513', '41578', '114772', '8', '8', '0', '0', '0', '0', '72', '70', '18', '0', '160', '2015-04-30 16:43:00');
INSERT INTO `manufactured` VALUES ('142', '2015-04-29', '513', '41578', '114772', '8', '8', '0', '0', '0', '0', '0', '30', '0', '50', '80', '2015-04-30 16:43:32');
INSERT INTO `manufactured` VALUES ('143', '2015-04-29', '514', '49072', '114977', '5', '8', '10', '25', '20', '0', '0', '0', '0', '0', '55', '2015-04-30 16:46:01');
INSERT INTO `manufactured` VALUES ('144', '2015-04-28', '510', '41598', '114381', '8', '9', '0', '0', '0', '0', '0', '0', '0', '22', '22', '2015-04-30 16:46:23');
INSERT INTO `manufactured` VALUES ('145', '2015-04-28', '514', '41598', '114382', '8', '9', '0', '92', '64', '0', '0', '0', '0', '0', '156', '2015-04-30 16:51:06');
INSERT INTO `manufactured` VALUES ('146', '2015-04-29', '514', '41598', '114382', '8', '9', '0', '0', '60', '124', '0', '0', '0', '0', '184', '2015-04-30 16:51:30');
INSERT INTO `manufactured` VALUES ('147', '2015-04-28', '514', '41891', '114983', '15', '10', '0', '0', '0', '0', '0', '0', '0', '146', '146', '2015-04-30 16:52:03');
INSERT INTO `manufactured` VALUES ('148', '2015-04-30', '513', '40971', '114973', '8', '7', '0', '0', '0', '56', '161', '0', '0', '0', '217', '2015-05-06 14:42:21');
INSERT INTO `manufactured` VALUES ('149', '2015-05-04', '513', '40971', '114973', '8', '7', '0', '0', '0', '0', '0', '80', '41', '26', '147', '2015-05-06 14:42:47');
INSERT INTO `manufactured` VALUES ('150', '2015-05-04', '514', '40971', '114972', '7', '7', '0', '0', '0', '0', '0', '86', '0', '0', '86', '2015-05-06 14:43:43');
INSERT INTO `manufactured` VALUES ('151', '2015-05-05', '514', '40971', '114972', '7', '7', '0', '0', '0', '0', '0', '0', '71', '0', '71', '2015-05-06 14:44:00');
INSERT INTO `manufactured` VALUES ('152', '2015-05-05', '514', '40970', '114974', '7', '7', '38', '79', '50', '0', '0', '0', '0', '0', '167', '2015-05-06 14:47:14');
INSERT INTO `manufactured` VALUES ('153', '2015-04-30', '514', '49072', '114977', '5', '8', '0', '0', '21', '47', '42', '27', '14', '5', '156', '2015-05-06 14:48:56');
INSERT INTO `manufactured` VALUES ('154', '2015-04-30', '514', '49070', '114976', '5', '8', '17', '42', '65', '0', '0', '0', '0', '0', '124', '2015-05-06 14:54:27');
INSERT INTO `manufactured` VALUES ('155', '2015-05-04', '514', '49070', '114976', '5', '8', '0', '0', '0', '81', '76', '46', '10', '0', '213', '2015-05-06 14:55:09');
INSERT INTO `manufactured` VALUES ('156', '2015-05-05', '514', '49070', '114976', '5', '8', '0', '0', '0', '0', '0', '0', '20', '8', '28', '2015-05-06 14:55:33');
INSERT INTO `manufactured` VALUES ('157', '2015-05-04', '514', '40830', '114978', '1', '8', '26', '80', '0', '0', '0', '0', '0', '0', '106', '2015-05-06 14:58:17');
INSERT INTO `manufactured` VALUES ('158', '2015-05-05', '514', '40830', '114978', '1', '8', '0', '0', '111', '144', '0', '0', '0', '0', '255', '2015-05-06 14:58:54');
INSERT INTO `manufactured` VALUES ('159', '2015-04-30', '514', '41598', '114382', '8', '9', '0', '0', '0', '30', '70', '0', '0', '0', '100', '2015-05-06 15:02:07');
INSERT INTO `manufactured` VALUES ('160', '2015-05-04', '514', '41598', '114382', '8', '9', '0', '0', '60', '30', '70', '20', '0', '0', '180', '2015-05-06 15:02:37');
INSERT INTO `manufactured` VALUES ('161', '2015-05-05', '514', '41598', '114382', '8', '9', '0', '0', '0', '0', '86', '74', '0', '0', '160', '2015-05-06 15:02:54');
INSERT INTO `manufactured` VALUES ('162', '2015-05-04', '514', '41050', '114979', '11', '10', '4', '17', '27', '43', '44', '32', '21', '8', '196', '2015-05-06 15:03:27');
INSERT INTO `manufactured` VALUES ('163', '2015-05-05', '514', '41060', '114981', '11', '10', '4', '21', '47', '0', '0', '0', '0', '0', '72', '2015-05-06 15:03:47');
INSERT INTO `manufactured` VALUES ('164', '2015-04-28', '516', '41891', '115141', '15', '11', '0', '33', '90', '90', '0', '0', '0', '0', '213', '2015-05-06 15:06:23');
INSERT INTO `manufactured` VALUES ('165', '2015-04-29', '516', '41891', '115141', '15', '11', '0', '0', '46', '90', '64', '0', '0', '0', '200', '2015-05-06 15:06:48');
INSERT INTO `manufactured` VALUES ('166', '2015-04-30', '516', '41891', '115141', '15', '11', '0', '0', '0', '90', '90', '50', '0', '0', '230', '2015-05-06 15:07:09');
INSERT INTO `manufactured` VALUES ('167', '2015-05-04', '516', '41891', '115141', '15', '11', '0', '0', '0', '90', '90', '20', '0', '0', '200', '2015-05-06 15:07:30');
INSERT INTO `manufactured` VALUES ('168', '2015-05-05', '516', '41891', '115141', '15', '11', '0', '0', '0', '90', '40', '70', '0', '0', '200', '2015-05-06 15:07:53');
INSERT INTO `manufactured` VALUES ('169', '2015-04-29', '513', '41588', '114777', '8', '5', '8', '23', '46', '75', '88', '76', '53', '31', '400', '2015-05-06 15:21:34');
INSERT INTO `manufactured` VALUES ('170', '2015-05-04', '513', '41588', '114775', '9', '5', '0', '0', '42', '43', '84', '90', '0', '0', '259', '2015-05-06 15:45:03');
INSERT INTO `manufactured` VALUES ('171', '2015-05-05', '513', '41588', '114775', '9', '5', '0', '0', '0', '40', '40', '34', '83', '42', '239', '2015-05-06 15:45:52');
INSERT INTO `manufactured` VALUES ('172', '2015-05-06', '514', '40970', '114974', '7', '7', '0', '0', '77', '156', '0', '0', '0', '0', '233', '2015-05-08 11:43:40');
INSERT INTO `manufactured` VALUES ('173', '2015-05-07', '514', '40970', '114974', '7', '7', '0', '0', '0', '0', '122', '72', '38', '28', '260', '2015-05-08 11:44:06');
INSERT INTO `manufactured` VALUES ('174', '2015-05-06', '514', '40830', '114978', '1', '8', '0', '0', '0', '0', '116', '51', '19', '9', '195', '2015-05-08 11:44:35');
INSERT INTO `manufactured` VALUES ('175', '2015-05-06', '517', '40830', '115324', '1', '8', '20', '38', '63', '0', '0', '0', '0', '0', '121', '2015-05-08 11:47:49');
INSERT INTO `manufactured` VALUES ('176', '2015-05-07', '517', '40830', '115324', '1', '8', '0', '0', '0', '74', '57', '37', '20', '8', '196', '2015-05-08 11:48:09');
INSERT INTO `manufactured` VALUES ('177', '2015-05-06', '510', '41598', '114381', '8', '9', '0', '0', '0', '0', '0', '0', '0', '30', '30', '2015-05-08 11:48:28');
INSERT INTO `manufactured` VALUES ('178', '2015-05-06', '514', '41598', '114382', '8', '9', '0', '0', '0', '0', '30', '10', '92', '0', '132', '2015-05-08 11:48:54');
INSERT INTO `manufactured` VALUES ('179', '2015-05-07', '514', '41598', '114382', '8', '9', '0', '0', '0', '0', '20', '80', '0', '72', '172', '2015-05-08 11:55:27');
INSERT INTO `manufactured` VALUES ('180', '2015-05-06', '514', '41060', '114981', '11', '10', '0', '0', '0', '75', '84', '66', '41', '16', '282', '2015-05-08 11:55:57');
INSERT INTO `manufactured` VALUES ('181', '2015-05-07', '517', '41060', '115327', '11', '10', '0', '15', '42', '100', '60', '0', '0', '0', '217', '2015-05-08 11:59:42');
INSERT INTO `manufactured` VALUES ('182', '2015-05-06', '516', '41891', '115141', '15', '11', '0', '0', '0', '60', '50', '90', '0', '0', '200', '2015-05-08 12:30:00');
INSERT INTO `manufactured` VALUES ('183', '2015-05-07', '516', '41891', '115141', '15', '11', '0', '0', '0', '30', '90', '90', '0', '0', '210', '2015-05-08 12:30:22');
INSERT INTO `manufactured` VALUES ('184', '2015-05-06', '513', '41588', '114778', '8', '5', '5', '7', '67', '50', '0', '0', '0', '0', '129', '2015-05-08 12:36:24');
INSERT INTO `manufactured` VALUES ('185', '2015-05-07', '513', '41588', '114778', '8', '5', '0', '0', '0', '50', '70', '0', '0', '0', '120', '2015-05-08 12:36:40');
INSERT INTO `manufactured` VALUES ('186', '2015-05-08', '513', '40971', '114973', '8', '7', '0', '0', '0', '0', '0', '6', '30', '0', '36', '2015-05-09 11:23:08');
INSERT INTO `manufactured` VALUES ('187', '2015-04-30', '511', '40971', '114571', '7', '7', '0', '0', '0', '0', '0', '12', '0', '0', '12', '2015-05-09 11:43:34');
INSERT INTO `manufactured` VALUES ('188', '2015-04-30', '513', '47660', '114768', '12', '7', '0', '0', '0', '0', '0', '0', '50', '0', '50', '2015-05-09 11:44:02');
INSERT INTO `manufactured` VALUES ('189', '2015-05-08', '516', '47230', '115140', '4', '7', '80', '80', '60', '0', '0', '0', '0', '0', '220', '2015-05-09 11:49:03');
INSERT INTO `manufactured` VALUES ('190', '2015-05-08', '517', '41891', '115329', '15', '8', '0', '90', '0', '0', '0', '0', '0', '0', '90', '2015-05-09 11:49:34');
INSERT INTO `manufactured` VALUES ('191', '2015-05-08', '514', '41578', '114579', '8', '9', '0', '14', '66', '50', '0', '0', '0', '0', '130', '2015-05-09 11:50:03');
INSERT INTO `manufactured` VALUES ('192', '2015-05-08', '517', '41060', '115327', '11', '10', '0', '0', '0', '30', '70', '118', '0', '0', '218', '2015-05-09 11:50:35');
INSERT INTO `manufactured` VALUES ('193', '2015-05-08', '516', '41891', '115141', '15', '11', '0', '0', '0', '84', '90', '40', '0', '0', '214', '2015-05-09 11:55:31');
INSERT INTO `manufactured` VALUES ('194', '2015-05-08', '513', '41588', '114778', '8', '5', '0', '0', '0', '0', '107', '0', '0', '0', '107', '2015-05-09 11:55:53');
INSERT INTO `manufactured` VALUES ('195', '2015-05-09', '516', '47230', '115140', '4', '7', '74', '80', '100', '0', '0', '0', '0', '0', '254', '2015-05-11 12:48:54');
INSERT INTO `manufactured` VALUES ('196', '2015-05-09', '517', '41891', '115329', '15', '8', '0', '0', '90', '90', '0', '0', '0', '0', '180', '2015-05-11 12:49:45');
INSERT INTO `manufactured` VALUES ('197', '2015-05-09', '514', '41578', '114579', '8', '9', '0', '0', '0', '70', '90', '0', '0', '0', '160', '2015-05-11 12:51:00');
INSERT INTO `manufactured` VALUES ('198', '2015-05-09', '517', '41060', '115327', '11', '10', '0', '0', '0', '0', '0', '0', '58', '29', '87', '2015-05-11 12:51:30');
INSERT INTO `manufactured` VALUES ('199', '2015-05-09', '514', '41060', '114982', '12', '10', '4', '18', '55', '0', '0', '0', '0', '0', '77', '2015-05-11 13:17:00');
INSERT INTO `manufactured` VALUES ('200', '2015-05-09', '516', '41891', '115141', '15', '11', '0', '0', '0', '0', '0', '150', '70', '0', '220', '2015-05-11 12:56:18');
INSERT INTO `manufactured` VALUES ('201', '2015-05-09', '513', '41588', '114778', '8', '5', '0', '0', '0', '0', '10', '133', '0', '22', '165', '2015-05-11 13:10:50');
INSERT INTO `manufactured` VALUES ('202', '2015-05-11', '516', '47230', '115140', '4', '7', '0', '80', '80', '80', '0', '0', '0', '0', '240', '2015-05-12 14:13:33');
INSERT INTO `manufactured` VALUES ('203', '2015-05-11', '517', '41891', '115329', '15', '8', '0', '90', '90', '50', '0', '0', '0', '0', '230', '2015-05-12 14:13:54');
INSERT INTO `manufactured` VALUES ('204', '2015-05-11', '514', '41598', '114382', '8', '9', '0', '0', '0', '0', '0', '0', '0', '20', '20', '2015-05-12 14:14:15');
INSERT INTO `manufactured` VALUES ('205', '2015-05-11', '514', '41578', '114579', '8', '9', '0', '0', '0', '0', '73', '76', '0', '0', '149', '2015-05-12 14:14:34');
INSERT INTO `manufactured` VALUES ('206', '2015-05-11', '514', '41060', '114982', '12', '10', '0', '0', '0', '90', '97', '50', '0', '0', '237', '2015-05-12 14:15:09');
INSERT INTO `manufactured` VALUES ('207', '2015-05-11', '516', '41891', '115141', '15', '11', '0', '0', '0', '0', '130', '0', '20', '73', '223', '2015-05-12 14:15:30');
INSERT INTO `manufactured` VALUES ('208', '2015-05-11', '513', '41588', '114778', '8', '5', '0', '0', '0', '30', '0', '40', '90', '40', '200', '2015-05-12 14:15:49');
INSERT INTO `manufactured` VALUES ('209', '2015-05-12', '516', '47230', '115140', '4', '7', '0', '40', '120', '80', '48', '0', '0', '0', '288', '2015-05-13 13:24:13');
INSERT INTO `manufactured` VALUES ('210', '2015-05-12', '517', '41891', '115329', '15', '8', '0', '90', '90', '40', '0', '0', '0', '0', '220', '2015-05-13 13:24:44');
INSERT INTO `manufactured` VALUES ('211', '2015-05-12', '514', '41578', '114579', '8', '9', '0', '0', '0', '0', '0', '80', '107', '0', '187', '2015-05-13 13:25:19');
INSERT INTO `manufactured` VALUES ('212', '2015-05-12', '514', '41060', '114982', '12', '10', '0', '0', '0', '0', '0', '36', '51', '29', '116', '2015-05-13 13:25:42');
INSERT INTO `manufactured` VALUES ('213', '2015-05-12', '517', '41060', '115326', '11', '10', '0', '15', '42', '50', '0', '0', '0', '0', '107', '2015-05-13 13:31:04');
INSERT INTO `manufactured` VALUES ('214', '2015-05-12', '513', '41588', '114778', '8', '5', '0', '0', '0', '0', '0', '10', '35', '0', '45', '2015-05-13 13:38:28');
INSERT INTO `manufactured` VALUES ('215', '2015-05-12', '513', '41588', '114774', '8', '5', '0', '0', '0', '0', '0', '0', '10', '42', '52', '2015-05-13 13:44:08');
INSERT INTO `manufactured` VALUES ('216', '2015-05-12', '516', '41891', '115141', '15', '11', '0', '0', '0', '0', '50', '50', '90', '0', '190', '2015-05-13 13:47:14');
INSERT INTO `manufactured` VALUES ('217', '2015-05-13', '516', '47230', '115140', '4', '7', '0', '0', '131', '80', '80', '0', '0', '0', '291', '2015-05-14 13:11:18');
INSERT INTO `manufactured` VALUES ('218', '2015-05-13', '517', '41891', '115329', '15', '8', '0', '50', '90', '90', '0', '0', '0', '0', '230', '2015-05-14 13:11:47');
INSERT INTO `manufactured` VALUES ('219', '2015-05-13', '514', '41578', '114579', '8', '9', '0', '0', '0', '0', '0', '0', '0', '50', '50', '2015-05-14 13:12:15');
INSERT INTO `manufactured` VALUES ('220', '2015-05-13', '518', '41593', '115661', '9', '9', '0', '0', '37', '37', '50', '0', '0', '0', '124', '2015-05-14 13:15:53');
INSERT INTO `manufactured` VALUES ('221', '2015-05-13', '517', '41060', '115326', '11', '10', '0', '0', '0', '80', '130', '0', '0', '0', '210', '2015-05-14 13:16:24');
INSERT INTO `manufactured` VALUES ('222', '2015-05-13', '516', '41891', '115141', '15', '11', '0', '0', '0', '0', '60', '130', '0', '0', '190', '2015-05-14 13:17:36');
INSERT INTO `manufactured` VALUES ('223', '2015-05-13', '513', '41588', '114774', '8', '5', '0', '0', '0', '50', '104', '40', '73', '0', '267', '2015-05-14 13:20:45');
INSERT INTO `manufactured` VALUES ('224', '2015-05-14', '516', '47230', '115140', '4', '7', '0', '0', '0', '160', '150', '0', '0', '0', '310', '2015-05-15 10:35:16');
INSERT INTO `manufactured` VALUES ('225', '2015-05-14', '517', '41891', '115329', '15', '8', '0', '0', '41', '150', '40', '0', '0', '0', '231', '2015-05-15 10:35:51');
INSERT INTO `manufactured` VALUES ('226', '2015-05-14', '518', '41593', '115661', '9', '9', '0', '0', '0', '0', '23', '73', '0', '0', '96', '2015-05-15 10:36:27');
INSERT INTO `manufactured` VALUES ('227', '2015-05-14', '517', '41060', '115326', '11', '10', '0', '0', '0', '0', '0', '118', '58', '29', '205', '2015-05-15 10:36:55');
INSERT INTO `manufactured` VALUES ('228', '2015-05-14', '516', '41891', '115141', '15', '11', '0', '0', '0', '0', '30', '0', '160', '0', '190', '2015-05-15 10:37:34');
INSERT INTO `manufactured` VALUES ('229', '2015-05-14', '513', '41588', '114774', '8', '5', '0', '0', '42', '33', '20', '84', '0', '0', '179', '2015-05-15 10:37:59');
INSERT INTO `manufactured` VALUES ('230', '2015-05-15', '516', '47230', '115140', '4', '7', '0', '0', '0', '80', '80', '140', '0', '0', '300', '2015-05-18 13:25:24');
INSERT INTO `manufactured` VALUES ('231', '2015-05-15', '517', '41891', '115329', '15', '8', '0', '0', '0', '100', '90', '50', '0', '0', '240', '2015-05-18 13:25:46');
INSERT INTO `manufactured` VALUES ('232', '2015-05-15', '518', '41593', '115660', '9', '9', '0', '37', '42', '53', '0', '0', '0', '0', '132', '2015-05-18 13:28:42');
INSERT INTO `manufactured` VALUES ('233', '2015-05-15', '517', '41070', '115325', '11', '10', '3', '10', '29', '47', '57', '0', '0', '0', '146', '2015-05-18 13:31:11');
INSERT INTO `manufactured` VALUES ('234', '2015-05-15', '516', '41891', '115141', '15', '11', '0', '0', '0', '0', '20', '0', '46', '40', '106', '2015-05-18 13:31:51');
INSERT INTO `manufactured` VALUES ('235', '2015-05-15', '518', '41891', '115659', '15', '11', '0', '0', '90', '0', '0', '0', '0', '0', '90', '2015-05-18 13:34:44');
INSERT INTO `manufactured` VALUES ('236', '2015-05-15', '513', '41588', '114776', '8', '5', '0', '0', '0', '0', '0', '60', '90', '56', '206', '2015-05-18 13:39:46');
INSERT INTO `manufactured` VALUES ('237', '2015-05-20', '518', '41021', '115657', '8', '6', '0', '0', '3', '0', '0', '10', '0', '0', '13', '2015-05-27 13:35:28');
INSERT INTO `manufactured` VALUES ('238', '2015-05-21', '518', '41021', '115657', '8', '6', '0', '0', '10', '10', '56', '30', '29', '8', '143', '2015-05-27 13:35:28');
INSERT INTO `manufactured` VALUES ('239', '2015-05-22', '518', '41021', '115657', '8', '6', '0', '12', '10', '41', '10', '10', '10', '14', '107', '2015-05-27 13:35:28');
INSERT INTO `manufactured` VALUES ('240', '2015-05-25', '518', '41021', '115657', '8', '6', '0', '0', '13', '0', '10', '10', '0', '6', '39', '2015-05-27 13:35:28');
INSERT INTO `manufactured` VALUES ('241', '2015-05-22', '520', '41022', '116184', '11', '6', '0', '48', '0', '3', '0', '0', '0', '0', '51', '2015-05-27 12:59:34');
INSERT INTO `manufactured` VALUES ('242', '2015-05-25', '520', '41022', '116184', '11', '6', '0', '10', '40', '10', '0', '0', '0', '0', '60', '2015-05-27 13:00:04');
INSERT INTO `manufactured` VALUES ('243', '2015-05-26', '520', '41022', '116184', '11', '6', '0', '111', '70', '70', '0', '0', '0', '0', '251', '2015-05-27 13:00:24');
INSERT INTO `manufactured` VALUES ('244', '2015-05-21', '513', '41585', '114770', '8', '5', '0', '37', '58', '50', '0', '0', '0', '42', '187', '2015-05-27 13:03:47');
INSERT INTO `manufactured` VALUES ('245', '2015-05-22', '513', '41585', '114770', '8', '5', '0', '10', '30', '30', '34', '0', '18', '0', '122', '2015-05-27 13:04:27');
INSERT INTO `manufactured` VALUES ('246', '2015-05-25', '513', '41585', '114770', '8', '5', '0', '0', '0', '44', '16', '0', '60', '0', '120', '2015-05-27 13:15:07');
INSERT INTO `manufactured` VALUES ('247', '2015-05-26', '513', '41585', '114770', '8', '5', '0', '0', '0', '0', '84', '109', '0', '0', '193', '2015-05-27 13:19:51');
INSERT INTO `manufactured` VALUES ('248', '2015-05-26', '513', '41585', '114771', '8', '5', '0', '10', '40', '0', '0', '0', '0', '0', '50', '2015-05-27 13:27:37');
INSERT INTO `manufactured` VALUES ('249', '2015-05-27', '513', '41585', '114771', '8', '5', '0', '57', '60', '80', '80', '0', '0', '0', '277', '2015-05-28 16:41:24');
INSERT INTO `manufactured` VALUES ('250', '2015-05-27', '520', '41022', '116184', '11', '6', '0', '0', '50', '40', '70', '20', '0', '0', '180', '2015-05-28 16:42:05');

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
-- Table structure for tablename
-- ----------------------------
DROP TABLE IF EXISTS `tablename`;
CREATE TABLE `tablename` (
  `product` char(10) DEFAULT NULL,
  `quantity` int(10) DEFAULT NULL,
  `something` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tablename
-- ----------------------------
INSERT INTO `tablename` VALUES ('abc', '5', '2');
INSERT INTO `tablename` VALUES ('xzy', '5', '2');
INSERT INTO `tablename` VALUES ('asd', '10', '2');

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
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8;

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
INSERT INTO `versions` VALUES ('27', '1500/011', '2015-04-03 15:21:43');
INSERT INTO `versions` VALUES ('28', '7604/011', '2015-04-03 15:22:31');
INSERT INTO `versions` VALUES ('29', '3551/015', '2015-04-03 15:23:18');
INSERT INTO `versions` VALUES ('30', '3552/003', '2015-04-03 15:23:57');
INSERT INTO `versions` VALUES ('31', '7618/33', '2015-04-09 14:23:44');
INSERT INTO `versions` VALUES ('32', '7604/048', '2015-04-09 14:24:22');
INSERT INTO `versions` VALUES ('33', '3474/017', '2015-04-09 14:36:24');
INSERT INTO `versions` VALUES ('34', '2293/017', '2015-04-11 13:59:46');
INSERT INTO `versions` VALUES ('35', '3500/41', '2015-04-23 13:08:14');
INSERT INTO `versions` VALUES ('36', '3500/47', '2015-04-23 13:08:26');
INSERT INTO `versions` VALUES ('37', '3474/047', '2015-04-23 13:09:30');
INSERT INTO `versions` VALUES ('38', '291/017', '2015-04-23 13:09:57');
INSERT INTO `versions` VALUES ('39', '1540/011', '2015-05-06 13:53:09');
INSERT INTO `versions` VALUES ('40', '3552/003', '2015-05-06 13:53:29');
INSERT INTO `versions` VALUES ('41', '11341/009', '2015-05-06 13:53:43');
INSERT INTO `versions` VALUES ('42', '11344/018', '2015-05-06 13:53:57');
INSERT INTO `versions` VALUES ('43', '3503/047', '2015-05-06 14:25:39');
INSERT INTO `versions` VALUES ('44', '11344/018', '2015-05-06 14:26:36');
INSERT INTO `versions` VALUES ('45', '11341/0109', '2015-05-06 14:27:09');

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
  CONSTRAINT `fk_bu` FOREIGN KEY (`Bu_ID`) REFERENCES `bu` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Foundo` FOREIGN KEY (`Foundo_ID`) REFERENCES `foundo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Lavoration` FOREIGN KEY (`Lavoratione_ID`) REFERENCES `lavoratione` (`Lavoratoine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_linia` FOREIGN KEY (`Linia_ID`) REFERENCES `linia` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Versions` FOREIGN KEY (`Versions_ID`) REFERENCES `versions` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `worck_ibfk_1` FOREIGN KEY (`Article_ID`) REFERENCES `article` (`ArticleNo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of worck
-- ----------------------------
INSERT INTO `worck` VALUES ('1', '511', '40971', '114569', '16', '7', '1', '583', '0', '0', '0', '0', '0', '0', '0', '583', '2015-04-03 15:45:00');
INSERT INTO `worck` VALUES ('2', '511', '40971', '114570', '15', '7', '1', '382', '0', '0', '0', '0', '0', '0', '0', '382', '2015-04-03 15:45:07');
INSERT INTO `worck` VALUES ('3', '511', '40971', '114571', '11', '7', '1', '257', '0', '0', '0', '0', '0', '0', '0', '257', '2015-04-03 15:45:13');
INSERT INTO `worck` VALUES ('4', '511', '40970', '114572', '9', '7', '1', '216', '0', '0', '0', '0', '0', '0', '0', '216', '2015-04-03 15:45:20');
INSERT INTO `worck` VALUES ('5', '511', '40970', '114573', '17', '7', '1', '486', '0', '0', '0', '0', '0', '0', '0', '486', '2015-04-03 15:45:30');
INSERT INTO `worck` VALUES ('6', '511', '40834', '114574', '14', '1', '1', '727', '0', '0', '0', '0', '0', '0', '0', '727', '2015-04-03 15:45:25');
INSERT INTO `worck` VALUES ('7', '511', '40834', '114575', '18', '1', '5', '0', '0', '42', '83', '124', '124', '83', '42', '498', '2015-05-06 15:23:21');
INSERT INTO `worck` VALUES ('8', '511', '40790', '114576', '2', '1', '1', '631', '0', '0', '0', '0', '0', '0', '0', '631', '2015-04-03 15:45:45');
INSERT INTO `worck` VALUES ('9', '511', '40770', '114577', '2', '1', '1', '333', '0', '0', '0', '0', '0', '0', '0', '333', '2015-04-03 15:45:50');
INSERT INTO `worck` VALUES ('10', '511', '40780', '114578', '2', '1', '1', '831', '0', '0', '0', '0', '0', '0', '0', '831', '2015-04-03 15:45:54');
INSERT INTO `worck` VALUES ('11', '511', '41598', '114579', '19', '8', '1', '0', '14', '66', '120', '163', '156', '107', '50', '676', '2015-05-09 11:12:27');
INSERT INTO `worck` VALUES ('12', '510', '40783', '114378', '2', '1', '1', '4536', '0', '0', '0', '0', '0', '0', '0', '4536', '2015-04-03 15:46:04');
INSERT INTO `worck` VALUES ('13', '510', '41060', '114379', '13', '11', '1', '399', '0', '0', '0', '0', '0', '0', '0', '399', '2015-04-03 15:46:04');
INSERT INTO `worck` VALUES ('14', '510', '41060', '114380', '12', '11', '1', '281', '0', '0', '0', '0', '0', '0', '0', '281', '2015-04-03 15:46:14');
INSERT INTO `worck` VALUES ('15', '510', '41598', '114381', '20', '8', '1', '1104', '0', '0', '0', '0', '0', '0', '0', '1104', '2015-04-03 15:46:21');
INSERT INTO `worck` VALUES ('16', '510', '41598', '114382', '21', '8', '9', '0', '92', '184', '184', '276', '184', '92', '92', '1104', '2015-04-30 16:47:53');
INSERT INTO `worck` VALUES ('17', '513', '47660', '114768', '10', '12', '1', '519', '0', '0', '0', '0', '0', '0', '0', '519', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('18', '513', '47662', '114769', '22', '12', '1', '1240', '0', '0', '0', '0', '0', '0', '0', '1240', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('19', '513', '41585', '114770', '23', '8', '5', '0', '47', '88', '124', '134', '109', '78', '42', '622', '2015-05-27 12:35:51');
INSERT INTO `worck` VALUES ('20', '513', '41585', '114771', '24', '8', '5', '0', '67', '119', '186', '191', '150', '104', '52', '869', '2015-05-27 12:36:52');
INSERT INTO `worck` VALUES ('21', '513', '41578', '114772', '23', '8', '8', '5', '9', '56', '107', '152', '146', '98', '50', '623', '2015-04-28 12:44:22');
INSERT INTO `worck` VALUES ('22', '513', '41578', '114773', '24', '8', '1', '611', '0', '0', '0', '0', '0', '0', '0', '611', '2015-04-03 15:46:41');
INSERT INTO `worck` VALUES ('23', '513', '41588', '114774', '25', '8', '5', '0', '0', '42', '83', '124', '124', '83', '42', '498', '2015-05-13 13:33:32');
INSERT INTO `worck` VALUES ('24', '513', '41588', '114775', '24', '9', '5', '0', '0', '42', '83', '124', '124', '83', '42', '498', '2015-05-06 15:27:49');
INSERT INTO `worck` VALUES ('25', '513', '41588', '114776', '25', '8', '5', '5', '21', '95', '154', '194', '174', '110', '66', '819', '2015-05-18 13:36:52');
INSERT INTO `worck` VALUES ('26', '513', '41588', '114777', '24', '8', '5', '8', '23', '46', '75', '88', '76', '53', '31', '400', '2015-05-06 15:22:38');
INSERT INTO `worck` VALUES ('27', '513', '41588', '114778', '24', '8', '5', '766', '0', '0', '0', '0', '0', '0', '0', '766', '2015-05-08 12:35:02');
INSERT INTO `worck` VALUES ('28', '507', '47231', '114230', '9', '4', '1', '416', '0', '0', '0', '0', '0', '0', '0', '416', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('29', '507', '47236', '114231', '11', '4', '1', '673', '0', '0', '0', '0', '0', '0', '0', '673', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('31', '507', '47230', '114233', '17', '4', '1', '1002', '0', '0', '0', '0', '0', '0', '0', '1002', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('32', '507', '40830', '114234', '27', '1', '1', '375', '0', '0', '0', '0', '0', '0', '0', '375', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('33', '507', '47380', '114235', '28', '13', '1', '602', '0', '0', '0', '0', '0', '0', '0', '602', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('34', '507', '47381', '114236', '18', '13', '1', '447', '0', '0', '0', '0', '0', '0', '0', '447', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('35', '507', '47382', '114237', '14', '13', '1', '601', '0', '0', '0', '0', '0', '0', '0', '601', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('36', '507', '41598', '114238', '29', '8', '9', '7', '24', '42', '63', '64', '46', '24', '15', '285', '2015-04-11 09:34:32');
INSERT INTO `worck` VALUES ('37', '507', '41598', '114239', '19', '8', '1', '440', '0', '0', '0', '0', '0', '0', '0', '440', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('38', '507', '41598', '114240', '30', '8', '1', '631', '0', '0', '0', '0', '0', '0', '0', '631', '2015-04-03 15:47:06');
INSERT INTO `worck` VALUES ('39', '514', '49080', '114969', '2', '14', '1', '572', '0', '0', '0', '0', '0', '0', '0', '572', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('40', '514', '49083', '114970', '18', '14', '1', '436', '0', '0', '0', '0', '0', '0', '0', '436', '2015-05-27 12:35:15');
INSERT INTO `worck` VALUES ('41', '514', '49084', '114971', '15', '14', '7', '27', '50', '78', '88', '78', '49', '32', '14', '416', '2015-04-23 11:19:16');
INSERT INTO `worck` VALUES ('42', '514', '40971', '114972', '31', '7', '7', '31', '81', '156', '226', '161', '86', '71', '26', '838', '2015-04-28 12:40:11');
INSERT INTO `worck` VALUES ('43', '514', '40971', '114973', '32', '7', '1', '838', '0', '0', '0', '0', '0', '0', '0', '838', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('44', '514', '40970', '114974', '17', '7', '7', '38', '79', '127', '156', '122', '72', '38', '28', '660', '2015-05-06 14:45:42');
INSERT INTO `worck` VALUES ('45', '514', '40770', '114975', '2', '1', '11', '0', '134', '268', '402', '402', '196', '134', '73', '1609', '2015-04-10 10:16:18');
INSERT INTO `worck` VALUES ('46', '514', '49070', '114976', '27', '5', '5', '17', '42', '65', '81', '76', '46', '30', '8', '365', '2015-05-18 13:39:26');
INSERT INTO `worck` VALUES ('47', '514', '49072', '114977', '18', '5', '8', '10', '25', '41', '47', '42', '27', '14', '5', '211', '2015-04-30 16:44:49');
INSERT INTO `worck` VALUES ('48', '514', '40830', '114978', '27', '1', '8', '26', '80', '111', '144', '116', '51', '19', '9', '556', '2015-05-06 14:56:42');
INSERT INTO `worck` VALUES ('49', '514', '41050', '114979', '12', '11', '1', '4', '17', '27', '43', '44', '32', '21', '8', '196', '2015-05-06 14:37:45');
INSERT INTO `worck` VALUES ('50', '514', '41050', '114980', '13', '11', '1', '443', '0', '0', '0', '0', '0', '0', '0', '443', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('51', '514', '41060', '114981', '13', '11', '1', '4', '21', '47', '75', '84', '66', '41', '16', '354', '2015-05-06 14:38:15');
INSERT INTO `worck` VALUES ('52', '514', '41060', '114982', '12', '11', '10', '4', '18', '55', '90', '97', '86', '51', '29', '430', '2015-05-11 12:53:35');
INSERT INTO `worck` VALUES ('53', '514', '41891', '114983', '33', '15', '10', '0', '267', '336', '665', '665', '665', '336', '266', '3200', '2015-04-11 09:39:24');
INSERT INTO `worck` VALUES ('54', '516', '40971', '115134', '16', '7', '1', '281', '0', '0', '0', '0', '0', '0', '0', '281', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('55', '516', '40971', '115135', '15', '7', '6', '375', '0', '0', '0', '0', '0', '0', '0', '375', '2015-04-23 11:33:00');
INSERT INTO `worck` VALUES ('56', '516', '40770', '115136', '2', '1', '1', '770', '0', '0', '0', '0', '0', '0', '0', '770', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('57', '516', '40780', '115137', '34', '1', '1', '426', '0', '0', '0', '0', '0', '0', '0', '426', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('58', '516', '40780', '115138', '2', '1', '1', '638', '0', '0', '0', '0', '0', '0', '0', '638', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('59', '516', '47662', '115139', '22', '12', '1', '1002', '0', '0', '0', '0', '0', '0', '0', '1002', '2015-04-09 15:55:03');
INSERT INTO `worck` VALUES ('60', '516', '47230', '115140', '17', '4', '7', '154', '280', '491', '569', '468', '293', '157', '64', '2476', '2015-05-09 11:01:22');
INSERT INTO `worck` VALUES ('61', '516', '41891', '115141', '33', '15', '11', '3830', '0', '0', '0', '0', '0', '0', '0', '3830', '2015-04-23 11:24:40');
INSERT INTO `worck` VALUES ('62', '517', '47233', '115320', '16', '4', '1', '1858', '0', '0', '0', '0', '0', '0', '0', '1858', '2015-04-23 13:04:03');
INSERT INTO `worck` VALUES ('63', '517', '47231', '115321', '9', '4', '1', '1343', '0', '0', '0', '0', '0', '0', '0', '1343', '2015-04-23 13:04:03');
INSERT INTO `worck` VALUES ('64', '517', '49060', '115322', '2', '5', '1', '467', '0', '0', '0', '0', '0', '0', '0', '467', '2015-04-23 13:04:03');
INSERT INTO `worck` VALUES ('65', '517', '49061', '115323', '38', '5', '1', '262', '0', '0', '0', '0', '0', '0', '0', '262', '2015-04-23 13:04:03');
INSERT INTO `worck` VALUES ('66', '517', '41070', '115325', '12', '11', '10', '3', '10', '29', '47', '57', '50', '30', '13', '239', '2015-05-18 13:29:55');
INSERT INTO `worck` VALUES ('67', '517', '40830', '115324', '27', '1', '1', '317', '0', '0', '0', '0', '0', '0', '0', '317', '2015-04-23 13:04:03');
INSERT INTO `worck` VALUES ('68', '517', '41060', '115326', '35', '11', '10', '0', '15', '42', '130', '130', '118', '58', '29', '522', '2015-05-13 13:27:29');
INSERT INTO `worck` VALUES ('69', '517', '41060', '115327', '36', '11', '10', '522', '0', '0', '0', '0', '0', '0', '0', '522', '2015-05-08 11:57:19');
INSERT INTO `worck` VALUES ('70', '517', '47660', '115328', '12', '12', '1', '1240', '0', '0', '0', '0', '0', '0', '0', '1240', '2015-04-23 13:04:03');
INSERT INTO `worck` VALUES ('71', '517', '41891', '115329', '37', '15', '8', '0', '320', '401', '796', '795', '531', '320', '137', '3300', '2015-05-09 11:08:50');
INSERT INTO `worck` VALUES ('72', '518', '41071', '115655', '14', '11', '1', '217', '0', '0', '0', '0', '0', '0', '0', '217', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('73', '518', '41080', '115656', '13', '11', '1', '446', '0', '0', '0', '0', '0', '0', '0', '446', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('74', '518', '41021', '115657', '39', '11', '6', '0', '12', '36', '51', '76', '60', '39', '28', '302', '2015-05-27 11:54:31');
INSERT INTO `worck` VALUES ('75', '518', '41022', '115658', '39', '11', '6', '0', '42', '83', '124', '124', '124', '83', '42', '622', '2015-05-27 11:54:48');
INSERT INTO `worck` VALUES ('76', '518', '41891', '115659', '33', '15', '11', '0', '214', '280', '555', '555', '555', '280', '214', '2653', '2015-05-18 13:32:50');
INSERT INTO `worck` VALUES ('77', '518', '41593', '115660', '40', '9', '9', '0', '37', '42', '83', '83', '47', '42', '0', '334', '2015-05-18 13:26:45');
INSERT INTO `worck` VALUES ('78', '518', '41593', '115661', '19', '9', '9', '0', '0', '37', '137', '73', '73', '37', '37', '394', '2015-05-14 13:14:05');
INSERT INTO `worck` VALUES ('79', '518', '47651', '115664', '41', '12', '1', '673', '0', '0', '0', '0', '0', '0', '0', '673', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('80', '518', '47650', '115663', '42', '12', '1', '1002', '0', '0', '0', '0', '0', '0', '0', '1002', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('81', '518', '47650', '115662', '42', '12', '1', '1035', '0', '0', '0', '0', '0', '0', '0', '1035', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('82', '518', '47661', '115665', '42', '12', '1', '416', '0', '0', '0', '0', '0', '0', '0', '416', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('83', '518', '47662', '115666', '22', '12', '1', '2271', '0', '0', '0', '0', '0', '0', '0', '2271', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('84', '519', '47236', '115866', '11', '4', '1', '1033', '0', '0', '0', '0', '0', '0', '0', '1033', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('85', '519', '47235', '115867', '14', '4', '1', '725', '0', '0', '0', '0', '0', '0', '0', '725', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('86', '519', '41050', '115868', '43', '11', '1', '442', '0', '0', '0', '0', '0', '0', '0', '442', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('87', '519', '41050', '115869', '35', '11', '1', '487', '0', '0', '0', '0', '0', '0', '0', '487', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('88', '519', '47650', '115870', '44', '12', '1', '829', '0', '0', '0', '0', '0', '0', '0', '829', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('89', '519', '47651', '115871', '45', '12', '1', '467', '0', '0', '0', '0', '0', '0', '0', '467', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('90', '519', '41891', '115872', '33', '15', '1', '3146', '0', '0', '0', '0', '0', '0', '0', '3146', '2015-05-06 14:55:03');
INSERT INTO `worck` VALUES ('91', '520', '41022', '116184', '39', '11', '6', '0', '169', '169', '338', '338', '338', '169', '169', '1690', '2015-05-27 12:00:50');
