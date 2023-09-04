﻿CREATE TABLE `books` (
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `author` VARCHAR(255),
  `launch_date` DATETIME NOT NULL,
  `price` DECIMAL(10,2) NOT NULL, 
  `title` TEXT 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
