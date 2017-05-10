using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStudentsByEmailDomain
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Student>();

            var input = Console.ReadLine();

            while(input.ToLower() != "end")
            {
                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                data.Add(new Student
                {
                    firstName = spl[0],
                    lastName = spl[1],
                    email = spl[2]
                });                    

                input = Console.ReadLine();
            }

            data
                .Where(x => x.email.Contains("@gmail.com"))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.firstName} {x.lastName}"));
        }
    }
}
