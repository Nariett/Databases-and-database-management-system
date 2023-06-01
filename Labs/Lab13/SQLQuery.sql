/*�������� ���������� ���������� toyota Camry*/
DECLARE @CarBrand NVARCHAR(50);
DECLARE @CarModel NVARCHAR(50);

SET @CarBrand = 'Toyota';
SET @CarModel = 'Camry';

IF EXISTS (SELECT * FROM CarTest WHERE Car_Brand = @CarBrand AND Car_Model = @CarModel)
BEGIN
    PRINT '���������� ���������� � ���� ������.';
END
ELSE
BEGIN
    PRINT '���������� �� ���������� � ���� ������.';
END
/*�������� ���������� ���������� toyota Camry*/
DECLARE @CarBrand INT;
DECLARE @CarModel INT;

SET @CarBrand = 2;
SET @CarModel = 3;

IF @CarBrand > @CarModel
BEGIN
    PRINT '@CarBrand ������ ';
END
ELSE
BEGIN
    PRINT '@CarModel ������';
END
/*�������� ���������� ������ � ����*/
DECLARE @CarNumber NVARCHAR(50);

SET @CarNumber = '4567 DE-7';

IF EXISTS (SELECT * FROM CarTest WHERE Car_Number = @CarNumber)
BEGIN
    PRINT '���������� � ������� ����������.';
END
ELSE
BEGIN
    PRINT '���������� � �������  ������������.';
END
/*���� �� ������ ������ 5  */
DECLARE @Test Varchar(20)
IF EXISTS(SELECT * FROM CarTest WHERE ID_Car > 5)
	set @Test = '������ ����'
ELSE
	set @Test = '������ ���'
SELECT @Test AS [lF]

/*���� �� ������ ������   */
DECLARE @Test Varchar(20)
IF EXISTS(SELECT * FROM CarTest WHERE ID_Car > 5)
	set @Test = '������ ����'
ELSE
	set @Test = '������ ���'
SELECT @Test AS [���������]

/*������ ������ 2000*/ 
DECLARE @Result VARCHAR(20);
SET @Result = (
    SELECT 
        CASE
            WHEN EXISTS (SELECT * FROM CarTest WHERE Year > 2000) THEN '������ ����'
            ELSE '������ ���'
        END
);
SELECT @Result AS [���������];
/*������ ������ ����*/
DECLARE @CarCount INT;
DECLARE @Result VARCHAR(20);
SELECT @CarCount = COUNT(*) FROM CarTest;
SET @Result = (
    CASE
        WHEN @CarCount > 0 THEN '������ ����'
        ELSE '������ ���'
    END
);

SELECT @Result AS [���������];
/*��������� ��������� */
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