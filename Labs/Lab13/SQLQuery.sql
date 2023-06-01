/*проверка нахождения автомоблия toyota Camry*/
DECLARE @CarBrand NVARCHAR(50);
DECLARE @CarModel NVARCHAR(50);

SET @CarBrand = 'Toyota';
SET @CarModel = 'Camry';

IF EXISTS (SELECT * FROM CarTest WHERE Car_Brand = @CarBrand AND Car_Model = @CarModel)
BEGIN
    PRINT 'Автомобиль существует в базе данных.';
END
ELSE
BEGIN
    PRINT 'Автомобиль не существует в базе данных.';
END
/*проверка нахождения автомоблия toyota Camry*/
DECLARE @CarBrand INT;
DECLARE @CarModel INT;

SET @CarBrand = 2;
SET @CarModel = 3;

IF @CarBrand > @CarModel
BEGIN
    PRINT '@CarBrand больше ';
END
ELSE
BEGIN
    PRINT '@CarModel меньше';
END
/*проверка нахождения номера в базе*/
DECLARE @CarNumber NVARCHAR(50);

SET @CarNumber = '4567 DE-7';

IF EXISTS (SELECT * FROM CarTest WHERE Car_Number = @CarNumber)
BEGIN
    PRINT 'Автомобиль с номером существует.';
END
ELSE
BEGIN
    PRINT 'Автомобиль с номером  несуществует.';
END
/*есть ли записи больше 5  */
DECLARE @Test Varchar(20)
IF EXISTS(SELECT * FROM CarTest WHERE ID_Car > 5)
	set @Test = 'Запись есть'
ELSE
	set @Test = 'Запись нет'
SELECT @Test AS [lF]

/*есть ли записи больше   */
DECLARE @Test Varchar(20)
IF EXISTS(SELECT * FROM CarTest WHERE ID_Car > 5)
	set @Test = 'Запись есть'
ELSE
	set @Test = 'Запись нет'
SELECT @Test AS [Результат]

/*машина старше 2000*/ 
DECLARE @Result VARCHAR(20);
SET @Result = (
    SELECT 
        CASE
            WHEN EXISTS (SELECT * FROM CarTest WHERE Year > 2000) THEN 'Запись есть'
            ELSE 'Запись нет'
        END
);
SELECT @Result AS [Результат];
/*Записи больше нуля*/
DECLARE @CarCount INT;
DECLARE @Result VARCHAR(20);
SELECT @CarCount = COUNT(*) FROM CarTest;
SET @Result = (
    CASE
        WHEN @CarCount > 0 THEN 'Запись есть'
        ELSE 'Запись нет'
    END
);

SELECT @Result AS [Результат];
/*написание итерраций */
DECLARE @count INT;
SET @count = 1;
    
WHILE @count<= 5
BEGIN
   PRINT @count
   SET @count = @count + 1;
END;
/**/
DECLARE @count INT;
SET @count = 1;
    
WHILE @count<= 2
BEGIN
	PRINT @count
	INSERT INTO CarTest VALUES('Car-'+CAST(@count as varchar),'Model-'+CAST(@count as varchar),'Number-'+CAST(@count as varchar),@count,2000 + @count)
	SET @count = @count + 1;
   
END;