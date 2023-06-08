/*������� ������ ��������, � ������� ���� ������:*/
SELECT *
FROM Client
WHERE ID_Client IN (SELECT ID_Client FROM Fine)

/*������� ������ �����, ������� ���� ������ ������� � ������ "����":*/
SELECT *
FROM Car
WHERE ID_Car IN (SELECT ID_Car FROM Issued_Cars WHERE ID_Client = (SELECT ID_Client FROM Client WHERE Name = N'����'))

/*������ ��������, � ������� ���� ������ ����� 10% � ������� ���������� ������ ����� 5 ���:*/
SELECT *
FROM Client
WHERE ID_Client IN (SELECT ID_Client FROM Discounts WHERE Discount_Percentage > 10 AND Number_Trips > 5)

/*������� ������ �����, � ������� ���� ������ ����� 1000 ������:*/
SELECT *
FROM Car
WHERE ID_Car IN (SELECT ID_Car FROM Fine WHERE Sum_Fine > 1000)

/*�������� ������ �������, ��������� ������ �� ������� Discounts:*/
INSERT INTO Client (Name, Surname, Patronymic, Address, Phone_Number)
SELECT Name, Surname, Patronymic, Address, Phone_Number
FROM Discounts
WHERE ID_Client = 1

/*������� ���� ��������, � ������� ���� ������ ����� 500 ������, ������ � ���������������� ��������:*/
DELETE FROM Fine
WHERE ID_Client IN (SELECT ID_Client FROM Client WHERE ID_Client IN (SELECT ID_Client FROM Fine WHERE Sum_Fine > 500))

/*�������� ����� ������ � ������, ��������� ������ � ������� � ������ "����" � ������ � ID_Car = 3:*/
INSERT INTO Fine (ID_Car, ID_Client, Type_Damage, Sum_Fine)
SELECT 3, ID_Client, N'����������� ������', 1500
FROM Client
WHERE Name = N'����'





