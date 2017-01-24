using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        public static double MathPower(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(num, powerNumber));
        }
    }
}
