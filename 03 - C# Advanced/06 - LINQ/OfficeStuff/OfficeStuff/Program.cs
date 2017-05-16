using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeStuff
{
    public class Company
    {
        public string name { get; set; }
        public Dictionary<string, int> productsAmountData { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Company>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '|', '-'}, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var amount = int.Parse(input[1]);
                var product = input[2];

                if(!data.ContainsKey(name))
                {
                    data.Add(name, new Company
                    {
                        name = name,
                        productsAmountData = new Dictionary<string, int>()
                    });
                }
                if (!data[name].productsAmountData.ContainsKey(product))
                {
                    data[name].productsAmountData[product] = 0;
                }
                data[name].productsAmountData[product] += amount;

            }

            var ordered = data
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in ordered)
            {
                Console.Write($"{item.Key}: ");
                var productsToPrint = item.Value.productsAmountData
                    .Select(x => $"{x.Key}-{x.Value}")
                    .ToList();

                Console.WriteLine(string.Join(", ", productsToPrint));
            }

        }
    }
}
