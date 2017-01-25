using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        public static BigInteger GetFactorial(int n){
            BigInteger factorial = 1;
            
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int CountTrailingZeroes(BigInteger n)
        {
            int count = 0;
            
            while (n % 10 == 0)
            {
                var temp = n % 10;
                count++;
                n = n / 10;
            }

            return count;
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(n);
            Console.WriteLine(CountTrailingZeroes(factorial));
        }
    }
}
