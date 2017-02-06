using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        private static Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> data = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

        private static Dictionary<string, int> defaultValues = new Dictionary<string, int>
        {
            { "damage", 45},
            { "health", 250},
            { "armor", 10}
        };
        private static int n = 0;

        private static void CollectDragonData(string[] input)
        {
            string type = input[0],
                name = input[1];
            int tempInt;

            if (!data.ContainsKey(type))
            {
                data[type] = new SortedDictionary<string, Dictionary<string, int>>();
            }
            if (!data[type].ContainsKey(name))
            {
                data[type][name] = defaultValues.ToDictionary(x => x.Key, x => x.Value);
            }
            /* try to parse the damage */
            if(int.TryParse(input[2], out tempInt)){
                data[type][name]["damage"] = int.Parse(input[2]);
            }
            /* try to parse the health */
            if (int.TryParse(input[3], out tempInt))
            {
                data[type][name]["health"] = int.Parse(input[3]);
            }
            /* try to parse the armor */
            if (int.TryParse(input[4], out tempInt))
            {
                data[type][name]["armor"] = int.Parse(input[4]);
            }
        }

        private static void PrintData()
        {            
            foreach (var type in data)
            {                
                PrintTypeData(type);
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine(
                        $"-{dragon.Key} -> damage: {dragon.Value["damage"]}, health: {dragon.Value["health"]}, armor: {dragon.Value["armor"]}"
                        );
                }
            }
        }

        private static void PrintTypeData(KeyValuePair<string, SortedDictionary<string, Dictionary<string, int>>> type)
        {
            var damages = type.Value
                    .SelectMany(x => x.Value.Where(y => y.Key == "damage"))
                    .ToArray();
            double avgDamage = damages.Average(x => x.Value);
            var armors = type.Value
                .SelectMany(x => x.Value.Where(y => y.Key == "armor"))
                .ToArray();
            double avgArmor = armors.Average(x => x.Value);
            var healths = type.Value
                .SelectMany(x => x.Value.Where(y => y.Key == "health"))
                .ToArray();
            double avgHealth = healths.Average(x => x.Value);
            Console.WriteLine($"{type.Key}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");
        }

        private static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            var input = new string[5];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                CollectDragonData(input);
            }
            PrintData();
        }
    }
}
