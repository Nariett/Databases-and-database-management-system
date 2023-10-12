CREATE TRIGGER availability_check ON Car
INSTEAD OF DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @CarNumberToDelete NVARCHAR(255);
	SELECT @CarNumberToDelete = Car_Number FROM deleted;

	IF (SELECT COUNT(*) FROM Car WHERE Car_Number = @CarNumberToDelete) = 0
		BEGIN
			PRINT('Нет автомобилей в бд с данным номером');
		END
	ELSE
		BEGIN
			DELETE FROM Car WHERE Car_Number = @CarNumberToDelete;
		END
	END;

DELETE Car FROM Car WHERE Car_Number = '12412 KL-7'