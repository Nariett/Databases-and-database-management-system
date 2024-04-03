using System;
using System.Security.RightsManagement;

namespace TripNode.Classes
{
    class Trips
    {
        public int idUser { get; set; } // id Пользователя
        public int idCar { get; set; } // id Автомобиля
        public int idRoute { get; set; } // id Маршрута
        public double distance { get; set; } // Расстоярние поездки 
        public double consumption { get; set; } // Потребление общее
        public double averageConsumption { get; set; } // Потребление за км
        public string date { get; set; } // Дата совершения поезкди
        public double price { get; set; } // Сумма поездки 
        public DateTime timeStart { get; set; } // Дата отправки 
        public DateTime timeFinish { get; set; } // Дата прибытия

        public Trips() { }
        public Trips(int idUser, int idCar, int idRoute, double distance, double consumption, double averageConsumption, string date, double price, DateTime timeStart, DateTime timeFinish)
        {
            this.idUser = idUser;
            this.idCar = idCar;
            this.idRoute = idRoute;
            this.distance = distance;
            this.consumption = consumption;
            this.averageConsumption = averageConsumption;
            this.date = date;
            this.price = price;
            this.timeStart = timeStart;
            this.timeFinish = timeFinish;
        }
    }
}
