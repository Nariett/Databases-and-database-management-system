USE master;
ALTER DATABASE CarDataBase
SET RECOVERY FULL;

/*������ ��������� �����������*/
BACKUP DATABASE CarDataBase
	TO DISK='D:\�������\CarDataBase_FullBackup.bak'

/*���������� ��������� �����������*/
BACKUP DATABASE CarDataBase
	TO DISK='D:\�������\CarDataBase_DifferentialBackup.bak'
	WITH DIFFERENTIAL

/*����� �����������*/
BACKUP DATABASE CarDataBase
	TO DISK = 'D:\�������\CarDataBase_FullBackup.bak';
BACKUP LOG CarDataBase
	TO DISK = 'D:\�������\CarDataBaseLog.bak';

/*�������������� ������ ��������� �����*/
USE master
GO
RESTORE DATABASE CarDataBase
FROM DISK = 'D:\�������\CarDataBase_FullBackup.bak'
WITH REPLACE

/*�������������� ���������� �����*/
USE master
GO
RESTORE DATABASE CarDataBase
FROM DISK = 'D:\�������\CarDataBase_FullBackup.bak'
WITH REPLACE

/*�������������� ����� �����*/
USE master
RESTORE DATABASE CarDataBase
FROM DISK = 'D:\�������\CarDataBase_FullBackup.bak'
WITH REPLACE
USE master;
RESTORE LOG CarDataBase
FROM DISK = 'D:\�������\CarDataBaseLog.bak'
WITH FILE=1, NORECOVERY;


/*�������� ���� ������*/
CREATE TYPE NameCar from VARCHAR(255);

CREATE TABLE CarName 
(
    ID INT PRIMARY KEY,
    Name NameCar,
);

CREATE RULE NameCarRule AS LEN(@stringVal) <= 50;

EXEC sp_bindrule 'NameCarRule', 'NameCar';


 

	