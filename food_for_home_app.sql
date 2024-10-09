CREATE DATABASE  IF NOT EXISTS `food_for_home` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `food_for_home`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: food_for_home
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Table structure for table `benutzer`
--

DROP TABLE IF EXISTS `benutzer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `benutzer` (
  `BENUTZER_ID` int NOT NULL AUTO_INCREMENT,
  `BENUTZER_NAME` varchar(255) DEFAULT NULL,
  `PASSWORT` varchar(255) DEFAULT NULL,
  `Titel` enum('user','Admin') DEFAULT NULL,
  PRIMARY KEY (`BENUTZER_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `benutzer`
--

LOCK TABLES `benutzer` WRITE;
/*!40000 ALTER TABLE `benutzer` DISABLE KEYS */;
INSERT INTO `benutzer` VALUES (1,'Paul','Aubin1234.','user'),(2,'Paul','Aubin1234.','user'),(3,'Marie','Marie1234.','user'),(4,'Mathews','Mathews1234.','user'),(5,'Franc','Franc1234.','Admin'),(6,'Cassius','cassius1234.','Admin');
/*!40000 ALTER TABLE `benutzer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rezept`
--

DROP TABLE IF EXISTS `rezept`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rezept` (
  `REZEPT_ID` int NOT NULL AUTO_INCREMENT,
  `REZEPT_NAME` varchar(255) DEFAULT NULL,
  `ANWEISUNGEN` text,
  `PORTIONEN` int DEFAULT NULL,
  `NAERWERTE` text,
  `REZEPT_TYPE` enum('DRINK','FOOD') DEFAULT NULL,
  `DIETARY_PREFERENCE` enum('VEGAN','VEGETARIAN','MEALS WITH MEAT') DEFAULT NULL,
  `image_description` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`REZEPT_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rezept`
--

LOCK TABLES `rezept` WRITE;
/*!40000 ALTER TABLE `rezept` DISABLE KEYS */;
INSERT INTO `rezept` VALUES (1,'Strawberry Smoothie','1. Combine all ingredients in a blender.\n2. Blend until smooth.\n3. Serve immediately.',2,'Calories: 200, Carbs: 40g, Protein: 5g, Fat: 2g','DRINK','VEGAN','https://tse1.mm.bing.net/th?id=OIP.VyXZ-gKsLDIXFS4748QeBQHaKG&pid=Api'),(2,'Avocado Smoothie','1. Cut the avocado in half, remove the pit, and scoop the flesh into a blender.\n2. Peel the banana and add it to the blender.\n3. Pour in the almond milk.\n4. Add the honey and vanilla extract.\n5. Blend until smooth.\n6. Serve immediately.',2,'Calories: 250, Carbs: 30g, Protein: 5g, Fat: 15g','DRINK','VEGAN','https://www.gutekueche.at/storage/media/recipe/15483/resp/avocado-smoothie___webp_639_426.webp'),(3,'Beetroot Power Smoothie','1. Peel and chop the beetroot into small pieces.\n2. Add the beetroot, almond milk, honey, and ginger to a blender.\n3. Blend until smooth.\n4. Serve immediately.',2,'Calories: 180, Carbs: 35g, Protein: 4g, Fat: 2g','DRINK','VEGAN','https://tse1.mm.bing.net/th?id=OIP.bKze5ZmqliTrmTM8LawJIwHaHa&pid=Api'),(4,'Caesar Salad','1. Wash and chop the romaine lettuce.\n2. In a large bowl, combine the lettuce, Caesar dressing, croutons, and Parmesan cheese.\n3. Add a squeeze of lemon juice, minced garlic, and a drizzle of olive oil.\n4. Toss the salad to mix all ingredients.\n5. Season with black pepper to taste.\n6. Serve immediately.',4,'Calories: 250, Carbs: 15g, Protein: 7g, Fat: 18g','FOOD','MEALS WITH MEAT','https://www.eatbetter.de/sites/eatbetter.de/files/styles/700_530/public/2020-04/knackiger_caesar_salad_mit_erfrischendem_joghurt_dressing_62493.jpg?h=4521fff0&itok=W-7qkWC0'),(5,'Chicken Tandoori','1. In a large bowl, mix yogurt, lemon juice, minced garlic, grated ginger, and all the spices to make the marinade.\n2. Make small cuts in the chicken drumsticks and coat them with the marinade.\n3. Let the chicken marinate in the refrigerator for at least 4 hours, preferably overnight.\n4. Preheat the oven to 200°C (400°F).\n5. Place the marinated chicken on a baking tray and drizzle with olive oil.\n6. Bake the chicken for 25-30 minutes, or until fully cooked, turning halfway through.\n7. Serve hot with lemon wedges and a side salad.',4,'Calories: 300, Carbs: 5g, Protein: 25g, Fat: 20g','FOOD','MEALS WITH MEAT','https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Tandoori_chicken_laccha_piyaz1_%2836886283595%29.jpg/220px-Tandoori_chicken_laccha_piyaz1_%2836886283595%29.jpg'),(6,'Egyptian Falafel','1. Soak the dried fava beans in water overnight.\n2. Drain the beans and blend them with onion, garlic, parsley, and cilantro until smooth.\n3. Add cumin, coriander, baking powder, salt, and black pepper to the mixture and blend again.\n4. Shape the mixture into small balls or patties and coat them with sesame seeds.\n5. Heat vegetable oil in a deep pan.\n6. Fry the falafel balls until golden brown and crispy.\n7. Serve hot with tahini sauce or in a pita bread with vegetables.',4,'Calories: 200, Carbs: 25g, Protein: 10g, Fat: 10g','FOOD','VEGAN','https://tse1.mm.bing.net/th?id=OIP.Sx02ZGls_vNcLlqlevdO1QHaHa&pid=Api'),(7,'Egyptian Koshary','1. Cook the rice and lentils separately.\n2. Cook the macaroni according to the package instructions.\n3. In a pan, sauté garlic and cumin in oil, then add tomato sauce and vinegar. Simmer for 15 minutes.\n4. Layer the rice, lentils, macaroni, and chickpeas in a dish.\n5. Pour the tomato sauce over the top.\n6. Garnish with fried onions and serve hot.',4,'Calories: 350, Carbs: 60g, Protein: 15g, Fat: 5g','FOOD','VEGAN','https://tse2.mm.bing.net/th?id=OIP.VEM8pweKerueBZGyH9aorgHaFj&pid=Api'),(8,'Egyptian Mamp Kofta','1. In a bowl, mix ground beef, minced onion, minced garlic, chopped parsley, and all spices.\n2. Shape the mixture into long sausages around skewers.\n3. Brush with olive oil.\n4. Grill the kofta until fully cooked, turning occasionally.\n5. Serve hot with pita bread and tahini sauce.',4,'Calories: 350, Carbs: 5g, Protein: 25g, Fat: 25g','FOOD','MEALS WITH MEAT','https://tse3.mm.bing.net/th?id=OIP.9vG-grs2fTXzW7Fl3YpRfQHaE8&pid=Api'),(9,'Egyptian Stuffed Eggplant','1. Cut the eggplants in half and scoop out the flesh.\n2. Sauté minced onion and garlic in olive oil, then add ground beef and cook until browned.\n3. Add tomato sauce, chopped parsley, cinnamon, nutmeg, salt, and black pepper to the beef mixture. Cook for 10 minutes.\n4. Stuff the eggplant halves with the beef mixture.\n5. Place the stuffed eggplants in a baking dish and bake at 180°C (350°F) for 30 minutes.\n6. Serve hot, garnished with fresh parsley.',4,'Calories: 300, Carbs: 15g, Protein: 20g, Fat: 18g','FOOD','MEALS WITH MEAT','https://images.eatsmarter.com/sites/default/files/styles/1024x768/public/egyptian-stuffed-eggplants-590592.jpg'),(10,'Grilled Goat Cheese Salad','1. Wash and dry the mixed greens.\n2. Slice cherry tomatoes, cucumber, and red onion.\n3. Grill the goat cheese slices until soft and slightly charred.\n4. In a large bowl, combine the mixed greens, cherry tomatoes, cucumber, red onion, and walnuts.\n5. In a small bowl, whisk together balsamic vinegar, olive oil, honey, salt, and black pepper to make the dressing.\n6. Drizzle the dressing over the salad and toss to combine.\n7. Top with grilled goat cheese slices and serve immediately.',2,'Calories: 350, Carbs: 15g, Protein: 12g, Fat: 28g','FOOD','VEGETARIAN','https://tse2.mm.bing.net/th?id=OIP.KDgrpMXQHS-1m574B25vgQHaE8&pid=Api'),(11,'Hibiscus Tea','1. Bring water to a boil in a pot.\n2. Add dried hibiscus flowers to the boiling water and simmer for 10 minutes.\n3. Strain the tea to remove the hibiscus flowers.\n4. Stir in sugar and lemon juice until dissolved.\n5. Let the tea cool and refrigerate.\n6. Serve chilled, garnished with mint leaves.',4,'Calories: 80, Carbs: 20g, Protein: 0g, Fat: 0g','DRINK','VEGAN','https://tse3.mm.bing.net/th?id=OIP.6imuegK21WLcJwsQ6XVVywHaHa&pid=Api'),(12,'Iced Coffee','1. Brew a strong pot of coffee.\n2. Let the coffee cool to room temperature.\n3. Fill a glass with ice cubes.\n4. Pour the cooled coffee over the ice.\n5. Add milk and sugar if desired.\n6. Stir well and serve immediately.',2,'Calories: 5, Carbs: 0g, Protein: 0g, Fat: 0g','DRINK','VEGAN','https://tse4.mm.bing.net/th?id=OIP.2m86YwVZYHm4kb2zXVO19AHaKy&pid=Api'),(13,'Kalmi Kebab Mughlai','1. In a bowl, mix yogurt, minced garlic, grated ginger, garam masala, cumin, coriander, turmeric, lemon juice, salt, and black pepper to make a marinade.\n2. Coat the chicken drumsticks with the marinade and let them marinate in the refrigerator for at least 4 hours, preferably overnight.\n3. Preheat the oven to 200°C (400°F).\n4. Place the marinated chicken on a baking tray and brush with ghee.\n5. Bake the chicken for 25-30 minutes, or until fully cooked, turning halfway through.\n6. Serve hot with lemon wedges and a side salad.',4,'Calories: 300, Carbs: 5g, Protein: 25g, Fat: 20g','FOOD','MEALS WITH MEAT','https://tse1.mm.bing.net/th?id=OIP.LTCBvr_FJIi10iVHdbzcXAHaHA&pid=Api'),(14,'Mushroom Salad','1. Clean and slice the mushrooms.\n2. In a pan, sauté mushrooms with minced garlic in olive oil until tender.\n3. Wash and dry the mixed greens.\n4. Slice cherry tomatoes and red onion.\n5. In a large bowl, combine the mixed greens, cherry tomatoes, red onion, and sautéed mushrooms.\n6. In a small bowl, whisk together olive oil, lemon juice, salt, and black pepper to make the dressing.\n7. Drizzle the dressing over the salad and toss to combine.\n8. Serve immediately.',2,'Calories: 150, Carbs: 10g, Protein: 3g, Fat: 12g','FOOD','VEGAN','https://tse4.mm.bing.net/th?id=OIP.wxpKdWDwcAXt6Z3FJHYslwHaLH&pid=Api'),(15,'Panang Curry Thai','1. Heat olive oil in a pan and add the Panang curry paste. Cook for 2 minutes.\n2. Add sliced chicken breast and cook until browned.\n3. Pour in coconut milk and bring to a simmer.\n4. Add fish sauce, sugar, and kaffir lime leaves.\n5. Add sliced red bell pepper and cook until tender.\n6. Stir in basil leaves and cook for another minute.\n7. Serve hot with steamed rice.',4,'Calories: 400, Carbs: 10g, Protein: 30g, Fat: 25g','FOOD','MEALS WITH MEAT','https://tse4.mm.bing.net/th?id=OIP.kbmgBrZPtA-6sBJOb0mvGwHaLH&pid=Api'),(16,'Peruvian Octopus Ceviche','1. Cook the octopus in boiling water until tender, then cool and cut into bite-sized pieces.\n2. In a bowl, combine octopus, lime juice, sliced red onion, chopped cilantro, and minced aji amarillo.\n3. Add salt, black pepper, and a drizzle of olive oil.\n4. Toss to combine and let marinate for 20 minutes.\n5. Serve chilled.',4,'Calories: 150, Carbs: 5g, Protein: 20g, Fat: 5g','FOOD','MEALS WITH MEAT','https://tse3.mm.bing.net/th?id=OIP.cizGbeTiqf91CIjc-6t2gAAAAA&pid=Api'),(17,'Salmon Avocado Salad','1. Cook the salmon fillet and let it cool. Flake into pieces.\n2. Wash and dry the mixed greens.\n3. Slice the avocado, cherry tomatoes, cucumber, and red onion.\n4. In a large bowl, combine the mixed greens, avocado, cherry tomatoes, cucumber, and red onion.\n5. In a small bowl, whisk together olive oil, lemon juice, salt, and black pepper to make the dressing.\n6. Drizzle the dressing over the salad and toss to combine.\n7. Top with flaked salmon and serve immediately.',2,'Calories: 400, Carbs: 10g, Protein: 25g, Fat: 30g','FOOD','MEALS WITH MEAT','https://tse3.mm.bing.net/th?id=OIP.r9mvIlHXpnU5fuJ6SI7zKgHaLH&pid=Api'),(18,'Tofu and Veggie Filling','1. Press and cube the tofu.\n2. Heat olive oil in a pan and add minced garlic and grated ginger.\n3. Add cubed tofu and cook until browned.\n4. Add sliced bell peppers, carrots, and zucchini. Cook until tender.\n5. Add soy sauce, salt, and black pepper. Stir well.\n6. Serve hot as a filling for wraps or bowls.',4,'Calories: 200, Carbs: 15g, Protein: 10g, Fat: 10g','FOOD','VEGAN','https://tse2.mm.bing.net/th?id=OIP.zVkZ703dN-HJdcDy8ULjxAHaFj&pid=Api');
/*!40000 ALTER TABLE `rezept` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rezept_zutat`
--

DROP TABLE IF EXISTS `rezept_zutat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rezept_zutat` (
  `REZEPT_ID` int NOT NULL,
  `ZUTAT_ID` int NOT NULL,
  PRIMARY KEY (`REZEPT_ID`,`ZUTAT_ID`),
  KEY `ZUTAT_ID` (`ZUTAT_ID`),
  CONSTRAINT `rezept_zutat_ibfk_1` FOREIGN KEY (`REZEPT_ID`) REFERENCES `rezept` (`REZEPT_ID`),
  CONSTRAINT `rezept_zutat_ibfk_2` FOREIGN KEY (`ZUTAT_ID`) REFERENCES `zutat` (`ZUTAT_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rezept_zutat`
--

LOCK TABLES `rezept_zutat` WRITE;
/*!40000 ALTER TABLE `rezept_zutat` DISABLE KEYS */;
INSERT INTO `rezept_zutat` VALUES (1,1),(1,2),(2,2),(1,3),(2,3),(3,3),(1,4),(2,4),(2,5),(17,5),(2,6),(3,6),(10,6),(3,7),(3,10),(5,10),(13,10),(18,10),(4,11),(4,12),(4,13),(4,14),(4,15),(5,15),(11,15),(13,15),(14,15),(17,15),(4,16),(5,16),(6,16),(7,16),(8,16),(9,16),(13,16),(14,16),(18,16),(4,17),(5,17),(8,17),(9,17),(10,17),(14,17),(15,17),(16,17),(17,17),(18,17),(4,18),(6,18),(7,18),(8,18),(9,18),(10,18),(13,18),(14,18),(16,18),(17,18),(18,18),(5,19),(13,19),(5,20),(13,20),(5,24),(13,24),(5,25),(13,25),(5,26),(6,26),(7,26),(8,26),(13,26),(5,27),(8,27),(5,28),(5,29),(6,29),(7,29),(8,29),(9,29),(10,29),(13,29),(14,29),(16,29),(17,29),(18,29),(6,31),(6,32),(8,32),(9,32),(6,34),(8,34),(9,34),(6,35),(16,35),(6,37),(8,37),(13,37),(6,38),(6,41),(6,42),(7,43),(7,44),(7,45),(7,46),(7,47),(9,47),(7,50),(7,51),(8,54),(9,54),(9,64),(9,70),(9,71),(10,75),(14,75),(17,75),(10,76),(10,77),(14,77),(17,77),(10,78),(17,78),(10,79),(14,79),(16,79),(17,79),(10,80),(10,81),(11,86),(11,87),(12,87),(11,88),(12,88),(15,88),(11,90),(12,91),(12,93),(12,94),(13,107),(14,108),(15,117),(15,118),(15,119),(15,120),(15,122),(15,123),(15,124),(16,126),(16,127),(16,130),(17,134),(18,144),(18,145),(18,146),(18,147),(18,148);
/*!40000 ALTER TABLE `rezept_zutat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zutat`
--

DROP TABLE IF EXISTS `zutat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zutat` (
  `ZUTAT_ID` int NOT NULL AUTO_INCREMENT,
  `ZUTAT_NAME` varchar(255) DEFAULT NULL,
  `KALORIEN_PRO_100G` int DEFAULT NULL,
  `Kohlenhydrate` int DEFAULT NULL,
  `Proteine` int DEFAULT NULL,
  `Fette` int DEFAULT NULL,
  PRIMARY KEY (`ZUTAT_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=154 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zutat`
--

LOCK TABLES `zutat` WRITE;
/*!40000 ALTER TABLE `zutat` DISABLE KEYS */;
INSERT INTO `zutat` VALUES (1,'Strawberries',32,7,1,0),(2,'Banana',89,23,1,0),(3,'Almond Milk',17,1,0,1),(4,'Vanilla Extract',288,0,0,0),(5,'Avocado',160,9,2,15),(6,'Honey',304,82,0,0),(7,'Beetroot',43,10,2,0),(8,'Almond Milk',17,1,0,1),(9,'Honey',304,82,0,0),(10,'Ginger',80,18,2,1),(11,'Romaine Lettuce',17,3,1,0),(12,'Caesar Dressing',484,2,1,50),(13,'Croutons',407,68,9,13),(14,'Parmesan Cheese',431,4,38,29),(15,'Lemon Juice',22,6,1,0),(16,'Garlic',149,33,6,0),(17,'Olive Oil',884,0,0,100),(18,'Black Pepper',255,64,10,3),(19,'Chicken drumsticks',239,0,19,17),(20,'Yogurt',59,3,10,0),(21,'Lemon Juice',22,6,1,0),(22,'Garlic',149,33,6,0),(23,'Ginger',80,18,2,1),(24,'Garam masala',357,38,12,17),(25,'Turmeric',312,67,10,3),(26,'Cumin',375,44,18,22),(27,'Paprika',282,54,14,13),(28,'Red chili powder',282,54,12,14),(29,'Salt',0,0,0,0),(30,'Olive oil',884,0,0,100),(31,'Dried fava beans',341,58,26,1),(32,'Onion',40,9,1,0),(33,'Garlic',149,33,6,0),(34,'Parsley',36,6,3,0),(35,'Cilantro',23,4,2,0),(36,'Cumin',375,44,18,22),(37,'Coriander',298,55,12,17),(38,'Baking powder',53,28,0,0),(39,'Salt',0,0,0,0),(40,'Black pepper',255,64,10,3),(41,'Sesame seeds',573,23,18,50),(42,'Vegetable oil',884,0,0,100),(43,'Rice',130,28,2,0),(44,'Brown lentils',116,20,9,0),(45,'Macaroni',131,25,5,1),(46,'Chickpeas',164,27,9,3),(47,'Tomato sauce',29,6,1,0),(48,'Garlic',149,33,6,0),(49,'Cumin',375,44,18,22),(50,'Vinegar',22,0,0,0),(51,'Fried onions',410,34,5,30),(52,'Salt',0,0,0,0),(53,'Black pepper',255,64,10,3),(54,'Ground beef',250,0,20,20),(55,'Onion',40,9,1,0),(56,'Garlic',149,33,6,0),(57,'Parsley',36,6,3,0),(58,'Cumin',375,44,18,22),(59,'Coriander',298,55,12,17),(60,'Paprika',282,54,14,13),(61,'Salt',0,0,0,0),(62,'Black pepper',255,64,10,3),(63,'Olive oil',884,0,0,100),(64,'Eggplant',25,6,1,0),(65,'Ground beef',250,0,20,20),(66,'Onion',40,9,1,0),(67,'Garlic',149,33,6,0),(68,'Tomato sauce',29,6,1,0),(69,'Parsley',36,6,3,0),(70,'Cinnamon',247,81,4,1),(71,'Nutmeg',525,49,6,36),(72,'Salt',0,0,0,0),(73,'Black pepper',255,64,10,3),(74,'Olive oil',884,0,0,100),(75,'Mixed greens',20,3,2,0),(76,'Goat cheese',364,1,21,30),(77,'Cherry tomatoes',18,4,1,0),(78,'Cucumber',16,4,1,0),(79,'Red onion',40,9,1,0),(80,'Walnuts',654,14,15,65),(81,'Balsamic vinegar',88,17,0,0),(82,'Olive oil',884,0,0,100),(83,'Honey',304,82,0,0),(84,'Salt',0,0,0,0),(85,'Black pepper',255,64,10,3),(86,'Dried hibiscus flowers',0,0,0,0),(87,'Water',0,0,0,0),(88,'Sugar',387,100,0,0),(89,'Lemon juice',22,6,1,0),(90,'Mint leaves',44,8,3,1),(91,'Coffee',2,0,0,0),(92,'Water',0,0,0,0),(93,'Ice',0,0,0,0),(94,'Milk',42,5,3,1),(95,'Sugar',387,100,0,0),(96,'Chicken drumsticks',239,0,19,17),(97,'Yogurt',59,3,10,0),(98,'Garlic',149,33,6,0),(99,'Ginger',80,18,2,1),(100,'Garam masala',357,38,12,17),(101,'Cumin',375,44,18,22),(102,'Coriander',298,55,12,17),(103,'Turmeric',312,67,10,3),(104,'Lemon juice',22,6,1,0),(105,'Salt',0,0,0,0),(106,'Black pepper',255,64,10,3),(107,'Ghee',900,0,0,100),(108,'Mushrooms',22,3,3,0),(109,'Mixed greens',20,3,2,0),(110,'Cherry tomatoes',18,4,1,0),(111,'Red onion',40,9,1,0),(112,'Olive oil',884,0,0,100),(113,'Lemon juice',22,6,1,0),(114,'Garlic',149,33,6,0),(115,'Salt',0,0,0,0),(116,'Black pepper',255,64,10,3),(117,'Chicken breast',165,0,31,4),(118,'Panang curry paste',100,7,3,6),(119,'Coconut milk',230,6,2,24),(120,'Fish sauce',20,1,4,0),(121,'Sugar',387,100,0,0),(122,'Kaffir lime leaves',30,7,0,0),(123,'Red bell pepper',31,6,1,0),(124,'Basil leaves',23,2,3,0),(125,'Olive oil',884,0,0,100),(126,'Octopus',82,3,14,1),(127,'Lime juice',22,6,1,0),(128,'Red onion',40,9,1,0),(129,'Cilantro',23,4,2,0),(130,'Aji amarillo',40,9,1,0),(131,'Salt',0,0,0,0),(132,'Black pepper',255,64,10,3),(133,'Olive oil',884,0,0,100),(134,'Salmon fillet',208,0,20,13),(135,'Avocado',160,9,2,15),(136,'Mixed greens',20,3,2,0),(137,'Cherry tomatoes',18,4,1,0),(138,'Cucumber',16,4,1,0),(139,'Red onion',40,9,1,0),(140,'Olive oil',884,0,0,100),(141,'Lemon juice',22,6,1,0),(142,'Salt',0,0,0,0),(143,'Black pepper',255,64,10,3),(144,'Tofu',76,2,8,4),(145,'Bell peppers',31,6,1,0),(146,'Carrots',41,10,1,0),(147,'Zucchini',17,3,1,0),(148,'Soy sauce',53,4,8,0),(149,'Olive oil',884,0,0,100),(150,'Garlic',149,33,6,0),(151,'Ginger',80,18,2,1),(152,'Salt',0,0,0,0),(153,'Black pepper',255,64,10,3);
/*!40000 ALTER TABLE `zutat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'food_for_home'
--

--
-- Dumping routines for database 'food_for_home'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-09 23:38:26
