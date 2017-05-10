using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByFirstAndLastName
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Student>();

            var input = Console.ReadLine();

            while(input.ToLower() != "end")
            {
                var names = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                data.Add(new Student {
                    firstName = names[0],
                    lastName = names[1]
                });

                input = Console.ReadLine();
            }

            data
                .Where(x => x.firstName.CompareTo(x.lastName) < 0)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.firstName} {x.lastName}"));

        }
    }
}
