CREATE TABLE IF NOT EXISTS  `person`(
`id` bigint(20) NOT NULL AUTO_INCREMENT,
`address` varchar(100) NOT NULL,
`first_name` VARCHAR(80) NOT NULL,
`gender` VARCHAR(6) NOT NULL,
`last_name` VARCHAR(80) NOT NULL,
PRIMARY KEY(`id`)
)