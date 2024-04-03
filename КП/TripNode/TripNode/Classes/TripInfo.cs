using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripNode.Classes
{
    public class TripInfo
    {
        public string UserLogin { get; set; }
        public string CarName { get; set; }
        public string RoutePointA { get; set; }
        public string RoutePointB { get; set; }
        public double Distance { get; set; }
        public double Consumption { get; set; }
        public double AverageConsumption { get; set; }
        public DateTime TripDate { get; set; }
        public decimal Price { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }

        public TripInfo(string userLogin, string carName, string routePointA, string routePointB,
                        double distance, double consumption, double averageConsumption, DateTime tripDate,
                        decimal price, DateTime timeStart, DateTime timeFinish)
        {
            UserLogin = userLogin;
            CarName = carName;
            RoutePointA = routePointA;
            RoutePointB = routePointB;
            Distance = distance;
            Consumption = consumption;
            AverageConsumption = averageConsumption;
            TripDate = tripDate;
            Price = price;
            TimeStart = timeStart;
            TimeFinish = timeFinish;
        }
    }
}
