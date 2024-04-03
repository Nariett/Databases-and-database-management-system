using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripNode.Classes
{
    class Route
    {
        public string cityOne { get; set; } // Точка отправления
        public string cityTwo { get; set; } // Точка прибытия
        public double distance { get; set; } // Расстояние
        public Route() { }
        public Route(string cityOne, string cityTwo, double distance)
        {
            this.cityOne = cityOne;
            this.cityTwo = cityTwo;
            this.distance = distance;
        }
    }
}
