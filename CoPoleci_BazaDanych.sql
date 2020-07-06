-- MySQL dump 10.13  Distrib 5.5.21, for Win32 (x86)
--
-- Host: localhost    Database: copoleci
-- ------------------------------------------------------
-- Server version	5.5.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aktorzy`
--

DROP TABLE IF EXISTS `aktorzy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aktorzy` (
  `id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `imię_nazwisko` char(50) COLLATE utf8_unicode_ci NOT NULL,
  `urodzony` date NOT NULL,
  `zmarł` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=298 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aktorzy`
--

LOCK TABLES `aktorzy` WRITE;
/*!40000 ALTER TABLE `aktorzy` DISABLE KEYS */;
INSERT INTO `aktorzy` VALUES (1,'Adam Goldberg','1970-10-25',NULL),(2,'Adam Sandler','1966-09-09',NULL),(3,'Al Pacino','1940-04-25',NULL),(4,'Aleksandr Domogarow','1963-07-12',NULL),(5,'Alicia Vikander','1988-10-03',NULL),(6,'Allison Williams','1988-04-13',NULL),(7,'Amanda Seyfried','1985-12-03',NULL),(8,'Amanda Wyss','1960-11-24',NULL),(9,'Andie MacDowell','1958-04-21',NULL),(10,'Andrew Garfield','1983-08-20',NULL),(11,'Anjelica Huston','1951-07-08',NULL),(12,'Anna Faris','1976-11-29',NULL),(13,'Anne Hathaway','1982-11-12',NULL),(14,'Anne Le Ny','1962-12-16',NULL),(15,'Ansel Elgort','1994-03-14',NULL),(16,'Armie Hammer','1986-08-28',NULL),(17,'Ary Abittan','1974-01-31',NULL),(18,'Audrey Hepburn','1929-05-04','1993-01-20'),(19,'BD Wong','1960-10-24',NULL),(20,'Ben Kingsley','1943-12-31',NULL),(21,'Ben Stiller','1965-11-30',NULL),(22,'Benedict Cumberbatch','1976-07-19',NULL),(23,'Billy Crystal','1948-03-14',NULL),(24,'Bob Gunton','1945-11-15',NULL),(25,'Bożena Stryjkówna','1954-08-09',NULL),(26,'Brad Pitt','1963-12-18',NULL),(27,'Bradley Cooper','1975-01-05',NULL),(28,'Branko Durić','1962-05-28',NULL),(29,'Bryce Dallas Howard','1981-03-02',NULL),(30,'Cameron Diaz','1972-08-30',NULL),(31,'Carrie Fisher','1956-10-21','2016-12-27'),(32,'Carrie-Anne Moss','1967-08-21',NULL),(33,'Cary-Hiroyuki Tagawa','1950-09-27',NULL),(34,'Cate Blanchett','1969-05-14',NULL),(35,'Catherine Keener','1959-03-23',NULL),(36,'Chaim Topol','1935-09-09',NULL),(37,'Charles Chaplin','1889-04-16','1977-12-25'),(38,'Chris O\' Donnell','1970-06-26',NULL),(39,'Chris Pratt','1979-06-21',NULL),(40,'Christian Bale','1974-01-30',NULL),(41,'Christian Clavier','1952-05-06',NULL),(42,'Christopher Lloyd','1938-10-22',NULL),(43,'Clark Gable','1901-02-01','1960-11-16'),(44,'Colin Firth','1960-09-10',NULL),(45,'Dakota Fanning','1994-02-23',NULL),(46,'Daniah De Villiers','1995-06-21',NULL),(47,'Daniel Kaluuya','1989-02-24',NULL),(48,'Danny DeVito','1944-11-17',NULL),(49,'Danny Lloyd','1972-10-13',NULL),(50,'Dany Boon','1966-06-26',NULL),(51,'David Carradine','1936-12-08','2009-06-03'),(52,'David Kelly','1944-05-14','2003-07-17'),(53,'David Vert','1971-05-26',NULL),(54,'Debbie Reynolds','1932-04-01','2016-12-28'),(55,'Dee Wallace-Stone','1948-12-14',NULL),(56,'Demi Moore','1962-11-11',NULL),(57,'Dermot Mulroney','1963-10-31',NULL),(58,'Desmond Harrington','1976-10-19',NULL),(59,'Domhnall Gleeson','1983-05-12',NULL),(60,'Dominic Cooper','1978-06-02',NULL),(61,'Donald O\' Connor','1925-08-28','2003-09-27'),(62,'Donald Sutherland','1935-07-17',NULL),(63,'Drew Barrymore','1975-02-22',NULL),(64,'Ed Harris','1950-11-28',NULL),(65,'Ed Helms','1974-01-24',NULL),(66,'Ed Skrein','1983-03-29',NULL),(67,'Eddie Murphy','1961-04-03',NULL),(68,'Edna Purviance','1895-10-21','1958-01-11'),(69,'Edwart Norton','1969-08-18',NULL),(70,'Eileen Essell','1922-10-08','2015-02-15'),(71,'Elisabeth Moss','1982-07-24',NULL),(72,'Eliza Dushku','1980-12-30',NULL),(73,'Elizabeth Banks','1974-02-10',NULL),(74,'Ellen Page','1987-02-21',NULL),(75,'Emily Blunt','1983-02-23',NULL),(76,'Emma Stone','1988-11-06',NULL),(77,'Emma Thompson','1959-04-15',NULL),(78,'Emmanuelle Chriqui','1975-12-10',NULL),(79,'Eric Bana','1968-08-09',NULL),(80,'Ethan Hawke','1970-11-06',NULL),(81,'Eve Brent','1929-09-11','2011-08-27'),(82,'Ewa Kasprzyk','1957-01-01',NULL),(83,'Ewan McGregor','1971-03-31',NULL),(84,'Famke Janssen','1964-11-05',NULL),(85,'Faye Dunaway','1941-01-14',NULL),(86,'Ferrán Terraza','1969-02-14',NULL),(87,'Filip Sovagović','1966-09-13',NULL),(88,'Francois Cluzet','1955-09-21',NULL),(89,'Freddie Highmore','1992-02-14',NULL),(90,'Frederick Lau','1989-08-17',NULL),(91,'Gabrielle Anwar','1970-02-04',NULL),(92,'Gary Oldman','1958-03-21',NULL),(93,'Gary Sinise','1955-03-17',NULL),(94,'Gena Rowlands','1930-06-19',NULL),(95,'Gene Hackman','1930-01-30',NULL),(96,'Gene Kelly','1912-08-23','1996-02-02'),(97,'Geoffrey Rush','1951-07-06',NULL),(98,'George Clooney','1961-05-06',NULL),(99,'George Peppard','1928-10-01','1994-05-08'),(100,'Giorgio Cantarini','1992-04-12',NULL),(101,'Gloria Stuart','1910-07-04','2010-09-26'),(102,'Graham Chapman','1941-01-08','1989-10-04'),(103,'Grażyna Błęcka-Kolska','1962-02-16',NULL),(104,'Greg Kinnear','1963-06-17',NULL),(105,'Guy Pearce','1967-10-05',NULL),(106,'Gwyneth Paltrow','1972-09-27',NULL),(107,'Hank Azaria','1964-04-25',NULL),(108,'Harrison Ford','1942-07-13',NULL),(109,'Heather Langenkamp','1964-07-17',NULL),(110,'Helena Bonham Carter','1966-05-26',NULL),(111,'Henry Fonda','1905-05-16','1982-08-12'),(112,'Henry Thomas','1971-09-09',NULL),(113,'Hilarie Burton','1982-07-01',NULL),(114,'Hugh Grant','1960-09-09',NULL),(115,'Hugh Jackman','1968-10-12',NULL),(116,'Humphrey Bogart','1899-12-25','1957-01-14'),(117,'Ingrid Bergman','1915-08-29','1982-08-29'),(118,'Jack Nicholson','1937-04-22',NULL),(119,'Jackie Coogan','1914-10-26','1984-03-01'),(120,'Jacob Tremblay','2006-10-05',NULL),(121,'Jaeden Martell','2003-01-04',NULL),(122,'James Earl Jones','1931-01-17',NULL),(123,'James Garner','1928-04-07','2014-07-19'),(124,'James Russell','1983-09-03',NULL),(125,'Jean Reno','1948-07-30',NULL),(126,'Jennifer Aniston','1969-02-11',NULL),(127,'Jennifer Connelly','1970-12-12',NULL),(128,'Jennifer Jason Leigh','1962-02-05',NULL),(129,'Jeremy Irons','1948-09-19',NULL),(130,'Jeremy Ray Taylor','2003-06-02',NULL),(131,'Jeremy Suarez','1990-07-06',NULL),(132,'Jerzy Stuhr','1947-04-18',NULL),(133,'Jesse Eisenberg','1983-10-05',NULL),(134,'Jessica Chastain','1977-03-24',NULL),(135,'Jim Sturgess','1978-05-16',NULL),(136,'JK Simmons','1955-01-09',NULL),(137,'Joan Allen','1956-08-20',NULL),(138,'Joaquin Phoenix','1974-10-28',NULL),(139,'Joe Pantoliano','1951-09-12',NULL),(140,'Joe Pesci','1943-02-09',NULL),(141,'John Cleese','1939-10-27',NULL),(142,'John Legend','1978-12-28',NULL),(143,'John Travolta','1954-02-18',NULL),(144,'John Turturro','1957-02-28',NULL),(145,'Johnny Depp','1963-06-09',NULL),(146,'Jonas Jägermeyr','1983-08-13',NULL),(147,'Joseph Gordon-Levitt','1981-02-17',NULL),(148,'Josh Duhamel','1972-11-14',NULL),(149,'Josh Lucas','1971-06-20',NULL),(150,'Julia Roberts','1967-10-28',NULL),(151,'Julianne Moore','1960-12-03',NULL),(152,'Jürgen Vogel','1968-04-29',NULL),(153,'Justin Bartha','1978-07-21',NULL),(154,'Justin Timberlake','1981-01-31',NULL),(155,'Kad Merad','1964-03-27',NULL),(156,'Kang-ho Song','1967-01-17',NULL),(157,'Kate Hudson','1979-04-19',NULL),(158,'Kate Winslet','1975-10-05',NULL),(159,'Katherine Heigl','1978-11-24',NULL),(160,'Kathy Najimy','1957-02-06',NULL),(161,'Katie Featherston','1982-10-20',NULL),(162,'Keira Knightley','1985-03-26',NULL),(163,'Kevin Spacey','1959-07-26',NULL),(164,'Kim Hunter','1922-11-12','2002-09-11'),(165,'Kirstie Alley','1951-01-12',NULL),(166,'Kristin Scott Thomas','1960-05-24',NULL),(167,'Krzysztof Kowalewski','1937-03-20',NULL),(168,'Kurt Russell','1951-03-17',NULL),(169,'Langley Kirkwood','1973-04-14',NULL),(170,'Lauren Cohan','1982-01-07',NULL),(171,'Lee J Cobb','1911-12-08','1976-02-11'),(172,'Leonard Frey','1938-09-04','1988-08-24'),(173,'Leonardo DiCaprio','1974-11-11',NULL),(174,'Leslie Howard','1893-04-03','1943-06-01'),(175,'Liam Neeson','1952-06-07',NULL),(176,'Lili Taylor','1967-02-20',NULL),(177,'Lily James','1989-04-05',NULL),(178,'Lucy Liu','1968-12-02',NULL),(179,'Lucy Punch','1977-12-30',NULL),(180,'Lupita Nyong\'o','1983-03-01',NULL),(181,'Maggie Grace','1983-09-21',NULL),(182,'Maggie Smith','1934-12-28',NULL),(183,'Manuela Velasco','1975-10-23',NULL),(184,'Margot Robbie','1990-07-02',NULL),(185,'Maria Bello','1967-04-18',NULL),(186,'Mark Fredrichs','1948-10-03',NULL),(187,'Mark Hamill','1951-09-25',NULL),(188,'Mark Ruffalo','1967-11-22',NULL),(189,'Mark Strong','1963-08-05',NULL),(190,'Marlon Brando','1924-04-03','2004-07-01'),(191,'Martin Balsam','1919-11-04','1996-02-13'),(192,'Mary Steenburgen','1953-02-08',NULL),(193,'Mathieu Kassovitz','1967-08-03',NULL),(194,'Matthew Goode','1978-04-03',NULL),(195,'Matthew Macfadyen','1974-10-17',NULL),(196,'Matthew McConaughey','1969-11-04',NULL),(197,'Max Riemelt','1984-01-07',NULL),(198,'Meg Ryan','1961-11-19',NULL),(199,'Melanie Laurent','1983-02-21',NULL),(200,'Melissa Benoist','1988-10-04',NULL),(201,'Meryl Streep','1949-06-22',NULL),(202,'Mia Wasikowska','1989-10-25',NULL),(203,'Micah Sloat','1981-05-08',NULL),(204,'Michael Caine','1933-03-14',NULL),(205,'Michael Clarke Duncan','1957-12-10','2012-09-03'),(206,'Michael J. Pollard','1939-05-30','2019-11-20'),(207,'Michał Żebrowski','1972-06-17',NULL),(208,'Michelle Pfeiffer','1958-04-29',NULL),(209,'Mila Kunis','1983-08-14',NULL),(210,'Miles Teller','1987-02-20',NULL),(211,'Ming-Na','1963-11-20',NULL),(212,'Monica Potter','1971-06-30',NULL),(213,'Morena Baccarin','1979-06-02',NULL),(214,'Morgan Freeman','1937-06-01',NULL),(215,'Natalie Portman','1981-06-09',NULL),(216,'Nathan Lane','1956-02-03',NULL),(217,'Nicole Kidman','1967-06-20',NULL),(218,'Nicoletta Braschi','1960-04-19',NULL),(219,'Nikki Blonsky','1988-11-09',NULL),(220,'Nolan Gould','1998-10-28',NULL),(221,'Norma Crane','1928-11-10','1973-09-28'),(222,'Olgierd Łukaszewicz','1946-09-07',NULL),(223,'Olivia Newton-John','1948-09-26',NULL),(224,'Olympia Dukakis','1931-06-20',NULL),(225,'Omar Sy','1978-01-20',NULL),(226,'Orlando Bloom','1977-01-13',NULL),(227,'Oscar Isaac','1979-03-09',NULL),(228,'Owen Wilson','1968-11-18',NULL),(229,'Pascal N\'Zonzi','1951-01-01',NULL),(230,'Patricia Neal','1926-01-20','2010-08-08'),(231,'Patrick Swayze','1952-08-18','2009-09-14'),(232,'Patrick Wilson','1973-07-03',NULL),(233,'Paul Bettany','1971-05-27',NULL),(234,'Paul Henreid','1908-01-10','1992-03-29'),(235,'Philip Seymour Hoffman','1967-07-23','2014-02-02'),(236,'Pierce Brosnan','1953-05-16',NULL),(237,'Piotr Głowacki','1980-03-29',NULL),(238,'Ralph Bellamy','1904-06-17','1991-11-29'),(239,'Raul Julia','1940-03-09','1994-10-24'),(240,'Ray Liotta','1954-12-18',NULL),(241,'Rene Bitorajac','1972-03-02',NULL),(242,'Rhys Ifans','1967-07-22',NULL),(243,'Richard Gere','1949-08-31',NULL),(244,'Rick Moranis','1953-04-18',NULL),(245,'Robert De Niro','1943-08-17',NULL),(246,'Robert Downey Jr','1965-04-04',NULL),(247,'Robert Duvall','1931-01-05',NULL),(248,'Robert Sean','1969-02-28',NULL),(249,'Roberto Benigni','1952-10-27',NULL),(250,'Robin Williams','1951-07-21','2014-08-11'),(251,'Robin Wright Penn','1966-04-08',NULL),(252,'Romola Garai','1982-08-06',NULL),(253,'Ronee Blakley','1945-08-24',NULL),(254,'Rupert Evans','1977-03-30',NULL),(255,'Russell Crowe','1964-04-07',NULL),(256,'Ryan Gosling','1980-11-12',NULL),(257,'Ryan Reynolds','1976-10-23',NULL),(258,'Sacha Baron Cohen','1971-10-13',NULL),(259,'Sally Field','1946-11-06',NULL),(260,'Sam Worthington','1976-08-02',NULL),(261,'Samuel L Jackson','1948-12-21',NULL),(262,'Sandra Bullock','1964-07-26',NULL),(263,'Seon-gyun Lee','1975-03-02',NULL),(264,'Shelley Duvall','1949-07-07',NULL),(265,'Sigourney Weaver','1949-10-08',NULL),(266,'Sophia Lillis','2002-02-13',NULL),(267,'Steve Carell','1962-08-16',NULL),(268,'Steven Bauer','1956-12-02',NULL),(269,'Stockard Channing','1944-02-13',NULL),(270,'Susan Egan','1970-02-18',NULL),(271,'Szymon Piotr Warszawski','1988-09-24',NULL),(272,'Tamara De Treaux','1959-10-21','1990-11-28'),(273,'Tate Donovan','1963-09-25',NULL),(274,'Terrence Howard','1969-03-11',NULL),(275,'Terry Gilliam','1940-11-22',NULL),(276,'Tim Robbins','1958-10-16',NULL),(277,'Tom Hanks','1956-07-09',NULL),(278,'Tom Schilling','1982-02-10',NULL),(279,'Tomasz Kot','1977-04-21',NULL),(280,'Ulrich Mühe','1953-06-20','2007-07-22'),(281,'Ulrich Tukur','1957-07-29',NULL),(282,'Uma Thurman','1970-04-29',NULL),(283,'Vera Farmiga','1973-08-06',NULL),(284,'Viola Davis','1965-08-11',NULL),(285,'Vivien Leigh','1913-11-05','1967-07-08'),(286,'Wacław Kowalski','1916-05-02','1990-10-27'),(287,'Warren Beatty','1937-03-30',NULL),(288,'Whoopi Goldberg','1955-11-13',NULL),(289,'Winston Duke','1986-11-15',NULL),(290,'Władysław Hańcza','1905-05-18','1977-11-19'),(291,'Woody Harrelson','1961-07-23',NULL),(292,'Yeo-jeong Jo','1981-02-10',NULL),(293,'Zazie Beetz','1991-04-17',NULL),(294,'Zdzisław Karczewski','1903-03-22','1970-09-30'),(295,'Zdzisław Wardejn','1940-04-21',NULL),(296,'Zoe Felix','1976-05-07',NULL),(297,'Zoe Saldana','1978-06-19',NULL);
/*!40000 ALTER TABLE `aktorzy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `filmy`
--

