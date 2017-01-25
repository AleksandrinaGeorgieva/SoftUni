using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        public static double CalculateFaceDiagonal(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

        public static double CalculateSpace(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        public static double CalculateVolume(double side)
        {
            return side * side * side;
        }

        public static double CalculateArea(double side)
        {
            return side * side * 6;
        }

        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face": 
                    Console.WriteLine("{0:f2}", CalculateFaceDiagonal(cubeSide)); break;
                case "space":
                    Console.WriteLine("{0:f2}", CalculateSpace(cubeSide)); break;
                case "volume": Console.WriteLine("{0:f2}", CalculateVolume(cubeSide)); break;
                case "area": Console.WriteLine("{0:f2}", CalculateArea(cubeSide)); break;
            }
        }
    }
}
