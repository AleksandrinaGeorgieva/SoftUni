using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        public static int GetFibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                number = a + b;
                a = b;
                b = number;
            }
            return number;
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(n));
        }
    }
}
