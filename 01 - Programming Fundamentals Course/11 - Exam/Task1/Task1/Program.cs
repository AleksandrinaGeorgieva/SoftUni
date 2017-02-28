using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            long windFlaps = long.Parse(Console.ReadLine());
            double distanceFor1000WingFlaps = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            var distance = windFlaps / 1000 * distanceFor1000WingFlaps;
            Console.WriteLine($"{distance:f2} m.");

            var time = (windFlaps / 100) + (windFlaps / endurance * 5);
            Console.WriteLine($"{time} s.");
        }
    }
}
