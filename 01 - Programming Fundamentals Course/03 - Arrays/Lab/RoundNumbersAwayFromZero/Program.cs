using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double temp = Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", array[i], temp);
            }
        }
    }
}
