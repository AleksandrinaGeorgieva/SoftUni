using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStudentsByPhone
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Student>();

            var input = Console.ReadLine();

            while(input != "END")
            {
                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                data.Add(new Student
                {
                    firstName = spl[0],
                    lastName = spl[1],
                    phone = spl[2]
                });

                input = Console.ReadLine();
            }

            data
                .Where(x => x.phone.StartsWith("02") || x.phone.StartsWith("+3592"))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.firstName} {x.lastName}"));
        }
    }
}
