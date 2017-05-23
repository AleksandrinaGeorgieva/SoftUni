using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age)
            : this()
        {
            this.age = age;
        }

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var age = int.Parse(input[1]);
                people.Add(new Person
                {
                    name = name,
                    age = age
                });
            }

            people
                .Where(x => x.age > 30)
                .OrderBy(x => x.name)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.name} - {x.age}"));
        }
    }
}
