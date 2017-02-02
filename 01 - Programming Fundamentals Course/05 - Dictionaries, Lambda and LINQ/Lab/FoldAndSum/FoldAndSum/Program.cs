using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int k = numbers.Count / 4;
            var firstNumbers = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var centerNumbers = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var secondNumbers = numbers
                .Skip(3 * k)
                .Take(k)
                .Reverse()
                .ToArray();

            var numbersToFold = firstNumbers.Concat(secondNumbers);
            var result = centerNumbers
                .Zip(numbersToFold, (first, second) => first + second)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
