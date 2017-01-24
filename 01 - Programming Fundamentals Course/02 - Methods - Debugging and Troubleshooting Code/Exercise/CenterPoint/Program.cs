using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        public static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstPointDistance = Math.Abs(x1) + Math.Abs(y1);
            double secondPointDistance = Math.Abs(x2) + Math.Abs(y2);
            if (firstPointDistance > secondPointDistance)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }
        
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }
    }
}
