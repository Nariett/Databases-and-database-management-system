CREATE TRIGGER delete_Data ON Car
AFTER DELETE
AS
BEGIN
    DECLARE @CarNumber NVARCHAR(50);
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        SELECT @CarNumber = Car_Number FROM deleted;
        IF @CarNumber IS NOT NULL
        BEGIN
            PRINT 'Удален автомобиль с номером ' + @CarNumber;
        END
    END
END;

DELETE Car FROM Car WHERE Car_Number = '12412 KL-7'