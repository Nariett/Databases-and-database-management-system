/*Показывающий штраф на чем и сколько*/
SELECT Surname,Car_Brand, Type_Damage  FROM Client
JOIN Fine On Fine.ID_Client = Client.ID_Client
JOIN Car On Car.ID_Car = Client.ID_Client

/*Показывающий Скидку и сколько*/
SELECT Surname,Car_Brand,Discount_Percentage  FROM Client
JOIN Discounts On Discounts.ID_Client = Client.ID_Client
JOIN Car On Car.ID_Car = Client.ID_Client

/*Получить информацию обо всех автомобилях вместе с соответствующей информацией о клиенте*/
SELECT Car.ID_Car, Car.Car_Brand, Car.Car_Model, Client.Name, Client.Surname
FROM Car
LEFT JOIN Issued_Cars ON Car.ID_Car = Issued_Cars.ID_Car
LEFT JOIN Client ON Issued_Cars.ID_Client = Client.ID_Client;

/*Получить информацию о клиентах, получивших скидки, а также соответствующие данные об их автомобилях*/
SELECT Client.Name, Client.Surname, Discounts.Discount_Percentage, Car.Car_Brand, Car.Car_Model
FROM Client
LEFT JOIN Discounts ON Client.ID_Client = Discounts.ID_Client
LEFT JOIN Car ON Discounts.ID_Client = Car.ID_Car;

/*Получите скидки, применяемые к каждому клиенту, вместе с их личной информацией*/
SELECT Discounts.ID_Discounts, Client.Name, Client.Surname, Client.Address, Client.Phone_Number, Discounts.Discount_Percentage, Discounts.Number_Trips, Discounts.Req_Date
FROM Discounts
JOIN Client ON Discounts.ID_Client = Client.ID_Client;

/*Запрос из все всех таблиц*/
SELECT Date_Issue,Car_Brand,Name,Discount_Percentage,Type_Damage,Sum_Fine FROM Issued_Cars
JOIN Car ON Car.ID_Car = Issued_Cars.ID_Car
JOIN Client ON Client.ID_Client = Issued_Cars.ID_Client
JOIN Discounts ON Discounts.ID_Client = Issued_Cars.ID_Client
JOIN Fine ON Fine.ID_Client = Issued_Cars.ID_Client