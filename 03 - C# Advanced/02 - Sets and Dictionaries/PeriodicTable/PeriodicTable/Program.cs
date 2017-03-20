using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            int counter = n;
            while (counter-- != 0)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var t = new HashSet<string>(input);
                data.UnionWith(t);
            }

            foreach (var item in data)
            {
                Console.Write($"{item} ");
            }
        }
    }
}