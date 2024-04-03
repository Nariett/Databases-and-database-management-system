using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripNode.Classes
{
    public class Car
    {
        public string name { get; set; } // Название автомобиля
        public int year { get; set; } // Год выпуска 
        public string typeCar { get; set; } // Кузов автомобиля
        public int maxSpeed { get; set; } // Максимальная скорость
        public int seatingCapacity { get; set; } // Кол-во мест
        public string fuel { get; set; } // Вид топилва
        public string fuelOctan { get; set; } // Октановое число
        public double fuelConsumptionGeneral { get; set; } //среднее потребление топлива
        public Car() { }
        public Car(string name, int year, string typeCar, int maxSpeed, int seatingCapacity, string fuel, string fuelOctan, double fuelConsumptionGeneral)
        {
            this.name = name;
            this.year = year;
            this.typeCar = typeCar;
            this.maxSpeed = maxSpeed;
            this.seatingCapacity = seatingCapacity;
            this.fuel = fuel;
            this.fuelOctan = fuelOctan;
            this.fuelConsumptionGeneral = fuelConsumptionGeneral;
        }

        public string FixStr(double x)
        {
            return x.ToString().Replace('.', ',');
        }
    }
}
