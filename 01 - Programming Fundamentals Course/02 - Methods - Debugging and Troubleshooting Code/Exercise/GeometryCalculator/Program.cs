using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        public static void CalculateTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * height / 2);
        }

        public static void CalculateSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * side);
        }

        public static void CalculateRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", width * height);
        }

        public static void CalculateCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", Math.PI * radius * radius);
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "triangle": CalculateTriangleArea(); break;
                case "square": CalculateSquareArea(); break;
                case "rectangle": CalculateRectangleArea();  break;
                case "circle": CalculateCircleArea(); break;
            }
        }
    }
}
