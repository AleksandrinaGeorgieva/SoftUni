using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        public static double CalculateTriangleArea(double a, double h)
        {
            return a * h / 2;
        }

        static void Main(string[] args)
        {
            double baseLength = double.Parse(Console.ReadLine());
            double altitudeLength = double.Parse(Console.ReadLine());

            double result = CalculateTriangleArea(baseLength, altitudeLength);
            Console.WriteLine(result);
        }
    }
}
