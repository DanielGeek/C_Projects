/*
 Navicat Premium Data Transfer

 Source Server         : local
 Source Server Type    : MySQL
 Source Server Version : 100410
 Source Host           : localhost:3306
 Source Schema         : balanzadinamica

 Target Server Type    : MySQL
 Target Server Version : 100410
 File Encoding         : 65001

 Date: 29/10/2020 18:05:30
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for contadora
-- ----------------------------
DROP TABLE IF EXISTS `contadora`;
CREATE TABLE `contadora`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `peso` double(255, 0) NULL DEFAULT NULL,
  `fecha` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `fecha_creacion` timestamp(0) NOT NULL DEFAULT current_timestamp,
  `fecha_actualizacion` timestamp(0) NOT NULL DEFAULT current_timestamp ON UPDATE CURRENT_TIMESTAMP(0),
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of contadora
-- ----------------------------
INSERT INTO `contadora` VALUES (1, 0, '1', '2020-10-29 17:17:26', '2020-10-29 17:17:26');
INSERT INTO `contadora` VALUES (2, 0, '29-10-2020 17:23:29', '2020-10-29 17:23:34', '2020-10-29 17:23:34');
INSERT INTO `contadora` VALUES (3, 0, '29-10-2020 18:02:25', '2020-10-29 18:02:31', '2020-10-29 18:02:31');
INSERT INTO `contadora` VALUES (4, 0, '29-10-2020 18:02:44', '2020-10-29 18:02:49', '2020-10-29 18:02:49');

SET FOREIGN_KEY_CHECKS = 1;
