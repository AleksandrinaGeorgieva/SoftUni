using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var first = new List<List<int>>();
            var second = new List<List<int>>();
            var arraysRowLengths = new List<int>();

            //fill firstArray
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                first.Add(input);
                arraysRowLengths.Add(input.Count);
            }

            //fill second array
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                second.Add(input);
                arraysRowLengths[i] += input.Count;
            }

            bool match = arraysRowLengths.All(x => x == arraysRowLengths.First());
            if (match)
            {
                for (int i = 0; i < n; i++)
                {
                    var addition = second[i];
                    addition.Reverse();
                    first[i].AddRange(addition);
                    Console.WriteLine($"[{string.Join(", ", first[i])}]");
                }

            }else
            {
                Console.WriteLine($"The total number of cells is: {arraysRowLengths.Sum()}");
            }
        }
    }
}
