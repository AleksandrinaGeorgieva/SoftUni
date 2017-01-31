using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                var sq = Math.Sqrt(numbers[i]);
                if(sq == (int)sq)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
