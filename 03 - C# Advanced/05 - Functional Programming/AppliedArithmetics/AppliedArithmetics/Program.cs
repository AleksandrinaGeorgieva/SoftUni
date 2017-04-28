using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    public static class Functions
    {
        public static void Print(List<decimal> collection)
        {
            collection.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static List<decimal> ApplyFunction (List<decimal> collection, Func<decimal,decimal> function)
        {
            var result = new List<decimal>();
            foreach (var item in collection)
            {
                var modified = function(item);
                result.Add(modified);
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            var input = Console.ReadLine();

            while(input.ToLower() != "end")
            {
                switch (input)
                {
                    case "add":
                        numbers = Functions.ApplyFunction(numbers, x => x + 1);
                        break;
                    case "multiply":
                        numbers = Functions.ApplyFunction(numbers, x => x * 2);
                        break;
                    case "subtract":
                        numbers = Functions.ApplyFunction(numbers, x => x - 1);
                        break;
                    case "print":
                        Functions.Print(numbers);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
