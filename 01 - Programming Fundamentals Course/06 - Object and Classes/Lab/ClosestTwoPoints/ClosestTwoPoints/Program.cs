using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double closestDistance = double.MaxValue;
            var points = new List<Point>();
            int outputFirstIndex = 0, outputSecondIndex = 0;
         
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                var currentPoint = new Point
                {
                    X = input[0],
                    Y = input[1]
                };
                points.Add(currentPoint);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    var distance = Point.CalculateDistance(points[i], points[j]);
                    if(distance < closestDistance)
                    {
                        closestDistance = distance;
                        outputFirstIndex = i;
                        outputSecondIndex = j;
                    }
                }
            }
            Console.WriteLine($"{closestDistance:f3}");
            Console.WriteLine($"({points[outputFirstIndex].X}, {points[outputFirstIndex].Y})");
            Console.WriteLine($"({points[outputSecondIndex].X}, {points[outputSecondIndex].Y})");
        }
    }
}
