using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var firstCenter = new Point
            {
                X = firstInput[0],
                Y = firstInput[1]
            };
            var firstCircle = new Circle
            {
                center = firstCenter,
                radius = firstInput[2]
            };

            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondCenter = new Point
            {
                X = secondInput[0],
                Y = secondInput[1]
            };
            var secondCircle = new Circle
            {
                center = secondCenter,
                radius = secondInput[2]
            };

            var result = Circle.Intersect(firstCircle, secondCircle) ? "Yes" : "No";
            Console.WriteLine(result);
        }
    }
}
