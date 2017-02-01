using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ')
                .Select(decimal.Parse).ToList();
            var special = Console.ReadLine().Split(' ').ToArray();
            int bombNumber = int.Parse(special[0]);
            int power = int.Parse(special[1]);

            while(numbers.Exists(x => x == bombNumber))
            {
                var bombIndex = numbers.FindIndex(x => x == bombNumber);

                int startIndex = Math.Max(bombIndex - power, 0);
                int repeats = Math.Min(power * 2 + 1, Math.Abs(numbers.Count - startIndex));
                numbers.RemoveRange(startIndex, repeats);
            }
            
            Console.WriteLine(numbers.Sum());
        }
    }
}
