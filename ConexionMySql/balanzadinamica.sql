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

 Date: 30/10/2020 10:05:10
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for contadora
-- ----------------------------
DROP TABLE IF EXISTS `contadora`;
CREATE TABLE `contadora`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `peso` double(255, 2) NULL DEFAULT NULL,
  `fecha` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `fecha_creacion` timestamp(0) NOT NULL DEFAULT current_timestamp,
  `fecha_actualizacion` timestamp(0) NOT NULL DEFAULT current_timestamp ON UPDATE CURRENT_TIMESTAMP(0),
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
