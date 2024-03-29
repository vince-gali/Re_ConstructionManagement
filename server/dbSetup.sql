-- Active: 1691538181462@@13.59.90.114@3306@CM_Mach1
CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS company(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  companyId VARCHAR (255) NOT NULL,
  address VARCHAR(255),
  FOREIGN KEY (companyId) REFERENCES accounts(id)
)

CREATE TABLE IF NOT EXISTS projects(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  companyId VARCHAR (255) NOT NULL,
  cost VARCHAR(255) NOT NULL,
  status VARCHAR (255) NOT NULL,
  completionDate VARCHAR (255) NOT NULL,

  FOREIGN KEY (companyId) REFERENCES company(id)
)