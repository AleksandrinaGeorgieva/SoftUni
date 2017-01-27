using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        public static bool TrueValue(bool b)
        {
            return b;
        }

        public static void PrintPrimes(bool[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.Write("{0} ", i);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = Enumerable.Repeat(true, n + 1).ToArray();

            primes[0] = primes[1] = false;

            int p = Array.FindIndex(primes, TrueValue);
            if (p > 0)
            {
                for (int i = p; i <= n; i++)
                {

                    for (int j = i; j < primes.Length; j++)
                    {
                        int index = i * j;
                        if (index < primes.Length)
                        {
                            primes[index] = false;
                        }
                    }
                }
            }
            PrintPrimes(primes);
        }
    }
}
