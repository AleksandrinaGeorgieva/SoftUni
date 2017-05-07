using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyReservationFilterModule
{
    class Program
    {
        private static Dictionary<string, Func<string, string, bool>> predicates = new Dictionary<string, Func<string, string, bool>> {
            { "Starts with", (name, condition) => name.StartsWith(condition)},
            { "Ends with", (name, condition) => name.EndsWith(condition)},
            { "Length", (name, condition) => name.Length.ToString().Equals(condition)},
            { "Contains", (name, condition) => name.Contains(condition)}
        };

        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var filters = new List<string>();

            var command = Console.ReadLine();

            while(command.ToLower() != "print")
            {
                var splitted = command.Split(';');
                var filter = $"{splitted[1]};{splitted[2]}";
                if (splitted[0].Contains("Add"))
                {
                    filters.Add(filter);
                }else
                {
                    if (filters.Contains(filter))
                    {
                        filters.Remove(filter);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < filters.Count; i++)
            {
                var currentFilter = filters[i].Split(';');
                names.RemoveAll(x => predicates[currentFilter[0]](x, currentFilter[1]));
            }

            names.ForEach(x => Console.Write($"{x} "));

        }
    }
}
