using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByAge
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Student>();

            var input = Console.ReadLine();

            while(input.ToLower() != "end")
            {
                var splitted = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                data.Add(new Student
                {
                    firstName = splitted[0],
                    lastName = splitted[1],
                    age = int.Parse(splitted[2])
                });                

                input = Console.ReadLine();
            }

            data
                .Where(x => x.age <= 24 && x.age >= 18)
                .Select(x => $"{x.firstName} {x.lastName} {x.age}")
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
