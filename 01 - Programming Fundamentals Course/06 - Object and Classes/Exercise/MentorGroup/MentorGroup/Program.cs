using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MentorGroup
{
    class Program
    {
        private static SortedDictionary<string, StudentActivity> students = new SortedDictionary<string, StudentActivity>();

        private static void AddStudent(string name)
        {
            students[name] = new StudentActivity
            {
                datesAttended = new List<DateTime>(),
                comments = new List<string>()
            };
        }

        private static void AddAttendedDate(string dateString, string studentName)
        {
            var date = DateTime.ParseExact(
                dateString,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
                );
            students[studentName].datesAttended.Add(date);
        }

        private static void CollectStudentsAndDates()
        {
            var input = Console.ReadLine();
            string name;
            while(input != "end of dates")
            {
                var splitted = input
                    .Split(new char[] { ' ', ',' })
                    .ToList();
                name = splitted[0];

                if (!students.ContainsKey(name))
                {
                    AddStudent(name);
                }
                splitted.RemoveAt(0);
                splitted
                    .ForEach(x => AddAttendedDate(x, name));

                input = Console.ReadLine();
            }
        }

        private static void CollectComments()
        {
            var input = Console.ReadLine();

            while(input != "end of comments")
            {
                var splitted = input.Split('-');
                var name = splitted[0];
                if (students.ContainsKey(name))
                {
                    students[name].comments.Add(splitted[1]);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintData()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                student.Value.comments.ForEach(
                    x => Console.WriteLine($"- {x}")
                    );
                Console.WriteLine("Dates attended:");
                student.Value.datesAttended
                    .OrderBy(x => x)
                    .ToList()
                    .ForEach(
                    x => Console.WriteLine($"-- {x.ToString("dd'/'MM'/'yyyy")}")
                    );
            }
        }

        static void Main(string[] args)
        {
            CollectStudentsAndDates();
            CollectComments();
            PrintData();
        }
    }
}
