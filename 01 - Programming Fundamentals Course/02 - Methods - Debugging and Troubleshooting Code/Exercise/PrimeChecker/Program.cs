using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        public static bool IsPrime(long n)
        {
            bool isPrime = true;

            if (n <= 1 || n % 2 == 0)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            for (int i = 3; i <= (int)Math.Sqrt(n); i += 2)
            {
                if (i != 1 && i != n && n % i == 0)
                {
                    return false;
                }
            }

            return isPrime;
        }
    }
}
