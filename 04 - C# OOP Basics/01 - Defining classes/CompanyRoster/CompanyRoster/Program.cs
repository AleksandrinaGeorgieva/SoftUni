namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Employee {
        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var position = input[2];
                var dep = input[3];

                var email = input.Length > 4 && input[4].Contains("@") ? input[4] : "n/a";

                int age;

                bool hasAge = int.TryParse(input.Last(), out age);

                employees.Add(new Employee(name, salary, position, dep)
                {
                    email = email,
                    age = hasAge ? age : -1
                });
            }

            var data = employees
                .GroupBy(x => x.department)
                .Select(x => new
                {
                    department = x.Key,
                    sal = x.Average(e => e.salary),
                    emp = x.OrderByDescending(e => e.salary)
                })
                .OrderByDescending(e => e.sal)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {data.department}");

            foreach (var item in data.emp)
            {
                Console.WriteLine($"{item.name} {item.salary:f2} {item.email} {item.age}");
            }
        }
    }
}
