USE master;
ALTER DATABASE CarDataBase
SET RECOVERY FULL;

/*Полное резервное копирование*/
BACKUP DATABASE CarDataBase
	TO DISK='D:\КопииБД\CarDataBase_FullBackup.bak'

/*Разностное резервное копирование*/
BACKUP DATABASE CarDataBase
	TO DISK='D:\КопииБД\CarDataBase_DifferentialBackup.bak'
	WITH DIFFERENTIAL

/*логов копирование*/
BACKUP DATABASE CarDataBase
	TO DISK = 'D:\КопииБД\CarDataBase_FullBackup.bak';
BACKUP LOG CarDataBase
	TO DISK = 'D:\КопииБД\CarDataBaseLog.bak';

/*Восстановление полной резервной копии*/
USE master
GO
RESTORE DATABASE CarDataBase
FROM DISK = 'D:\КопииБД\CarDataBase_FullBackup.bak'
WITH REPLACE

/*Восстановление разностной копии*/
USE master
GO
RESTORE DATABASE CarDataBase
FROM DISK = 'D:\КопииБД\CarDataBase_FullBackup.bak'
WITH REPLACE

/*Восстановление логов копии*/
USE master
RESTORE DATABASE CarDataBase
FROM DISK = 'D:\КопииБД\CarDataBase_FullBackup.bak'
WITH REPLACE
USE master;
RESTORE LOG CarDataBase
FROM DISK = 'D:\КопииБД\CarDataBaseLog.bak'
WITH FILE=1, NORECOVERY;


/*Создание типо данных*/
CREATE TYPE NameCar from VARCHAR(255);

CREATE TABLE CarName 
(
    ID INT PRIMARY KEY,
    Name NameCar,
);

CREATE RULE NameCarRule AS LEN(@stringVal) <= 50;

EXEC sp_bindrule 'NameCarRule', 'NameCar';


 

	