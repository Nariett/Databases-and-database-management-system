DECLARE @name NVARCHAR(20), @age INT;
SET @name = 'Tom';
SET @age = 18
PRINT 'Name:' + @name;
PRINT 'Age:' + CONVERT(CHAR, @age);

/*������� ������ �� id */
Use CarDataBase
DECLARE @idFine Int;
SET @idFine = 2;
BEGIN
    DELETE FROM Fine WHERE ID_Fine = @IdFine
END

/*����� ���������� ����� ������*/
USE CarDataBase
DECLARE @Fine INT;
SET @Fine = (SELECT Min(Sum_Fine) From Fine)
SELECT @Fine as '����������� ����� ������'


/*������� ���������� � ����� �������� �� �������*/
USE CarDataBase
DECLARE @id INT, @name NVARCHAR(50),@number NVARCHAR(50);
SET @id = 1
SET @name = (SELECT Name FROM Client WHERE ID_Client = @id);
SET @number = (SELECT Phone_Number FROM Client WHERE ID_Client = @id);
SELECT @id as '����� �������', @name as '��� �������', @number as '����� ��������'

/*������ �������� �����������*/
USE CarDataBase
DECLARE @message NVARCHAR(50)
DECLARE @countOne INT
SET @countOne = (SELECT COUNT(*) FROM Car)
IF @countOne<10 
	BEGIN
		SET @message = '�������� ����������� � �����'
		SELECT @message as ���������� 
	END
else
	BEGIN
		SET @message = '������ � �������. �� ' + str(@countOne)
		SELECT @message as ����������
	END 

/*������� ���� ������ �� �������� */
USE CarDataBase
DECLARE @sum int
DECLARE @clientCount int
SET @sum = (SELECT SUM(Sum_Fine) FROM Fine)
SET @clientCount = (SELECT COUNT (*) FROM Fine)
PRINT '������� ����� ������ �� �������� ' + str(@sum/@clientCount)
PRINT '����� ����� ������� ' + str(@sum)
PRINT '���-�� ����� � ��������' + str(@clientCount)


/*���*/
DECLARE @x int
DECLARE @y float
SET @x = 11
IF(@x < 2)
	BEGIN 
		SET @y = (2.56 * @x + 2 )/ TAN(2 + @x)
		SELECT @x as ��������, @y as ���������
	END
ELSE IF(2 <= @x AND @x <= 4)
	BEGIN
		SET @y = LOG10(POWER(@x,2)-1)
		SELECT @x as ��������, @y as ���������
	END
ELSE IF(@x > 10)
	BEGIN
		SET @y = TAN(2.78 * @x + 2)
		SELECT @x as ��������, @y as ���������
	END 