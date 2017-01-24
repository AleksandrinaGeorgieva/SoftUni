using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        public static void PrintLine(int end = 5)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write("{0} ", i);
            };
            Console.WriteLine();
        }

        public static void PrintTop(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
        }

        public static void PrintBottom(int n)
        {
            for (int i = n-1; i > 0; i--)
            {
                PrintLine(i);
            }
        }

        public static void PrintTriangle(int n = 5)
        {
            PrintTop(n);
            PrintBottom(n);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

        }
    }
}
