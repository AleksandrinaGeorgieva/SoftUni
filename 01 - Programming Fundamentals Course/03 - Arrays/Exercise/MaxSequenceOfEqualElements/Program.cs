using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            numbers = numbers.Reverse().ToArray();

            int count = 0;
            int currentNumber = numbers[0];
            int longestCount = 0;
            int longestNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (currentNumber != numbers[i])
                {
                    count = 1;
                }
                else
                {
                    count++;
                }
                currentNumber = numbers[i];
                if (longestCount <= count)
                {
                    longestCount = count;
                    longestNumber = currentNumber;
                }
            }
             var result = Enumerable.Repeat(longestNumber, longestCount);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
