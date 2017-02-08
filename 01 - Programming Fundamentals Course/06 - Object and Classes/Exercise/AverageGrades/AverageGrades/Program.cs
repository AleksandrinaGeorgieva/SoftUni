using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        private static List<Student> students = new List<Student>();

        private static void PrintStudents()
        {
            var toDisplay = students
                .Where(x => x.GetAverage() >= 5)
                .OrderBy(x => x.name)
                .ThenByDescending(x => x.GetAverage())
                .ToList();
            toDisplay.ForEach(x => Console.WriteLine($"{x.name} -> {x.GetAverage():f2}"));
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var name = input[0];
                input.RemoveAt(0);
                var st = new Student
                {
                    grades = input
                        .Select(double.Parse)
                        .ToList(),
                    name = name
                };
                students.Add(st);
            }
            PrintStudents();
        }
    }
}
