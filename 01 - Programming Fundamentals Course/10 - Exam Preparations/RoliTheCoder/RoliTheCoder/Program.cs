using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class Program
    {
        private static Dictionary<string, Event> events = new Dictionary<string, Event>();

        private static void ParseInput(string input)
        {
            var splitted = input
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var id = splitted[0];
            string tmpName = "";
            if (splitted[1][0] == '#')
            {
                tmpName = splitted[1];

                if (!events.ContainsKey(id))
                {
                    events[id] = new Event
                    {
                        name = tmpName,
                        participants = new List<string>()
                    };
                }

                if (events[id].name == tmpName)
                {
                    for (int i = 2; i < splitted.Length; i++)
                    {
                        if (!events[id].participants.Contains(splitted[i]))
                        {
                            events[id].participants.Add(splitted[i]);
                        }
                    }
                }
            }
        }

        private static void PrintResults()
        {
            var sorted = events
                .OrderByDescending(x => x.Value.participants.Count)
                .ThenBy(x => x.Value.name)
                .ToDictionary(x => x.Key, x=> x.Value);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Value.name.Substring(1)} - {item.Value.participants.Count}");
                var sortedPart = item.Value.participants
                    .OrderBy(x => x)
                    .ToList();
                for (int i = 0; i < item.Value.participants.Count; i++)
                {
                    Console.WriteLine(sortedPart[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while(input != "Time for Code")
            {
                
                ParseInput(input);
                input = Console.ReadLine();
            }

            PrintResults();
        }
    }
}
