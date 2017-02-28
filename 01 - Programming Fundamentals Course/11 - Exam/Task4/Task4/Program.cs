using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Legion>();
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine(); ;
                var firstSplit = input.Split('=');
                long lastActivity = long.Parse(firstSplit[0].Trim());
                var indexOfArrow = firstSplit[1].Trim().IndexOf(" -> ");
                string legionName = firstSplit[1].Trim().Substring(0, indexOfArrow);
                var lastPiece = firstSplit[1].Trim().Substring(indexOfArrow + 4);
                var splitAgain = lastPiece.Trim().Split(':');
                string soldierType = splitAgain[0];
                long soldierCount = long.Parse(splitAgain[1]);

                if (!dict.ContainsKey(legionName))
                {
                    dict[legionName] = new Legion
                    {
                        name = legionName,
                        lastActivity = lastActivity,
                        soldiers = new Dictionary<string, long>()
                    };
                }

                if (!dict[legionName].soldiers.ContainsKey(soldierType))
                {
                    dict[legionName].soldiers[soldierType] = 0;
                }
                dict[legionName].soldiers[soldierType] += soldierCount;

                if(lastActivity > dict[legionName].lastActivity)
                {
                    dict[legionName].lastActivity = lastActivity;
                }
            }

            var outputType = Console.ReadLine();
            if (outputType.Contains("\\"))
            {
                var spl = outputType.Split('\\');
                long lastA = long.Parse(spl[0]);
                string type = spl[1];
                var sorted = dict
                    .Where(x => x.Value.soldiers.ContainsKey(type))
                .OrderByDescending(x => x.Value.soldiers[type])
                .ToDictionary(x => x.Key, x => x.Value);
                foreach (var legion in sorted)
                {
                    if (legion.Value.lastActivity < lastA)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value.soldiers[type]}");
                    }
                }                
            }else
            {
                var solType = outputType;
                var d = dict
                    .Where(x => x.Value.soldiers.ContainsKey(solType))
                    .OrderByDescending(x => x.Value.lastActivity)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var s in d)
                {
                    Console.WriteLine($"{s.Value.lastActivity} : {s.Value.name}");
                }
            }
        }
    }
}
