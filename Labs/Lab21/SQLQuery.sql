/*клиенты и скидки*/
CREATE VIEW ClientDiscountInfo AS
SELECT
    c.ID_Client,
    c.Name,
    c.Surname,
    c.Patronymic,
    c.Address,
    c.Phone_Number,
    d.Discount_Percentage,
    d.Number_Trips,
    d.Req_Date
FROM Client c
JOIN Discounts d ON c.ID_Client = d.ID_Client;

SELECT * FROM ClientDiscountInfo

USE CarDataBase 
Go
DROP VIEW ClientDiscountInfo
/*суммы штрафов дл€ каждого клиента*/
CREATE VIEW TotalFineByClient AS
SELECT
    c.ID_Client,
    c.Name,
    c.Surname,
    c.Patronymic,
    SUM(f.Sum_Fine) AS Total_Fine_Amount
	FROM Client c
	LEFT JOIN Fine f ON c.ID_Client = f.ID_Client
	GROUP BY c.ID_Client, c.Name, c.Surname, c.Patronymic;

SELECT * FROM TotalFineByClient

/*выд авто и клиенты*/
CREATE VIEW IssuedCarsInfo AS
SELECT
    ic.ID_Deal,
    c.Name AS Client_Name,
    c.Surname AS Client_Surname,
    c.Phone_Number AS Client_Phone,
    ca.Car_Brand,
    ca.Car_Model,
    ic.Date_Issue,
    ic.Date_Return
	FROM Issued_Cars ic
	JOIN Client c ON ic.ID_Client = c.ID_Client
	JOIN Car ca ON ic.ID_Car = ca.ID_Car;

SELECT * FROM IssuedCarsInfo

/*средн€€ скидка и кол-во поездок дл€ каждого типа автомобил€:*/
CREATE VIEW AvgDiscountAndTripsByCarType AS
SELECT
    ca.Car_Type,
    AVG(d.Discount_Percentage) AS Avg_Discount,
    SUM(d.Number_Trips) AS Total_Trips
	FROM Car ca
	LEFT JOIN Discounts d ON ca.ID_Car = d.ID_Client
	GROUP BY ca.Car_Type;

SELECT * FROM AvgDiscountAndTripsByCarType

INSERT INTO AvgDiscountAndTripsByCarType VALUES (3,5,10)
/*клиенты с макс скидкой*/
CREATE VIEW ClientsWithMaxDiscount AS
SELECT
    c.ID_Client,
    c.Name,
    c.Surname,
    c.Patronymic,
    d.Discount_Percentage
	FROM Client c
	JOIN Discounts d ON c.ID_Client = d.ID_Client
	WHERE d.Discount_Percentage = (
		SELECT MAX(Discount_Percentage)
		FROM Discounts
	);
USE CarDataBase
Go
DELETE FROM ClientsWithMaxDiscount WHERE ID_Client = 6

SELECT * FROM ClientsWithMaxDiscount
