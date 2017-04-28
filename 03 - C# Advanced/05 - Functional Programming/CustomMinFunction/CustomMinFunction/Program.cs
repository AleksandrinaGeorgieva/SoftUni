using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            Func<decimal[], decimal> min = MinNumber;
            var result = min(numbers);
            Console.WriteLine(result);

        }

        public static decimal MinNumber (decimal[] nums)
        {
            return nums.Min();
        }
    }
}
