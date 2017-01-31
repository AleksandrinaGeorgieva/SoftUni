using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();

            if(numbers.Count < 1)
            {
                Console.WriteLine("empty");
            }else
            {
                numbers.ForEach(x => Console.Write($"{x} "));
            }
        }
    }
}