DROP TABLE IF EXISTS `filmy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `filmy` (
  `id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `tytuł` char(50) COLLATE utf8_unicode_ci NOT NULL,
  `rok` smallint(6) NOT NULL,
  `gatunek` char(40) COLLATE utf8_unicode_ci NOT NULL,
  `zabawność` double NOT NULL,
  `realizm` double NOT NULL,
  `wzruszenie` double NOT NULL,
  `ambitność` double NOT NULL,
  `akcja` double NOT NULL,
  `romantyczność` double NOT NULL,
  `muzyka` double NOT NULL,
  `kryminalistyka` double NOT NULL,
  `strach` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=122 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `filmy`
--

LOCK TABLES `filmy` WRITE;
/*!40000 ALTER TABLE `filmy` DISABLE KEYS */;
INSERT INTO `filmy` VALUES (1,'Leon zawodowiec',1994,'kryminał',0.2,0.7,0.7,0.7,0.6,0.3,0.4,1,0.8),(2,'Siedem',1995,'kryminał',0.2,0.8,0.2,0.7,1,0.1,0.1,1,0.9),(3,'Skazani na Shawshank',1994,'dramat',0.2,0.8,0.7,0.6,1,0.1,0.2,0.3,0.5),(4,'Ojciec chrzestny',1972,'dramat',0.1,0.8,0.2,0.8,0.8,0.2,0.4,0.5,0.7),(5,'Król Lew',1994,'film animowany',0.8,0.1,0.8,0.3,0.5,0.4,0.8,0,0.1),(6,'Dyktator',2012,'komedia',0.6,0.4,0.4,0.7,0.2,0.3,0.6,0,0.3),(7,'Interstellar',2014,'Sci-Fi',0.1,0.3,0.8,1,0.8,0.2,0.1,0,0.5),(8,'Incepcja',2010,'thriller',0.1,0.3,0.2,1,1,0.1,0.1,0.6,0.6),(9,'Les Misérables Nędznicy',2012,'musical',0.1,0.6,1,0.1,0.4,0.7,1,0,0.5),(10,'Mamma Mia! Here We Go Again',2018,'musical',1,0.7,0.6,0.1,0.2,0.8,1,0,0.1),(11,'Zycie jest piękne',1997,'dramat',0.5,0.8,0.8,0.7,0.4,0.2,0.2,0,0.7),(12,'Podziemny krąg',1999,'thriller',0.2,0.3,0.2,0.6,0.7,0.3,0.1,0.2,0.7),(13,'Zielona mila',1999,'dramat',0.1,0.5,1,0.7,0.6,0.1,0.2,0.2,0.6),(14,'Forrest Gump',1994,'dramat',0.6,0.8,0.6,0.5,0.2,0.4,0.2,0.4,0.2),(15,'Chłopcy z ferajny',1990,'dramat',0.2,0.8,0.2,0.4,0.8,0.1,0.2,0.6,0.7),(16,'Pulp Fiction',1994,'film akcji',0.4,0.5,0.1,0.5,1,0.2,0.2,0.7,0.6),(17,'Sami swoi',1967,'komedia',1,1,0.1,0.2,0.1,0.1,0.1,0,0.1),(18,'Stowarzyszenie Umarłych Poetów',1989,'dramat',0.2,1,0.8,0.7,0.5,0.5,0.3,0,0.4),(19,'Skrzypek na dachu',1971,'dramat',0.3,0.7,0.6,0.6,0.2,0.4,1,0,0.3),(20,'Przeminęło z wiatrem',1939,'melodramat',0.2,0.8,0.7,0.6,0.5,0.9,0.2,0,0.5),(21,'Człowiek z blizną',1983,'dramat',0.2,0.8,0.2,0.4,0.6,0.1,0.1,0.7,0.7),(22,'I kto to mówi',1989,'familijny',1,0.8,0.4,0.1,0.1,0.4,0.1,0,0.1),(23,'Dwunastu gniewnych ludzi',1957,'dramat',0.2,1,0.2,0.8,0.1,0.1,0.1,0.3,0.2),(24,'Deszczowa piosenka',1952,'musical',0.7,0.7,0.1,0.1,0.1,0.6,1,0,0.1),(25,'Avatar',2009,'Sci-Fi',0.2,0.1,0.3,0.7,0.7,0.5,0.1,0.2,0.1),(26,'Piękny umysł',2001,'biograficzny',0.2,0.8,0.6,0.7,0.4,0.5,0.1,0,0.4),(27,'Amen',2002,'dramat',0.1,0.8,0.8,0.7,0.6,0.1,0.1,0.4,0.8),(28,'Troja',2004,'dramat',0.2,0.2,0.6,0.3,0.8,0.5,0.3,0,0.5),(29,'Żywot Briana',1979,'komedia',1,0.1,0.1,0.2,0.2,0.1,0.1,0,0.1),(30,'Duma i uprzedzenie',2005,'melodramat',0.2,0.8,0.2,0.3,0.1,0.8,0.2,0,0.1),(31,'Fabryka zła',2004,'dramat',0.1,0.8,0.8,0.7,0.6,0.1,0.1,0.2,0.7),(32,'Prestiż',2006,'thriller',0.2,0.3,0.7,1,0.8,0.3,0.1,0.5,0.5),(33,'Fala',2008,'dramat',0.2,0.8,0.7,0.7,0.8,0.1,0.1,0.2,0.5),(34,'The Social Network',2010,'biograficzny',0.2,1,0.1,0.5,0.1,0.1,0.1,0,0.1),(35,'Jak zostać królem',2010,'biograficzny',0.4,0.8,0.4,0.3,0.1,0.3,0.6,0,0.1),(36,'Służące',2011,'dramat',0.7,0.8,0.6,0.6,0.2,0.2,0.4,0,0.1),(37,'Gra tajemnic',2014,'biograficzny',0.2,0.8,0.1,0.7,0.4,0.3,0.2,0.1,0.2),(38,'Whiplash',2014,'dramat',0.2,1,0.6,0.6,0.5,0.1,1,0,0.2),(39,'Za jakie grzechy dobry Boże',2014,'komedia',1,0.7,0.1,0.1,0.2,0.4,0.1,0,0.1),(40,'Nienawistna ósemka',2015,'western',0.4,0.4,0.2,0.5,0.5,0.1,0.1,0.7,0.5),(41,'Big Short',2015,'dramat',0.3,0.8,0.1,0.7,0.4,0.1,0.1,0,0.1),(42,'Joker',2019,'dramat',0.2,0.2,0.6,1,0.7,0.1,0.4,0.2,0.5),(43,'Ogniem i mieczem',1999,'historyczny',0.2,0.8,0.7,0.6,0.7,0.6,0.5,0.1,0.3),(44,'Patch Adams',1998,'biograficzny',0.6,0.7,0.8,0.2,0.1,0.4,0.2,0,0.4),(45,'Titanic',1997,'melodramat',0.2,0.9,0.8,0.3,0.7,1,0.6,0,0.2),(46,'Zapach kobiety',1992,'dramat',0.2,0.7,0.2,0.5,0.5,0.4,0.5,0,0.2),(47,'Seksmisja',1983,'komedia',1,0.2,0.1,0.3,0.3,0.1,0.1,0.4,0.1),(48,'Kogel-mogel',1988,'komedia',0.9,1,0.2,0.1,0.2,0.7,0.3,0,0.1),(49,'ET',1982,'Sci-Fi',0.3,0.1,0.7,0.4,0.4,0.1,0.2,0,0.1),(50,'Śniadanie u Tiffany\'ego',1961,'melodramat',0.4,0.7,0.6,0.3,0.2,0.7,0.7,0,0.1),(51,'Bonnie i Clyde',1967,'dramat',0.3,1,0.4,0.4,0.9,0.7,0.2,0.7,0.6),(52,'Memento',2000,'thriller',0.1,0.3,0.2,1,0.8,0.1,0.2,0.5,0.7),(53,'Pani Doubtfire',1993,'dramat',0.9,0.6,0.4,0.1,0.1,0.2,0.1,0,0.1),(54,'Rodzina Addamsów',1991,'film animowany',0.9,0.1,0.2,0.1,0.3,0.3,0.5,0,0.2),(55,'Tramwaj zwany pożądaniem',1951,'dramat',0.2,0.8,0.4,0.7,0.5,0.6,0.2,0.1,0.4),(56,'Brzdąc',1921,'dramat',0.6,0.4,0.5,0.2,0.2,0.1,0.5,0,0.1),(57,'Ziemia niczyja',2001,'dramat',0.3,0.8,0.6,0.7,0.7,0.1,0.1,0.3,0.4),(58,'Kill Bill',2003,'thriller',0.4,0.3,0.2,0.7,0.9,0.3,0.3,0.7,0.6),(59,'Jak stracić chłopaka w 10 dni',2003,'komedia romantyczna',1,0.8,0.1,0.1,0.1,0.9,0.1,0,0.1),(60,'Mój brat niedzwiedź',2003,'film animowany',0.5,0.1,0.8,0.2,0.3,0.2,0.7,0,0.2),(61,'Diabeł ubiera się u Prady',2006,'komedia',0.4,0.7,0.4,0.2,0.2,0.2,0.1,0,0.1),(62,'Mamma Mia!',2008,'musical',1,0.7,0.1,0.1,0,0.9,1,0,0.1),(63,'Narzeczony mimo woli',2009,'komedia romantyczna',1,0.7,0.6,0.1,0.1,1,0.1,0,0.1),(64,'Jeszcze dalej niż Północ',2008,'komedia',1,0.8,0.6,0.5,0.1,0.5,0.1,0,0.1),(65,'Alicja w Krainie Czarów',2010,'film animowany',0.8,0.1,0.2,0.1,0.3,0.3,0.7,0,0.1),(66,'Kocha lubi szanuje',2011,'komedia',0.7,0.7,0.4,0.1,0.1,1,0.3,0,0.1),(67,'Grawitacja',2013,'Sci-Fi',0.2,0.6,0.7,0.7,0.4,0.2,0.4,0.2,0.5),(68,'Jeden dzień',2011,'melodramat',0.3,0.8,0.8,0.2,0.1,1,0.2,0,0.1),(69,'Nietykalni',2011,'biograficzny',1,0.8,0.8,0.5,0.1,0.2,0.2,0,0.1),(70,'Bogowie',2014,'biograficzny',0.2,1,0.5,0.5,0.3,0.1,0.1,0,0.4),(71,'La La Land',2016,'musical',0.6,0.5,0.7,0.1,0.3,1,1,0,0.1),(72,'Baby Driver',2017,'film akcji',0.3,0.7,0.5,0.3,0.8,0.7,0.7,0.8,0.6),(73,'Cudowny chłopak',2017,'dramat',0.6,0.7,0.6,0.2,0.3,0.4,0.1,0,0.1),(74,'Pewnego razu w Hollywood',2019,'dramat',0.4,0.4,0.2,0.5,0.7,0.3,0.2,0.7,0.6),(75,'Mia i biały lew',2018,'familijny',0.6,0.4,0.6,0.1,0.4,0.4,0.4,0,0.4),(76,'Mój chłopak się żeni',1997,'komedia romantyczna',0.9,0.7,0.6,0.1,0.1,0.8,0.4,0,0.1),(77,'Herkules',1997,'film animowany',0.8,0.1,0.2,0.2,0.4,0.5,0.8,0,0.1),(78,'Mulan',1998,'film animowany',0.8,0.2,0.2,0.2,0.3,0.3,0.7,0,0.1),(79,'Casablanca',1942,'kryminał',0.2,0.8,0.8,0.6,0.4,1,0.7,1,0.5),(80,'Pretty Woman',1990,'komedia romantyczna',0.6,0.8,0.5,0.1,0.4,0.9,0.4,0,0.1),(81,'Uwierz w ducha',1990,'dramat',0.6,0.3,0.6,0.1,0.1,0.9,0.4,0,0.2),(82,'Kiedy Harry poznał Sally',1989,'komedia romantyczna',0.7,0.8,0.4,0.1,0.1,0.9,0.1,0,0.1),(83,'Grease',1978,'musical',0.8,0.5,0.4,0.1,0.1,0.9,1,0,0.1),(84,'Klatka dla ptaków',1996,'komedia',0.8,0.6,0.6,0.4,0.2,0.5,0.3,0,0.1),(85,'Starsza pani musi zniknąć',2003,'komedia',0.8,0.6,0.2,0.2,0.5,0.2,0.1,0,0.4),(86,'Pamiętnik',2004,'melodramat',0.2,0.7,1,0.4,0.2,1,0.2,0,0.1),(87,'Sekretne okno',2004,'thriller',0.1,0.6,0.2,0.3,0.8,0.1,0.1,0.4,0.8),(88,'To właśnie miłość',2003,'komedia romantyczna',0.6,0.7,0.5,0.1,0.2,1,0.4,0,0.1),(89,'Charlie i fabryka czekolady',2005,'familijny',0.6,0.1,0.4,0.1,0.1,0.1,0.2,0,0.1),(90,'Sekretne życie pszczół',2008,'dramat',0.6,0.7,0.7,0.5,0.3,0.6,0.3,0,0.3),(91,'Lakier do włosów',2007,'musical',0.7,0.5,0.1,0.1,0.1,0.5,1,0,0.1),(92,'Uprowadzona',2008,'thriller',0.1,0.6,0.3,0.7,0.9,0.1,0.2,0.7,0.8),(93,'Mój przyjaciel Hachiko',2009,'dramat',0.3,0.8,0.9,0.4,0.3,0.2,0.2,0,0.1),(94,'Kac Vegas',2009,'komedia',1,0.5,0.1,0.1,0.5,0.3,0.1,0,0.2),(95,'Deadpool',2016,'film akcji',0.8,0.1,0.1,0.1,0.7,0.2,0.3,0.5,0.3),(96,'Zła kobieta',2011,'komedia',1,0.7,0.1,0.1,0.2,1,0.1,0,0.1),(97,'Och życie',2010,'komedia',0.6,0.7,0.7,0.1,0.2,1,0.1,0,0.2),(98,'Żona na niby',2011,'komedia romantyczna',1,0.7,0.1,0.1,0.1,1,0.1,0,0.1),(99,'To tylko seks',2011,'komedia romantyczna',1,0.7,0.1,0.1,0.2,1,0.1,0,0.1),(100,'Iluzja',2013,'kryminał',0.3,0.3,0.1,0.4,0.3,0.3,0.1,1,0.5),(101,'Ex machina',2015,'thriller',0.2,0.3,0.2,0.8,0.6,0.4,0.2,0.3,0.5),(102,'Masz wiadomość',1998,'komedia romantyczna',1,0.8,0.2,0.1,0.1,1,0.1,0,0.1),(103,'Cztery wesela i pogrzeb',1994,'komedia romantyczna',0.8,0.8,0.4,0.1,0.2,0.8,0.4,0,0.1),(104,'Zakonnica w przebraniu',1992,'komedia',1,0.5,0.1,0.1,0.1,0.1,0.6,0.3,0.2),(105,'Bezwstydny Mortdecai',2015,'komedia',0.8,0.5,0.1,0.2,0.5,0.2,0.1,0.3,0.4),(106,'Ocean\'s 8',2018,'film akcji',0.8,0.5,0.1,0.1,0.6,0.5,0.3,0.9,0.4),(107,'Notting Hill',1999,'komedia romantyczna',0.6,0.8,0.4,0.2,0.4,1,0.2,0,0.1),(108,'Gwiezdne Wojny Nowa Nadzieja',1977,'Sci-Fi',0.2,0.1,0.4,0.1,0.8,0.2,0.6,0.2,0.1),(109,'Iron Man',2008,'film akcji',0.8,0.2,0.4,0.2,0.6,0.3,0.1,0.2,0.1),(110,'LEGO PRZYGODA',2014,'film animowany',0.7,0.1,0.4,0.1,0.3,0.1,0.6,0.1,0.1),(111,'Parasite',2019,'dramat',0.1,0.6,0.2,0.9,0.8,0.1,0.2,0.2,0.5),(112,'To my',2019,'horror',0.1,0.3,0.1,0.7,0.8,0.1,0.4,0.3,0.8),(113,'Uciekaj!',2017,'horror',0.1,0.3,0.1,0.8,0.7,0.1,0.3,0.4,0.7),(114,'To',2017,'horror',0.1,0.1,0.5,0.6,1,0.1,0.3,0.1,1),(115,'Koszmar Z Ulicy Wiązów',1984,'horror',0.1,0.6,0.1,0.2,0.9,0.1,0.1,0.4,0.8),(116,'Lśnienie',1980,'horror',0.1,0.2,0.1,0.6,0.8,0.1,0.3,0.2,0.9),(117,'Obecność',2013,'horror',0.1,0.1,0.1,0.5,0.9,0.1,0.4,0.2,1),(118,'Paranormal Activity',2007,'horror',0.1,0.1,0.2,0.2,0.7,0.1,0.1,0.2,1),(119,'The Boy',2016,'horror',0.1,0.6,0.2,0.6,0.8,0.1,0.2,0.1,1),(120,'Rec',2007,'horror',0.1,0.1,0.2,0.5,0.7,0.1,0.1,0.1,1),(121,'Droga bez powrotu',2003,'horror',0.1,0.1,0.2,0.5,0.7,0.1,0.2,0.3,1);
/*!40000 ALTER TABLE `filmy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grał_w`
--

DROP TABLE IF EXISTS `grał_w`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grał_w` (
  `id_filmu` tinyint(3) unsigned NOT NULL,
  `id_aktora` smallint(5) unsigned NOT NULL,
  KEY `id_filmu` (`id_filmu`),
  KEY `id_aktora` (`id_aktora`),
  CONSTRAINT `gra@3l_w_ibfk_1` FOREIGN KEY (`id_filmu`) REFERENCES `filmy` (`id`),
  CONSTRAINT `gra@3l_w_ibfk_2` FOREIGN KEY (`id_aktora`) REFERENCES `aktorzy` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grał_w`
--

LOCK TABLES `grał_w` WRITE;
/*!40000 ALTER TABLE `grał_w` DISABLE KEYS */;
INSERT INTO `grał_w` VALUES (1,92),(1,125),(1,215),(2,26),(2,214),(2,163),(3,276),(3,24),(3,214),(4,3),(4,247),(4,190),(5,129),(5,216),(5,122),(6,258),(6,12),(6,20),(7,196),(7,13),(7,134),(8,173),(8,147),(8,74),(9,115),(9,255),(9,13),(10,7),(10,177),(10,60),(11,249),(11,100),(11,218),(12,10),(12,69),(12,110),(13,277),(13,205),(13,81),(14,277),(14,251),(14,93),(15,240),(15,245),(15,140),(16,143),(16,261),(16,282),(17,286),(17,290),(17,294),(18,250),(18,248),(18,80),(19,36),(19,221),(19,172),(20,43),(20,285),(20,174),(21,3),(21,268),(21,208),(22,143),(22,165),(22,224),(23,111),(23,171),(23,191),(24,95),(24,61),(24,54),(25,260),(25,297),(25,265),(26,255),(26,64),(26,127),(27,281),(27,193),(27,280),(28,26),(28,226),(28,79),(29,141),(29,102),(29,275),(30,162),(30,195),(30,62),(31,197),(31,278),(31,146),(32,115),(32,40),(32,204),(33,197),(33,152),(33,90),(34,133),(34,10),(34,16),(35,44),(35,97),(35,110),(36,29),(36,76),(36,284),(37,22),(37,194),(37,189),(38,136),(38,200),(38,210),(39,41),(39,229),(39,17),(40,261),(40,128),(40,168),(41,25),(41,40),(41,184),(42,138),(42,245),(42,293),(43,4),(43,167),(43,207),(44,250),(44,212),(44,235),(45,158),(45,173),(45,101),(46,2),(46,38),(46,91),(47,132),(47,25),(47,222),(48,295),(48,82),(48,103),(49,112),(49,272),(49,55),(50,18),(50,99),(50,230),(51,287),(51,85),(51,206),(52,105),(52,32),(52,139),(53,250),(53,259),(53,236),(54,11),(54,239),(54,42),(55,285),(55,190),(55,164),(56,37),(56,68),(56,119),(57,28),(57,241),(57,87),(58,282),(58,178),(58,51),(59,196),(59,157),(59,1),(60,138),(60,131),(60,244),(61,13),(61,75),(61,201),(62,201),(62,236),(62,7),(63,257),(63,262),(63,192),(64,50),(64,155),(64,296),(65,13),(65,202),(65,145),(66,267),(66,256),(66,151),(67,262),(67,98),(67,64),(68,13),(68,135),(68,252),(69,225),(69,88),(69,14),(70,237),(70,279),(70,271),(71,256),(71,76),(71,142),(72,15),(72,177),(72,163),(73,120),(73,150),(73,228),(74,173),(74,26),(74,184),(75,46),(75,169),(75,199),(76,150),(76,30),(76,57),(77,273),(77,48),(77,270),(78,211),(78,67),(78,19),(79,116),(79,117),(79,234),(80,150),(80,238),(80,243),(81,56),(81,231),(81,288),(82,23),(82,198),(82,31),(83,143),(83,223),(83,269),(84,250),(84,95),(84,107),(85,21),(85,63),(85,70),(86,94),(86,123),(86,256),(87,145),(87,144),(87,185),(88,114),(88,77),(88,44),(89,145),(89,52),(89,89),(90,45),(90,113),(90,233),(91,143),(91,219),(91,208),(92,175),(92,181),(92,84),(93,243),(93,137),(93,33),(94,27),(94,153),(94,65),(95,257),(95,213),(95,66),(96,30),(96,154),(96,179),(97,159),(97,148),(97,149),(98,2),(98,126),(98,217),(99,154),(99,209),(99,220),(100,133),(100,188),(100,291),(101,5),(101,59),(101,227),(102,198),(102,277),(102,104),(103,114),(103,9),(103,166),(104,288),(104,182),(104,160),(105,145),(105,83),(105,106),(106,262),(106,34),(106,13),(107,114),(107,150),(107,242),(108,187),(108,108),(108,31),(109,246),(109,106),(109,274),(110,39),(110,214),(110,73),(111,156),(111,263),(111,292),(112,180),(112,289),(112,71),(113,47),(113,6),(113,35),(114,121),(114,130),(114,266),(115,253),(115,109),(115,8),(116,118),(116,264),(116,49),(117,283),(117,232),(117,176),(118,161),(118,203),(118,186),(119,254),(119,170),(119,124),(120,183),(120,86),(120,53),(121,58),(121,72),(121,78);
/*!40000 ALTER TABLE `grał_w` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `obejrzane`
--

DROP TABLE IF EXISTS `obejrzane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `obejrzane` (
  `nick` char(15) COLLATE utf8_unicode_ci NOT NULL,
  `id_filmu` tinyint(3) unsigned NOT NULL,
  `ocena` char(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `data` date NOT NULL,
  KEY `nick` (`nick`),
  KEY `id_filmu` (`id_filmu`),
  CONSTRAINT `obejrzane_ibfk_1` FOREIGN KEY (`nick`) REFERENCES `użytkownicy` (`login`),
  CONSTRAINT `obejrzane_ibfk_2` FOREIGN KEY (`id_filmu`) REFERENCES `filmy` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `obejrzane`
--

LOCK TABLES `obejrzane` WRITE;
/*!40000 ALTER TABLE `obejrzane` DISABLE KEYS */;
/*!40000 ALTER TABLE `obejrzane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reżyserzy`
--

DROP TABLE IF EXISTS `reżyserzy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reżyserzy` (
  `id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `imię_nazwisko` char(50) COLLATE utf8_unicode_ci NOT NULL,
  `urodzony` date NOT NULL,
  `zmarł` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reżyserzy`
--

LOCK TABLES `reżyserzy` WRITE;
/*!40000 ALTER TABLE `reżyserzy` DISABLE KEYS */;
INSERT INTO `reżyserzy` VALUES (1,'Aaron Blaise','1968-02-17',NULL),(2,'Adam McKay','1968-04-17',NULL),(3,'Adam Shankman','1964-11-27',NULL),(4,'Alex Garland','1970-05-26',NULL),(5,'Alfonso Cuaron','1961-11-28',NULL),(6,'Amy Heckerling','1954-05-07',NULL),(7,'Andy Muschietti','1973-08-26',NULL),(8,'Anne Fletcher','1966-05-01',NULL),(9,'Arthur Penn','1922-09-27','2010-09-28'),(10,'Barry Sonnenfeld','1953-04-01',NULL),(11,'Blake Edwards','1922-07-26','2010-12-15'),(12,'Brian De Palma','1940-09-11',NULL),(13,'Charles Chaplin','1889-04-16','1977-12-25'),(14,'Chris Columbus','1958-09-10',NULL),(15,'Christopher Nolan','1970-07-30',NULL),(16,'Costa-Gavras','1933-02-12',NULL),(17,'Damien Chazelle','1985-01-19',NULL),(18,'Danis Tanović','1969-02-20',NULL),(19,'Danny DeVito','1944-11-17',NULL),(20,'Dany Boon','1966-06-26',NULL),(21,'David Fincher','1962-08-28',NULL),(22,'David Frankel','1959-04-02',NULL),(23,'David Koepp','1963-06-09',NULL),(24,'Dennis Dugan','1946-09-05',NULL),(25,'Dennis Gansel','1973-10-04',NULL),(26,'Donald Petrie','1954-04-02',NULL),(27,'Edgar Wright','1974-04-18',NULL),(28,'Elia Kazan','1909-09-07','2003-09-28'),(29,'Emile Ardolino','1943-05-09','1993-11-20'),(30,'Francis Ford Coppola','1939-04-07',NULL),(31,'Frank Darabont','1959-01-28',NULL),(32,'Garry Marshall','1934-11-13','2016-07-19'),(33,'Gary Ross','1956-11-03',NULL),(34,'George Lucas','1944-05-14',NULL),(35,'Gilles de Maistre','1960-05-08',NULL),(36,'Gina Prince-Bythewood','1969-06-10',NULL),(37,'Glenn Ficarra','1971-05-27',NULL),(38,'Greg Berlanti','1972-05-24',NULL),(39,'Jake Kasdan','1974-10-28',NULL),(40,'James Cameron','1954-08-16',NULL),(41,'James Wan','1977-02-26',NULL),(42,'Jaume Balagueró','1968-11-03',NULL),(43,'Jerry Zucker','1950-03-11',NULL),(44,'Jerzy Hoffman','1932-03-15',NULL),(45,'Joe Wright','1972-08-25',NULL),(46,'Jon Favreau','1966-10-19',NULL),(47,'Joon-ho Bong','1969-09-14',NULL),(48,'Jordan Peele','1979-02-21',NULL),(49,'Juliusz Machulski','1955-03-10',NULL),(50,'Larry Charles','1956-12-01',NULL),(51,'Lasse Hallstrom','1946-06-02',NULL),(52,'Lone Scherfig','1959-05-02',NULL),(53,'Louis Leterrier','1973-06-17',NULL),(54,'Luc Besson','1959-03-18',NULL),(55,'Łukasz Palkowski','1976-03-02',NULL),(56,'Martin Brest','1951-08-08',NULL),(57,'Martin Scorsese','1942-11-17',NULL),(58,'Michael Curtiz','1886-12-24','1962-04-11'),(59,'Mike Newell','1942-03-28',NULL),(60,'Mike Nichols','1931-11-06','2014-11-19'),(61,'Morten Tyldum','1967-05-19',NULL),(62,'Nick Cassavetes','1959-05-21',NULL),(63,'Nora Ephron','1941-05-19','2012-06-26'),(64,'Norman Jewison','1926-07-21',NULL),(65,'Ol Parker','1960-09-06',NULL),(66,'Olivier Nakache','1973-04-15',NULL),(67,'Oren Peli','1970-01-21',NULL),(68,'Paul Hogan','1939-10-08',NULL),(69,'Peter Weir','1944-08-21',NULL),(70,'Phil Lord','1975-07-12',NULL),(71,'Philippe de Chauveron','1965-11-15',NULL),(72,'Phyllida Lloyd','1957-06-17',NULL),(73,'Pierre Morel','1964-05-12',NULL),(74,'Quentin Tarantino','1963-03-27',NULL),(75,'Randal Kleiser','1946-07-20',NULL),(76,'Richard Curtis','1956-11-08',NULL),(77,'Rob Minkoff','1962-08-11',NULL),(78,'Rob Reiner','1947-03-06',NULL),(79,'Rob Schmidt','1965-09-25',NULL),(80,'Robert Zemeckis','1952-05-14',NULL),(81,'Roberto Benigni','1952-10-27',NULL),(82,'Roger Michell','1956-06-05',NULL),(83,'Roman Załuski','1936-12-10',NULL),(84,'Ron Clements','1953-04-25',NULL),(85,'Ron Howard','1954-03-01',NULL),(86,'Sidney Lumet','1924-06-25','2011-04-09'),(87,'Stanley Donen','1924-04-13','2019-02-21'),(88,'Stanley Kubrick','1928-07-26','1999-03-07'),(89,'Stephen Chbosky','1970-01-25',NULL),(90,'Steven Spielberg','1946-12-18',NULL),(91,'Sylwester Chęciński','1930-05-21',NULL),(92,'Tate Taylor','1969-06-03',NULL),(93,'Terry Jones','1942-02-01','2020-01-21'),(94,'Tim Burton','1958-08-25',NULL),(95,'Tim Miller','1964-10-10',NULL),(96,'Todd Philips','1970-12-20',NULL),(97,'Tom Hooper','1972-10-05',NULL),(98,'Tom Shadyac','1958-12-11',NULL),(99,'Tony Bancroft','1967-07-31',NULL),(100,'Victor Fleming','1889-02-23','1949-01-06'),(101,'Wes Craven','1939-08-02','2015-08-30'),(102,'Will Gluck','1978-08-23',NULL),(103,'William Brent Bell','1995-10-15',NULL),(104,'Wolfgang Petersen','1941-03-14',NULL);
/*!40000 ALTER TABLE `reżyserzy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `użytkownicy`
--

DROP TABLE IF EXISTS `użytkownicy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `użytkownicy` (
  `login` char(15) COLLATE utf8_unicode_ci NOT NULL,
  `hasło` char(32) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `użytkownicy`
--

LOCK TABLES `użytkownicy` WRITE;
/*!40000 ALTER TABLE `użytkownicy` DISABLE KEYS */;
/*!40000 ALTER TABLE `użytkownicy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wyprodukował`
--

DROP TABLE IF EXISTS `wyprodukował`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wyprodukował` (
  `id_filmu` tinyint(3) unsigned NOT NULL,
  `nazwa_wytwórni` char(50) COLLATE utf8_unicode_ci NOT NULL,
  KEY `id_filmu` (`id_filmu`),
  KEY `nazwa_wytwórni` (`nazwa_wytwórni`),
  CONSTRAINT `wyprodukowa@3l_ibfk_1` FOREIGN KEY (`id_filmu`) REFERENCES `filmy` (`id`),
  CONSTRAINT `wyprodukowa@3l_ibfk_2` FOREIGN KEY (`nazwa_wytwórni`) REFERENCES `wytwórnie` (`nazwa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wyprodukował`
--

LOCK TABLES `wyprodukował` WRITE;
/*!40000 ALTER TABLE `wyprodukował` DISABLE KEYS */;
INSERT INTO `wyprodukował` VALUES (1,'Gaumont'),(2,'Cecchi Gori Pictures'),(3,'Castle Rock Entertainment'),(4,'Paramount Pictures'),(5,'Walt Disney Pictures'),(6,'Paramount Pictures'),(7,'Paramount Pictures'),(8,'Warner Bros'),(9,'Universal Pictures'),(10,'Universal Pictures'),(11,'Miramax Films'),(12,'20th Century Fox'),(13,'Warner Bros'),(14,'Paramount Pictures'),(15,'Warner Bros'),(16,'Miramax Films'),(17,'Wytwórnia Filmów Fabularnych we Wrocławiu'),(18,'Walt Disney Pictures'),(19,'United Artists'),(20,'Warner Home Video'),(21,'Universal Pictures'),(22,'TriStar Pictures'),(23,'United Artists'),(24,'Metro-Goldwyn-Mayer'),(25,'20th Century Fox'),(26,'Universal Pictures'),(27,'Canal+'),(28,'Warner Bros'),(29,'Warner Bros'),(30,'Universal Pictures'),(31,'Constantin Film'),(32,'Warner Bros'),(33,'Constantin Film'),(34,'Columbia Pictures'),(35,'UK Film Council'),(36,'DreamWorks SKG'),(37,'Black Bear Pictures'),(38,'Bold Films'),(39,'Canal+ France'),(40,'Double Feature Films'),(41,'Plan B Entertainment'),(42,'DC Films'),(43,'Agencja Produkcji Filmowej'),(44,'Universal Pictures'),(45,'Paramount Pictures'),(46,'Universal Pictures'),(47,'Studio Filmowe Kadr'),(48,'Studio Filmowe Oko'),(49,'Universal Pictures'),(50,'Paramount Pictures'),(51,'Warner Bros'),(52,'Newmarket Capital Group'),(53,'20th Century Fox'),(54,'Paramount Pictures'),(55,'Warner Bros'),(56,'First National Pictures'),(57,'United Artists'),(58,'Miramax Films'),(59,'Paramount Pictures'),(60,'Walt Disney Pictures'),(61,'20th Century Fox'),(62,'Universal Pictures'),(63,'Touchstone Pictures'),(64,'Pathe'),(65,'Walt Disney Pictures'),(66,'Warner Bros'),(67,'Warner Bros'),(68,'Random House Films'),(69,'Quad Productions'),(70,'Next Film'),(71,'Summit Entertainment'),(72,'Working Title Films'),(73,'Lionsgate'),(74,'Columbia Pictures'),(75,'Canal+'),(76,'TriStar Pictures'),(77,'Walt Disney Pictures'),(78,'Walt Disney Pictures'),(79,'Warner Bros'),(80,'Touchstone Pictures'),(81,'Paramount Pictures'),(82,'Castle Rock Entertainment'),(83,'Paramount Pictures'),(84,'United Artists'),(85,'Miramax Films'),(86,'New Line Cinema'),(87,'Columbia Pictures'),(88,'Universal Pictures'),(89,'Warner Bros'),(90,'Fox Searchlight Pictures'),(91,'New Line Cinema'),(92,'20th Century Fox'),(93,'Stage 6 Films'),(94,'Warner Bros'),(95,'Marvel Entertainment'),(96,'Columbia Pictures'),(97,'Josephson Entertainment'),(98,'Columbia Pictures'),(99,'Castle Rock Entertainment'),(100,'Summit Entertainment'),(101,'Universal Pictures'),(102,'Warner Bros'),(103,'PolyGram Filmed'),(104,'Touchstone Pictures'),(105,'Mad Chance Productions'),(106,'Smokehouse Pictures'),(107,'Universal Pictures'),(108,'Lucasfilm'),(109,'Marvel Entertainment'),(110,'Warner Bros'),(111,'CJ Entertainment'),(112,'Universal Pictures'),(113,'Universal Pictures'),(114,'New Line Cinema'),(115,'New Line Cinema'),(116,'Warner Bros'),(117,'Warner Bros'),(118,'Paramount Pictures'),(119,'Vertigo Entertainment'),(120,'Filmax'),(121,'20th Century Fox');
/*!40000 ALTER TABLE `wyprodukował` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wyreżyserował`
--

DROP TABLE IF EXISTS `wyreżyserował`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wyreżyserował` (
  `id_filmu` tinyint(3) unsigned NOT NULL,
  `id_reżysera` smallint(5) unsigned NOT NULL,
  KEY `id_filmu` (`id_filmu`),
  KEY `id_reżysera` (`id_reżysera`),
  CONSTRAINT `wyre@4uyserowa@3l_ibfk_1` FOREIGN KEY (`id_filmu`) REFERENCES `filmy` (`id`),
  CONSTRAINT `wyre@4uyserowa@3l_ibfk_2` FOREIGN KEY (`id_reżysera`) REFERENCES `reżyserzy` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wyreżyserował`
--

LOCK TABLES `wyreżyserował` WRITE;
/*!40000 ALTER TABLE `wyreżyserował` DISABLE KEYS */;
INSERT INTO `wyreżyserował` VALUES (1,54),(2,21),(3,31),(4,30),(5,77),(6,50),(7,15),(8,15),(9,97),(10,65),(11,81),(12,21),(13,31),(14,80),(15,57),(16,74),(17,91),(18,69),(19,64),(20,100),(21,12),(22,6),(23,86),(24,87),(25,40),(26,85),(27,16),(28,104),(29,93),(30,45),(31,25),(32,15),(33,25),(34,21),(35,97),(36,92),(37,61),(38,17),(39,71),(40,74),(41,2),(42,96),(43,44),(44,98),(45,40),(46,56),(47,49),(48,83),(49,90),(50,11),(51,9),(52,15),(53,14),(54,10),(55,28),(56,13),(57,18),(58,74),(59,26),(60,1),(61,22),(62,72),(63,8),(64,20),(65,94),(66,37),(67,5),(68,52),(69,66),(70,55),(71,17),(72,27),(73,89),(74,74),(75,35),(76,68),(77,84),(78,99),(79,58),(80,32),(81,43),(82,78),(83,75),(84,60),(85,19),(86,62),(87,23),(88,76),(89,94),(90,36),(91,3),(92,73),(93,51),(94,96),(95,95),(96,39),(97,38),(98,24),(99,102),(100,53),(101,4),(102,63),(103,59),(104,29),(105,23),(106,33),(107,82),(108,34),(109,46),(110,70),(111,47),(112,48),(113,48),(114,7),(115,101),(116,88),(117,41),(118,67),(119,103),(120,42),(121,79);
/*!40000 ALTER TABLE `wyreżyserował` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wytwórnie`
--

DROP TABLE IF EXISTS `wytwórnie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wytwórnie` (
  `nazwa` char(50) COLLATE utf8_unicode_ci NOT NULL,
  `siedziba` char(50) COLLATE utf8_unicode_ci NOT NULL,
  `rok_założenia` smallint(6) NOT NULL,
  PRIMARY KEY (`nazwa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wytwórnie`
--

LOCK TABLES `wytwórnie` WRITE;
/*!40000 ALTER TABLE `wytwórnie` DISABLE KEYS */;
INSERT INTO `wytwórnie` VALUES ('20th Century Fox','Los Angeles - USA',1935),('Agencja Produkcji Filmowej','Warszawa - Polska',1991),('Black Bear Pictures','Santa Monica - USA',2011),('Bold Films','Los Angeles - USA',2004),('Canal+','Paryż - Francja',1984),('Canal+ France','Paryż - Francja',1992),('Castle Rock Entertainment','Nowy Jork - USA',1987),('Cecchi Gori Pictures','Rzym - Włochy',1984),('CJ Entertainment','Seoul - Korea Południowa',2000),('Columbia Pictures','Los Angeles - USA',1924),('Constantin Film','Monachium - Niemcy',1950),('DC Films','Burbank - USA',2016),('Double Feature Films','Nowy Jork - USA',1995),('DreamWorks SKG','Los Angeles - USA',1994),('Filmax','Barcelona - Hiszpania',1953),('First National Pictures','Burbank - USA',1917),('Fox Searchlight Pictures','Los Angeles - USA',1994),('Gaumont','Neuilly-sur-Seine - Francja',1895),('Josephson Entertainment','Los Angeles - USA',2001),('Lionsgate','Santa Monica - USA',1997),('Lucasfilm','San Francisco - USA',1971),('Mad Chance Productions','Los Angeles - USA',1995),('Marvel Entertainment','Nowy Jork - USA',1998),('Metro-Goldwyn-Mayer','Los Angeles - USA',1924),('Miramax Films','Los Angeles - USA',1979),('New Line Cinema','Burbank - USA',1967),('Newmarket Capital Group','Los Angeles - USA',1994),('Next Film','Warszawa - Polska',2012),('Paramount Pictures','Los Angeles - USA',1912),('Pathe','Paryż - Francja',1896),('Plan B Entertainment','Los Angeles - USA',2001),('PolyGram Filmed','Los Angeles - USA',1980),('Quad Productions','Clichy-la-Garenne - Francja',1999),('Random House Films','Nowy Jork - USA',2005),('Smokehouse Pictures','Burbank - USA',2006),('Stage 6 Films','Culver City - USA',2007),('Studio Filmowe Kadr','Warszawa - Polska',1955),('Studio Filmowe Oko','Warszawa - Polska',1989),('Summit Entertainment','Santa Monica - USA',1999),('Touchstone Pictures','Burbank - USA',1984),('TriStar Pictures','Culver City - USA',1982),('UK Film Council','Londyn - Wielka Brytania',2000),('United Artists','Los Angeles - USA',1919),('Universal Pictures','Los Angeles - USA',1912),('Vertigo Entertainment','Los Angeles - USA',2001),('Walt Disney Pictures','Burbank - USA',1923),('Warner Bros','Burbank - USA',1923),('Warner Home Video','Burbank - USA',1978),('Working Title Films','Londyn - Wielka Brytania',1983),('Wytwórnia Filmów Fabularnych we Wrocławiu','Wrocław - Polska',1954);
/*!40000 ALTER TABLE `wytwórnie` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-06 22:54:47
