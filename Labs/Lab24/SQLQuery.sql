BEGIN TRANSACTION; 
    UPDATE Car SET Year = 2019 WHERE Car_Brand = 'Toyota';
    INSERT INTO Issued_Cars (ID_Client, ID_Car, Date_Issue, Date_Return)
    VALUES (3, 1, '2023-04-10', '2023-04-15');
COMMIT;

SET IMPLICIT_TRANSACTIONS ON;
    UPDATE Discounts SET Discount_Percentage = 8 WHERE ID_Client = 2;
    INSERT INTO Fine (ID_Car, ID_Client, Type_Damage, Sum_Fine)
    VALUES (5, 3, 'Царапина', 300);
SET IMPLICIT_TRANSACTIONS OFF;

UPDATE Car SET Year = 2021 WHERE Car_Brand = 'Mercedes-Benz';
COMMIT;

BEGIN TRANSACTION;
    UPDATE Discounts SET Number_Trips = 22 WHERE ID_Client = 3;
    BEGIN TRANSACTION;
        UPDATE Car SET Year = 2017 WHERE Car_Brand = 'BMW';
    COMMIT;
    INSERT INTO Fine (ID_Car, ID_Client, Type_Damage, Sum_Fine)
    VALUES (7, 4, 'Вмятина на двери', 600);
COMMIT;
