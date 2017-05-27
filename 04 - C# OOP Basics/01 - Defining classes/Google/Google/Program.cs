using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Company
    {
        public string name;
        public string department;
        public decimal salary;
    }

    class Pokemon
    {
        public string name;
        public string type;
    }

    class Parent
    {
        public string name;
        public string bDay;
    }

    class Child {
        public string name;
        public string bDay;
    }

    class Car
    {
        public string model;
        public string speed;
    }

    class Person
    {
        public string name;
        public Company company;
        public Car car;
        public List<Parent> parents;
        public List<Child> children;
        public List<Pokemon> pokemon;

    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var people = new Dictionary<string, Person>();

            while (input.ToLower() != "end")
            {
                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = spl[0];
                var infoType = spl[1];

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Person
                    {
                        name = name,
                        car = new Car(),
                        parents = new List<Parent>(),
                        children = new List<Child>(),
                        company = new Company(),
                        pokemon = new List<Pokemon>()

                    });
                }

                switch (infoType)
                {
                    case "company":
                        people[name].company = new Company
                        {
                            name = spl[2],
                            department = spl[3],
                            salary = decimal.Parse(spl[4])
                        };
                        break;
                    case "pokemon":
                        people[name].pokemon.Add(new Pokemon
                        {
                            name = spl[2],
                            type = spl[3]
                        });
                        break;
                    case "parents":
                        people[name].parents.Add(new Parent
                        {
                            name = spl[2],
                            bDay = spl[3]
                        });
                        break;
                    case "children":
                        people[name].children.Add(new Child
                        {
                            name = spl[2],
                            bDay = spl[3]
                        });
                        break;
                    case "car":
                        people[name].car = new Car
                        {
                            model = spl[2],
                            speed = spl[3]
                        };
                        break;
                }

                input = Console.ReadLine();
            }

            var printPersonName = Console.ReadLine();
            var printPerson = people
                .FirstOrDefault(x => x.Key == printPersonName).Value;
            Console.WriteLine(printPersonName);
            Console.WriteLine($"Company:");
            var salary = printPerson.company.salary > 0 ? $"{printPerson.company.salary:f2}" : "";
            if(printPerson.company.name != null)
            {
                Console.WriteLine($"{printPerson.company.name} {printPerson.company.department} {salary}");
            }else
            {
              
            }
            Console.WriteLine($"Car:");
            if(printPerson.car.model != null)
            {
                Console.WriteLine($"{printPerson.car.model} {printPerson.car.speed}");
            }
            Console.WriteLine("Pokemon:");
            foreach (var p in printPerson.pokemon)
            {
                Console.WriteLine($"{p.name} {p.type}");
            }
            Console.WriteLine("Parents:");
            foreach (var p in printPerson.parents)
            {
                Console.WriteLine($"{p.name} {p.bDay}");
            }
            Console.WriteLine("Children:");
            foreach (var p in printPerson.children)
            {
                Console.WriteLine($"{p.name} {p.bDay}");
            }
        }
    }
}
