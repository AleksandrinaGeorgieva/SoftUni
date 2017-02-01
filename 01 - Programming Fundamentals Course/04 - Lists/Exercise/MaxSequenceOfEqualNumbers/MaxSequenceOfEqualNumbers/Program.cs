using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualNumbers
{
    class Program
    {
        private static int maxLength = -1;
        private static decimal maxNumber = -1;

        public static void CheckIsMax(decimal number, List<decimal> nums)
        {
            int count = nums.FindAll(x => x == number).Count;
            if (count >= maxLength)
            {
                maxLength = count;
                maxNumber = number;
            }
        }

        static void Main(string[] args)
        {
            List <decimal> numbers = Console.ReadLine().Split(' ')
                .Select(decimal.Parse).ToList();
            numbers.Reverse();

            numbers.ForEach(x => CheckIsMax(x, numbers));
            Console.WriteLine(string.Concat(Enumerable.Repeat($"{maxNumber} ", maxLength)));
        }
    }
}
