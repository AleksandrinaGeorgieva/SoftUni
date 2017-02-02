using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var counts = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!counts.ContainsKey(numbers[i]))
                {
                    counts[numbers[i]] = 0;
                }
                counts[numbers[i]]++;
            }
           counts = counts
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x=> x.Value);
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
