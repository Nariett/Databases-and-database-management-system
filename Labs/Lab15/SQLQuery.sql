/*��������� �������*/
SELECT LOWER(Car_Number) as '����� ����������' from CarTest 

SELECT LTRIM(Car_Brand) as '�������� ����������' from CarTest/*�������� �������� � ������*/

SELECT RTRIM(Car_Brand) as '�������� ����������' from CarTest/*�������� �������� � �����*/


/*�������������� �������*/
SELECT COS(Number) as '������� �����' from Numbers

SELECT SIN(Number) as '����� �����' from Numbers

SELECT LOG(Number) as '�������� �����' from Numbers

/*������� ��� ������ � �����*/
SELECT DATEADD(DAY, 1, DateTimeValue) AS '����������� ����� �� 1 ����' FROM TimeTable

SELECT DAY(DateTimeValue) AS '����� ����' FROM TimeTable

SELECT YEAR(DateTimeValue) AS '����� ����' FROM TimeTable

/*C�������� �������*/

SELECT COL_LENGTH('TestDB.dbo.Numbers',Car_Brand) AS '����� ������ � ������'
FROM CarTest

SELECT DATALENGTH(Car_Brand) AS '����� ������ � ������'
FROM CarTest

SELECT ISDATE(Car_Number) as '����?' from CarTest


/*���������� �������*/
SELECT COUNT(Car_Brand) as '�������' FROM CarTest;

SELECT MAX(Car_Type) as '����� ������� ��� ����' from CarTest 

SELECT MIN(Car_Type)as '����� ������ ��� ����'  from CarTest 


/*�������������� �������*/ 
SELECT @@PACK_SENT as '���������� �������'

SELECT @@TIMETICKS AS '���������� ����������� ';

SELECT @@TOTAL_ERRORS  AS '���������� ������'

/*���������� �������*/

SELECT * FROM CarTest WHERE Car_Type = 1 AND Year >= 2018;

SELECT * FROM CarTest WHERE Car_Brand = 'Toyota' OR Car_Brand = 'Honda';

SELECT * FROM CarTest WHERE NOT (Car_Type = 2 AND Year > 2020);