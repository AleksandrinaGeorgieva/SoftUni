using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{

    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var firstPoint = new Point
            {
                X = firstInput[0],
                Y = firstInput[1]
            };

            var secondPoint = new Point
            {
                X = secondInput[0],
                Y = secondInput[1]
            };
            var result = Point.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }
    }
}
