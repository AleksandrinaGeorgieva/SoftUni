using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split();
            var searchType = Console.ReadLine();
            int min = int.Parse(numbers[0]);
            int max = int.Parse(numbers[1]);

            Predicate<int> odd = x => x % 2 != 0;
            Predicate<int> even = x => x % 2 == 0;

            var list = new List<int>();
            for (int i = min; i <= max; i++)
            {
                list.Add(i);
            }

            var result = new List<int>();

            if(searchType == "odd")
            {
                result = list.FindAll(odd);
            }else
            {
                result = list.FindAll(even);
            }

            result.ForEach(x => Console.Write($"{x} "));
        }
    }
}
