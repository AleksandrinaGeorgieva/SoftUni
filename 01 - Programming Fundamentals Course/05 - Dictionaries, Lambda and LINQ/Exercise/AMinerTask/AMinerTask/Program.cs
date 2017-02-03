using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();
            var resourceInput = Console.ReadLine();
            while(resourceInput.ToLower() != "stop")
            {
                if (!resources.ContainsKey(resourceInput))
                {
                    resources[resourceInput] = 0;
                }
                resources[resourceInput] += long.Parse(Console.ReadLine());
                resourceInput = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
