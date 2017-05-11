namespace GroupByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string name { get; set; }
        public int group { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>();

            var input = Console.ReadLine();

            while(input.ToLower() != "end")
            {

                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                data.Add(new Person
                {
                    name = $"{spl[0]} {spl[1]}",
                    group = int.Parse(spl[2])
                });

                input = Console.ReadLine();
            }

            data
                .GroupBy(x => x.group)
                .OrderBy(x => x.Key)
                .Select(x => $"{x.Key} - { string.Join(", ",x.Select(a=>a.name).ToList())}")          
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
