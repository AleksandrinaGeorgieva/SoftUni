using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while(input.ToLower() != "end")
            {
                input = input.Trim();
                var name = input.Substring(0, input.Length - 2);
                var age = input.Substring(input.Length - 1, 1);
                if (!data.ContainsKey(name))
                {
                    data.Add(name, age);
                }

                input = Console.ReadLine();
            }

            data
                .Where(x => x.Value == "2")
                .OrderBy(x => x.Key)
                .ToList()
                .ForEach(x => Console.WriteLine(x.Key));
        }
    }
}
