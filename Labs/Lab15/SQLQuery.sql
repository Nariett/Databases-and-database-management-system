/*строковые функции*/
SELECT LOWER(Car_Number) as 'Номер автомобиля' from CarTest 

SELECT LTRIM(Car_Brand) as 'Название автомобиля' from CarTest/*удаление пробелов в начале*/

SELECT RTRIM(Car_Brand) as 'Название автомобиля' from CarTest/*удаление пробелов в конце*/


/*математические функции*/
SELECT COS(Number) as 'Косинус числа' from Numbers

SELECT SIN(Number) as 'Синус числа' from Numbers

SELECT LOG(Number) as 'Логарифм числа' from Numbers

/*функции для работы с датой*/
SELECT DATEADD(DAY, 1, DateTimeValue) AS 'Увеличенное время на 1 день' FROM TimeTable

SELECT DAY(DateTimeValue) AS 'Число дней' FROM TimeTable

SELECT YEAR(DateTimeValue) AS 'Число дней' FROM TimeTable

/*Cистемные функции*/

SELECT COL_LENGTH('TestDB.dbo.Numbers',Car_Brand) AS 'длина данных в байтах'
FROM CarTest

SELECT DATALENGTH(Car_Brand) AS 'длина данных в байтах'
FROM CarTest

SELECT ISDATE(Car_Number) as 'Дата?' from CarTest


/*агрегатные функции*/
SELECT COUNT(Car_Brand) as 'Счетчик' FROM CarTest;

SELECT MAX(Car_Type) as 'Самый высокий тип авто' from CarTest 

SELECT MIN(Car_Type)as 'Самый низкий тип авто'  from CarTest 


/*статистические функции*/ 
SELECT @@PACK_SENT as 'количество пакетов'

SELECT @@TIMETICKS AS 'количество микросекунд ';

SELECT @@TOTAL_ERRORS  AS 'количество ошибок'

/*Логические функции*/

SELECT * FROM CarTest WHERE Car_Type = 1 AND Year >= 2018;

SELECT * FROM CarTest WHERE Car_Brand = 'Toyota' OR Car_Brand = 'Honda';

SELECT * FROM CarTest WHERE NOT (Car_Type = 2 AND Year > 2020);