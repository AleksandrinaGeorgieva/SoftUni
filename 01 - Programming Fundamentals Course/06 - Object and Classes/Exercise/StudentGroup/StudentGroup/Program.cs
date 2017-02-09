using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace StudentGroup
{
    class Program
    {
        private static List<Town> data = new List<Town>();

        private static void PrintResult()
        {
            int townCount = data.Count;
            data.ForEach(x => x.GenerateGroups());
            int groupsSum = data
                .Select(x => x.groupsCount)
                .Sum();

            data = data.OrderBy(x => x.name).ToList();
            Console.WriteLine($"Created {groupsSum} groups in {townCount} towns:");
            for (int i = 0; i < data.Count; i++)
            {
                int len = data[i].groups.Count;
                for (int j = 0; j < len; j++)
                {
                    Console.Write($"{data[i].name} => ");
                    Console.WriteLine(string.Join(", ", data[i].groups[j].memberEmails));
                }
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Town currentTown = new Town();
            Student currentStudent;
            while(input != "End")
            {
                if (input.Contains("=>"))
                {
                    var townData = input
                        .Split(new string[] { "=>" }, StringSplitOptions.None);
                    var seats = townData[1]
                        .Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries)[0];
                    //enter town and seats
                    currentTown = new Town
                    {
                        name = townData[0].Trim(),
                        seats = int.Parse(seats),
                        students = new List<Student>()
                    };
                    data.Add(currentTown);
                }
                else
                {
                    var studentData = input
                        .Split('|')
                        .Select(x => x.Trim())
                        .ToArray();
                    currentStudent = new Student {
                        name = studentData[0],
                        email = studentData[1],
                        registrationDate = DateTime.ParseExact(
                            studentData[2],
                            "d-MMM-yyyy",
                            CultureInfo.InvariantCulture
                            )
                    };
                    currentTown = data
                    .Where(x => x.name == currentTown.name)
                    .First();
                    currentTown.students.Add(currentStudent);
                }
                input = Console.ReadLine();
            }
            PrintResult();
        }
    }
}
