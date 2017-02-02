using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            numbers = numbers
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();
            numbers.ForEach(x => Console.Write($"{x} "));
        }
    }
}
