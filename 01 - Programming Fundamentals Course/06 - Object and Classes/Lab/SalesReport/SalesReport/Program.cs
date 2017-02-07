using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sales = new List<Sale>();
            var temp = new Sale();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                temp = new Sale
                {
                    town = input[0],
                    product = input[1],
                    price = double.Parse(input[2]),
                    quantity = double.Parse(input[3])
                };
                sales.Add(temp);
            }

            var towns = sales
                .Select(x => x.town)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
            for (int i = 0; i < towns.Length; i++)
            {
                var currentTown = towns[i];
                var salesForTown = sales
                    .Where(x => x.town == currentTown)
                    .Select(s => s.price * s.quantity)
                    .Sum();
                Console.WriteLine($"{currentTown} -> {salesForTown:f2}");
            }
        }
    }
}
