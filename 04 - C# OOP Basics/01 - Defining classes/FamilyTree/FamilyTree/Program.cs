using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FamilyTree
{
    class Person
    {
        public string name;
        public string date;
        public List<Person> parents;
        public List<Person> children;
    }

    class Program
    {
        private static Regex fullNameRegex = new Regex(@"\w+\s+\w+");
        private static Regex dateRegex = new Regex(@"\d{1,2}\/\d{1,2}\/\d{4}");

        private static bool ExtractBirthDates(string input, out string[] dates)
        {
            Regex reg = new Regex(@"\d{1,2}\/\d{1,2}\/\d{4}");
            dates = reg.Matches(input)
                .Cast<Match>()
                .Select(x => x.ToString())
                .ToArray();
            return dates.Length > 0;
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var family = new List<Person>();
            var commands = new List<string>();
            
            var inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                var spl = inputLine
                    .Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (spl.Length == 1)
                {
                    //one man info
                    var date = dateRegex.Match(spl[0]).Value;
                    var name = fullNameRegex.Match(spl[0]).Value;

                    family.Add(new Person
                    {
                        name = name,
                        date = date,
                        children = new List<Person>(),
                        parents = new List<Person>()
                    });
                }else
                {
                    commands.Add(inputLine);
                }
                inputLine = Console.ReadLine();

            }

                foreach (var item in commands)
                {
                    var spl = item
                    .Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                    Person first;
                    Person second;

                    if (dateRegex.IsMatch(spl[0]))
                    {
                        first = family
                            .First(x => x.date == spl[0]);
                    }else
                    {
                        first = family
                            .First(x => x.name == spl[0]);
                    }

                    if (dateRegex.IsMatch(spl[1]))
                    {
                        second = family
                            .First(x => x.date == spl[1]);
                    }
                    else
                    {
                        second = family
                            .First(x => x.name == spl[1]);
                    }

                    first.children.Add(second);
                    second.parents.Add(first);
                }

                family = family
                     .Where(x => x.date != null && x.name != null)
                     .ToList();

            Person outputPerson = family
                    .First(x => x.date == input
                    || x.name == input);
            

            Console.WriteLine($"{outputPerson.name} {outputPerson.date}");
            Console.WriteLine("Parents:");
            foreach (var parent in outputPerson.parents)
            {
                Console.WriteLine($"{parent.name} {parent.date}");
            }
            Console.WriteLine("Children:");
            foreach (var child in outputPerson.children)
            {
                Console.WriteLine($"{child.name} {child.date}");
            }

        }
    }
}
