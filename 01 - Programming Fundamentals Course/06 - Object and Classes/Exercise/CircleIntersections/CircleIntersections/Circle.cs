using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleIntersections
{
    class Circle
    {
        public Point center { get; set; }
        public double radius { get; set; }

        public static bool Intersect (Circle c1, Circle c2)
        {
            var diff = Point.CalculateDistance(c1.center, c2.center);
            return diff <= c1.radius + c2.radius;
        }
    }
}
