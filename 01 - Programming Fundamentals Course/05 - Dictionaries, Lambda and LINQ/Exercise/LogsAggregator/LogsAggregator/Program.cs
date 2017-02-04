using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        private static new SortedDictionary<string, Dictionary<string, List<string>>> data = new SortedDictionary<string, Dictionary<string, List<string>>>();

        private static void CollectData(string[] input)
        {
            string name, ip; int duration;
            ip = input[0];
            name = input[1];
            duration = int.Parse(input[2]);

            if (!data.ContainsKey(name))
            {
                data[name] = new Dictionary<string, List<string>>();
                data[name]["DURATION"] = new List<string>();
                data[name]["IPs"] = new List<string>();
            }
            data[name]["DURATION"].Add(duration.ToString());
            data[name]["IPs"].Add(ip);
        }

        private static void PrintAggregatedData()
        {
            foreach (var user in data)
            {
                var duration = data[user.Key]["DURATION"]
                    .Select(int.Parse)
                    .Sum();
                var uniqueIps = data[user.Key]["IPs"]
                    .Distinct()
                    .OrderBy(x => x);
                var ips = "[" + string.Join(", ", uniqueIps) + "]";
                Console.WriteLine($"{user.Key}: {duration} {ips}");
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                CollectData(input);
            }
            PrintAggregatedData();
        }
    }
}
