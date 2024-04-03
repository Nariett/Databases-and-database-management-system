using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripNode.Classes
{
    public class Fuel
    {
        public int FuelId { get; set; }
        public string FuelType { get; set; }
        public string OctaneNumber { get; set; }
        public double FuelPrice { get; set; }
        public Fuel(string fuelType, string octaneNumber, double fuelPrice)
        {
            FuelType = fuelType;
            OctaneNumber = octaneNumber;
            FuelPrice = fuelPrice;
        }
        public Fuel(int fuelId, string fuelType, string octaneNumber, double fuelPrice)
        {
            FuelId = fuelId;
            FuelType = fuelType;
            OctaneNumber = octaneNumber;
            FuelPrice = fuelPrice;
        }
    }
}
