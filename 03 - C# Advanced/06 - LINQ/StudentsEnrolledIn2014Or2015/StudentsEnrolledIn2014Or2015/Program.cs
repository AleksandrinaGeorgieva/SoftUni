using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsEnrolledIn2014Or2015
{
    public class Student
    {
        public string facultyNumber { get; set; }
        public List<string> marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Student>();
            var input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                data.Add(new Student
                {
                    facultyNumber = $"{spl[0]}",
                    marks = spl
                        .Skip(1)
                        .ToList()
                });

                input = Console.ReadLine();
            }

            data
                .Where(x => x.facultyNumber.EndsWith("14") || x.facultyNumber.EndsWith("15"))
                .Select(x => string.Join(" ", x.marks))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}

