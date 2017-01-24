using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        public static int GetSumOfNumbers(int n, bool even)
        {
            int result = 0;
            var absoluteNumber = Math.Abs(n).ToString();
            foreach (var symbol in absoluteNumber)
            {
                int currentDigit = (int)Char.GetNumericValue(symbol);
                if ((currentDigit % 2 == 0) == even)
                {
                        result += currentDigit;
                }
            }

            return result;
        }

        public static int GetMultipleOfEvenAndOdds(int n)
        {
            return GetSumOfNumbers(n, true) * GetSumOfNumbers(n, false);
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
    }
}
