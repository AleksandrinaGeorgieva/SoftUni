using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengths = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var firstHashSet = new HashSet<int>();
            var secondHashSet = new HashSet<int>();

            for (int i = 0; i < lengths[0]; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                firstHashSet.Add(temp);
            }

            for (int i = 0; i < lengths[1]; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                secondHashSet.Add(temp);
            }

            var intersectionSet = firstHashSet.Intersect(secondHashSet);

            foreach (var item in intersectionSet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
