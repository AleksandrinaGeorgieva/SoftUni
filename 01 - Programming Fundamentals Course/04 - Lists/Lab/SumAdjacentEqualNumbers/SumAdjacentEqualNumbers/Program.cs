using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        public static int CheckForEqualNumbers(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }

        public static void SumFirstAdjacentEqualNumbers(List<double> numbers, int index)
        {
            numbers[index] += numbers[index + 1];
            numbers.RemoveAt(index + 1);
        }

        static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine()
                .Split(' ').Select(double.Parse).ToList();

            while(CheckForEqualNumbers(inputNumbers) > -1)
            {
                SumFirstAdjacentEqualNumbers(inputNumbers, CheckForEqualNumbers(inputNumbers));
            }

            inputNumbers.ForEach(x => Console.Write($"{x} "));
        }
    }
}
