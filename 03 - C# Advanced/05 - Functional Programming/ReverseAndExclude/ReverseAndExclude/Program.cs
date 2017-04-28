using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    public static class Functions
    {

        public static List<decimal> CustomReverse(this List<decimal> nums)
        {
           nums.Reverse();
           return nums;
        }

        public static List<decimal> Filter(List<decimal> list, Func<decimal, bool> func)
        {
            var result = new List<decimal>();
            foreach (var num in list)
            {
                if (func(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());
            numbers = numbers.CustomReverse();
            var output = Functions.Filter(numbers, x => x % n != 0);
            output.ForEach(x => Console.Write($"{x} "));
        }

    }
}
