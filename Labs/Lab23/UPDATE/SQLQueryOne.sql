CREATE TRIGGER update_Data ON Car
AFTER UPDATE
AS
BEGIN
    DECLARE @CarBrand NVARCHAR(255);
    SELECT @CarBrand = Car_Brand FROM INSERTED;
    PRINT 'Данные об автомобиле ' + @CarBrand + ' обновлены';
END;

UPDATE Car SET Car_Type = 2 WHERE Car_Brand = 'Mercedes-Benz' AND Car_Model = 'E-Class' AND Car_Number = '3456 CD-7';