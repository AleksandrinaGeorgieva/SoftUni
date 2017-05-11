using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsJoinedToSpecialties
{
    public class StudentSpecialty
    {
        public string name { get; set; }
        public int facNum { get; set; }
    }

    public class Student
    {
        public string name { get; set; }
        public int facNum { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var specialties = new List<StudentSpecialty>();
            var students = new List<Student>();

            var input = Console.ReadLine();
            while(input != "Students:")
            {
                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                specialties.Add(new StudentSpecialty
                {
                    name = $"{spl[0]} {spl[1]}",
                    facNum = int.Parse(spl[2])
                });

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                students.Add(new Student
                {
                    name = $"{spl[1]} {spl[2]}",
                    facNum = int.Parse(spl[0])
                });

                input = Console.ReadLine();
            }

            students
                .Join(
                    specialties, 
                    x => x.facNum, 
                    y => y.facNum, 
                    (x,y) => $"{x.name} {x.facNum} {y.name}"
                 )
                 .OrderBy(x => x)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
