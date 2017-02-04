using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        private static Dictionary<string, long> keyMaterials = new Dictionary<string, long>();
        private static Dictionary<string, long> junk = new Dictionary<string, long>();
        private static Dictionary<string, string> legendaryItems = new Dictionary<string, string>();
        private static int price = 250;

        private static void InitMaterials()
        {
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            legendaryItems.Add("shards", "Shadowmourne");
            legendaryItems.Add("fragments", "Valanyr");
            legendaryItems.Add("motes", "Dragonwrath");
        }

        private static void PrintKeyMaterials()
        {
            var temp = keyMaterials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToList();
            temp.ForEach(x => Console.WriteLine($"{x.Key}: {x.Value}"));
        }

        private static void PrintJunk()
        {
            var temp = junk
                .OrderBy(x => x.Key)
                .ToList();
            temp.ForEach(x => Console.WriteLine($"{x.Key}: {x.Value}"));
        }

        static void Main(string[] args)
        {
            InitMaterials();
            bool obtained = false;
            string[] pairs = new string[50];
            while(obtained == false)
            {
                pairs = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                for (int i = 0; i < pairs.Length; i+=2)
                {
                    long quantity = long.Parse(pairs[i]);
                    string material = pairs[i+1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;                
                    }else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }

                    if (keyMaterials.Values.ToList().Exists(x => x >= price))
                    {
                        obtained = true;
                        var item = keyMaterials
                                .Where(x => x.Value >= price)
                                .First()
                                .Key;
                        keyMaterials[item] -= price;
                        Console.WriteLine(legendaryItems[item] + " obtained!");
                        PrintKeyMaterials();
                        PrintJunk();
                        break;
                    }
                }
                                
            }
        }
    }
}
