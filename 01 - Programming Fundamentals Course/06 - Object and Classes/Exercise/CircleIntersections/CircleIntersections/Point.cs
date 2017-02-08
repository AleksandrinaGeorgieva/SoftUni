using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleIntersections
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static double CalculateDistance(Point a, Point b)
        {
            var diffX = Math.Pow(a.X - b.X, 2);
            var diffY = Math.Pow(a.Y - b.Y, 2);
            return Math.Sqrt(diffX + diffY);
        }
    }
}
