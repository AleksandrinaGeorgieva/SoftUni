using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        public static double LineWidthParam(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }

        public static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double firstPointDistance = Math.Abs(x1) + Math.Abs(y1);
            double secondPointDistance = Math.Abs(x2) + Math.Abs(y2);
            if (firstPointDistance > secondPointDistance)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
        }

        public static void PrintLongerLine()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineWidthParam = LineWidthParam(x1, y1, x2, y2);
            double secondLineWidthParam = LineWidthParam(x3, y3, x4, y4);

            if (secondLineWidthParam > firstLineWidthParam)
            {
                PrintLine( x3, y3, x4, y4);
            }
            else
            {
                PrintLine(x1, y1, x2, y2);
            }

        }

        static void Main(string[] args)
        {
            PrintLongerLine();
        }
    }
}
