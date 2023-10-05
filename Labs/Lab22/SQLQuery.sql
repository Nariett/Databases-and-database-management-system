DECLARE @name NVARCHAR(20), @age INT;
SET @name = 'Tom';
SET @age = 18
PRINT 'Name:' + @name;
PRINT 'Age:' + CONVERT(CHAR, @age);

/*Удалене штрафа по id */
Use CarDataBase
DECLARE @idFine Int;
SET @idFine = 2;
BEGIN
    DELETE FROM Fine WHERE ID_Fine = @IdFine
END

/*Вывод наибольшей суммы штрафа*/
USE CarDataBase
DECLARE @Fine INT;
SET @Fine = (SELECT Min(Sum_Fine) From Fine)
SELECT @Fine as 'Минимальная сумма штрафа'


/*Вывести информацию о одном человеке по индексу*/
USE CarDataBase
DECLARE @id INT, @name NVARCHAR(50),@number NVARCHAR(50);
SET @id = 1
SET @name = (SELECT Name FROM Client WHERE ID_Client = @id);
SET @number = (SELECT Phone_Number FROM Client WHERE ID_Client = @id);
SELECT @id as 'Номер клиента', @name as 'Имя клиента', @number as 'Номер телефона'

/*Анализ нехватки автомобилей*/
USE CarDataBase
DECLARE @message NVARCHAR(50)
DECLARE @countOne INT
SET @countOne = (SELECT COUNT(*) FROM Car)
IF @countOne<10 
	BEGIN
		SET @message = 'Нехватка автомобилей в парке'
		SELECT @message as Информация 
	END
else
	BEGIN
		SET @message = 'Машины в избытке. Их ' + str(@countOne)
		SELECT @message as Информация
	END 

/*Средняя цена штрафа на человека */
USE CarDataBase
DECLARE @sum int
DECLARE @clientCount int
SET @sum = (SELECT SUM(Sum_Fine) FROM Fine)
SET @clientCount = (SELECT COUNT (*) FROM Fine)
PRINT 'Средняя сумма штрафа на человека ' + str(@sum/@clientCount)
PRINT 'Общая сумма штрафов ' + str(@sum)
PRINT 'Кол-во людей с штрафами' + str(@clientCount)


/*ИДЗ*/
DECLARE @x int
DECLARE @y float
SET @x = 11
IF(@x < 2)
	BEGIN 
		SET @y = (2.56 * @x + 2 )/ TAN(2 + @x)
		SELECT @x as Значение, @y as Результат
	END
ELSE IF(2 <= @x AND @x <= 4)
	BEGIN
		SET @y = LOG10(POWER(@x,2)-1)
		SELECT @x as Значение, @y as Результат
	END
ELSE IF(@x > 10)
	BEGIN
		SET @y = TAN(2.78 * @x + 2)
		SELECT @x as Значение, @y as Результат
	END 