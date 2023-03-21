CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS houses(

  id INT AUTO_INCREMENT PRIMARY KEY,
  room int NOT NULL DEFAULT 1,
  bathroom double NOT NULL DEFAULT 1.00,
  year INT NOT NULL DEFAULT 2000,
  price INT NOT NULL DEFAULT 200000,
  imgUrl VARCHAR(255) NOT NULL,
  color VARCHAR(15),
  address VARCHAR(255),
  description VARCHAR(255)

)default charset utf8 COMMENT '';

DROP table IF EXISTS houses;

INSERT INTO houses
(room, bathroom, year, price, imgUrl, color, address, description)
VALUES
(4, 3, 2023, 400000, 'https://media.istockphoto.com/id/1448381278/photo/the-side-view-of-a-large-gray-craftsman-new-construction-house-with-a-landscaped-yard-a-three.jpg?b=1&s=170667a&w=0&k=20&c=pHHNxKMgY-i5VMo9nd4viatxxhGVbD8X6ZUwRqQlwVw=', 'blue', '1234 Driver St.','This is a great home!'); 


`