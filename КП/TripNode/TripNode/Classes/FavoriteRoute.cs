using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripNode.Classes
{
    public class FavoriteRoute
    {
        public string PointA; // Точка отправки
        public string PointB; // Точка прибытия
        public FavoriteRoute(string pointA, string pointB)
        {
            PointA = pointA;
            PointB = pointB;
        }
    }
}
