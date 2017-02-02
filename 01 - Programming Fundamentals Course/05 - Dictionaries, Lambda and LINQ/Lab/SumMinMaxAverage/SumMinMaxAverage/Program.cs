using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                list.Add(temp);
            }

            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");

        }
    }
}
