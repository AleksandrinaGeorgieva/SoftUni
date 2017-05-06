using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateParty
{
    class Program
    {
        private static List<string> names = new List<string>();
        private static Dictionary<string, Func<string, string, bool>> predicates = new Dictionary<string, Func<string, string, bool>>
        {
            { "StartsWith", (name, condition) => name.StartsWith(condition) },
            { "EndsWith", (name, condition) => name.EndsWith(condition)},
            { "Length", (name, condition) => name.Length.ToString().Equals(condition)}
        };

        static void Main(string[] args)
        {
            names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var outputNames = new List<string>();
            var input = Console.ReadLine();
            while(input.ToLower() != "party!")
            {
                var splitted = input.Split();
                var command = splitted[0];
                var condition = splitted[1];
                var criteria = splitted[2];

                if(command == "Remove")
                {
                    names.RemoveAll(x => predicates[condition](x, criteria));
                }else
                {
                    var matches = names.FindAll(x => predicates[condition](x, criteria));

                    foreach (var m in matches)
                    {
                        var index = names.FindIndex(x => x == m);
                        names.Insert(index, m);
                    }

                }              
                input = Console.ReadLine();
            }

            if(names.Count > 0)
            {
                var outputNamesString = string.Join(", ", names);
                Console.WriteLine($"{outputNamesString} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }            
        }
    }
}
