using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        private static SortedDictionary<string, Dictionary<string, long>> data = new SortedDictionary<string, Dictionary<string, long>>();

        private static void CollectData(string[] inputLine)
        {
            var city = inputLine[0];
            var country = inputLine[1];
            long population = long.Parse(inputLine[2]);

            if (!data.ContainsKey(country))
            {
                data[country] = new Dictionary<string, long>();
            }
            data[country][city] = population;
        }

        public static void PrintResult()
        {
            foreach (var country in data.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var populationNumbers = data[country.Key].Values.ToList();
                Console.WriteLine($"{country.Key} (total population: {populationNumbers.Sum()})");
                foreach (var city in data[country.Key].OrderByDescending(x=> x.Value))
                {
                    if(city.Key != "TOTAL")
                    {
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    }                    
                }
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] command = new string[3];
            while(input.ToLower() != "report")
            {
                command = input.Split('|');
                CollectData(command);
                input = Console.ReadLine();
            }
            PrintResult();
        }
    }
}
