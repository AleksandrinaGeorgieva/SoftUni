using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakStudents
{
    public class Student
    {
        public string name { get; set; }
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
                    name = $"{spl[0]} {spl[1]}",
                    marks = spl
                        .Skip(2)
                        .ToList()
                });

                input = Console.ReadLine();
            }

            data
                .Where(x => x.marks.Count(y => int.Parse(y) <= 3) >1)
                .ToList()
                .ForEach(x => Console.WriteLine(x.name));
        }
    }
}
