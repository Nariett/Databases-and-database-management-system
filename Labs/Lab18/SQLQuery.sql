/*Вывести список клиентов, у которых есть штрафы:*/
SELECT *
FROM Client
WHERE ID_Client IN (SELECT ID_Client FROM Fine)

/*Вывести список машин, которые были выданы клиенту с именем "Ваня":*/
SELECT *
FROM Car
WHERE ID_Car IN (SELECT ID_Car FROM Issued_Cars WHERE ID_Client = (SELECT ID_Client FROM Client WHERE Name = N'Ваня'))

/*список клиентов, у которых были скидки более 10% и которые арендовали машину более 5 раз:*/
SELECT *
FROM Client
WHERE ID_Client IN (SELECT ID_Client FROM Discounts WHERE Discount_Percentage > 10 AND Number_Trips > 5)

/*Вывести список машин, у которых были штрафы свыше 1000 рублей:*/
SELECT *
FROM Car
WHERE ID_Car IN (SELECT ID_Car FROM Fine WHERE Sum_Fine > 1000)

/*Добавить нового клиента, используя данные из таблицы Discounts:*/
INSERT INTO Client (Name, Surname, Patronymic, Address, Phone_Number)
SELECT Name, Surname, Patronymic, Address, Phone_Number
FROM Discounts
WHERE ID_Client = 1

/*Удалить всех клиентов, у которых были штрафы свыше 500 рублей, вместе с соответствующими штрафами:*/
DELETE FROM Fine
WHERE ID_Client IN (SELECT ID_Client FROM Client WHERE ID_Client IN (SELECT ID_Client FROM Fine WHERE Sum_Fine > 500))

/*Добавить новую запись о штрафе, используя данные о клиенте с именем "Анна" и машине с ID_Car = 3:*/
INSERT INTO Fine (ID_Car, ID_Client, Type_Damage, Sum_Fine)
SELECT 3, ID_Client, N'Повреждение кузова', 1500
FROM Client
WHERE Name = N'Анна'





