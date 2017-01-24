using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        public static void PrintBorder(int n)
        {
            Console.WriteLine(new string ('-', n * 2));
        }

        public static void PrintMiddleSquare(int n)
        {
            for (int i = 0, len = n - 2; i < len; i++)
            {
                Console.WriteLine(
                    '-'
                    + String.Concat(Enumerable.Repeat("\\/", n-1))
                    + '-'
                    );
            }
        }

        public static void PrintSquare(int n)
        {
            PrintBorder(n);
            PrintMiddleSquare(n);
            PrintBorder(n);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
        }
    }
}
