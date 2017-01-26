using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("{ " + numbers[0] + " }");
            }
            else if (numbers.Length % 2 == 0)
            {
                int index = numbers.Length / 2;
                Console.WriteLine("{ " + numbers[index - 1] + ", " + numbers[index] + " }");
            }
            else
            {
                int index = (int)Math.Floor(numbers.Length / 2.0);
                Console.WriteLine("{ " + numbers[index - 1] + ", " + numbers[index] + ", " + numbers[index + 1] + " }");
            }
        }
    }
}
