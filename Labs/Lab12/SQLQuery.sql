SELECT * FROM Client;
UPDATE Client SET Name = 'Ваня' WHERE Name = 'Иван';
SELECT * FROM Client;

SELECT * FROM Client;
UPDATE Client SET Surname = 'Петрович' WHERE Surname = 'Тараскевич';
SELECT * FROM Client;

SELECT * FROM Car;
UPDATE Car SET Year = 2020 WHERE Year = 2019;
SELECT * FROM Car;

SELECT * FROM Car;
UPDATE Car SET Car_Type = 2 WHERE Car_Number = '1234 AB-7';
SELECT * FROM Car;

SELECT * FROM Car;
UPDATE Car SET Year = 2021 WHERE Car_Number = '2345 BC-7';
SELECT * FROM Car;

SELECT * FROM Client;
DELETE FROM Client WHERE Phone_Number = '+375293456789';
SELECT * FROM Client;

SELECT * FROM Client;
DELETE FROM Client WHERE Address = 'ул. Лермонтова, 35, кв. 18';
SELECT * FROM Client;

DELETE FROM Car WHERE Year = 2023;
DELETE FROM Car WHERE Car_Number = '1234 AB-7';
DELETE FROM Car WHERE Car_Brand = 'Toyota';
