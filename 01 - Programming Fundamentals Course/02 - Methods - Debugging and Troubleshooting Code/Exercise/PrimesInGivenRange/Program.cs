using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        public static bool IsPrime(long n)
        {
            bool isPrime = true;

            if (n == 2)
            {
                return true;
            }

            if (n <= 1 || n % 2 == 0)
            {
                return false;
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

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> numbersList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    numbersList.Add(i);
                }
            }
            return numbersList;
        }

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> result = FindPrimesInRange(start, end);
            if (result.Any())
            {
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("(empty list)");
            }            
        }
    }
}
