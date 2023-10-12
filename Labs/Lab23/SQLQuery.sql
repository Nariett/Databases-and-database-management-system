CREATE TRIGGER show_Data ON Car
AFTER INSERT
AS
BEGIN
    DECLARE @CarBrand NVARCHAR(255);
    SELECT @CarBrand = Car_Brand FROM INSERTED;
    PRINT 'Добавлен новый автомобиль ' + @CarBrand;
END;

CREATE TRIGGER count_Data ON Car
AFTER INSERT
AS
BEGIN
    DECLARE @Count INT;
	DECLARE @CountSelectCar INT;
	DECLARE @CarName NVARCHAR(255);
	SELECT @CarName = Car_Brand FROM INSERTED;
    SELECT @Count = COUNT(*) FROM Car;
	SELECT @CountSelectCar = COUNT(*) WHERE 
    PRINT 'Добавлен новый автомобиль ' + @CarBrand;
END;

INSERT INTO Car (Car_Brand, Car_Model, Car_Number, Car_Type, Year)
VALUES
('Tesla', 'Model Y', '1252 JK-7', 1, 2023);