using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    class Program
    {
        private static int Comparator(int a, int b)
        {
            if(a % 2 == 0 && b % 2 != 0)
            {
                return -1;
            }
            if(a % 2 != 0 && b % 2 == 0)
            {
                return 1;
            }
            return a - b;
        }

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Array.Sort(numbers, Comparator);
            var list = numbers.ToList();
            list.ForEach(x => Console.Write($"{x} "));

        }
    }
}
