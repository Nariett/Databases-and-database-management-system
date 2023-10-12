CREATE TRIGGER age_check ON Car
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Car (Car_Brand, Car_Model, Car_Number, Car_Type, Year)
    SELECT i.Car_Brand, i.Car_Model, i.Car_Number, i.Car_Type, i.Year
    FROM INSERTED i
    WHERE i.Year > 2010;
    IF (SELECT COUNT(*) FROM INSERTED WHERE Year <= 2010) > 0
    BEGIN
        PRINT('Год выпуска должен быть после 2010');
    END
END;

INSERT INTO Car (Car_Brand, Car_Model, Car_Number, Car_Type, Year)
VALUES
('Tesla', 'Model Y', '1252 JK-7', 1, 2004);

DELETE Car FROM Car WHERE Car_Number = '1252 JK-7'