using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        private static string ReverseString(string text)
        {
            string result = "";
            char[] letters = text.ToCharArray();
            var a = letters.Reverse().ToArray();
            result = new string(a);
            return result;
        }

        static void Main(string[] args)
        {
            List<string> stringNumbers = Console.ReadLine().Split(' ').ToList();
            List<decimal> numbers = new List<decimal>();
            for (int i = 0; i < stringNumbers.Count; i++)
            {
                string nums = ReverseString(stringNumbers[i]);
                numbers.Add(int.Parse(nums));
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
