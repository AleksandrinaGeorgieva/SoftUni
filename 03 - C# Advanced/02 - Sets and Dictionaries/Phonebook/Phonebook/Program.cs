using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input.ToLower() != "search")
            {
                var splitted = input
                    .Split('-');

                if (!data.ContainsKey(splitted[0]))
                {
                    data[splitted[0]] = "";
                }
                data[splitted[0]] = splitted[1];

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while(input.ToLower() != "stop")
            {
                if (data.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {data[input]}");
                }else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
                input = Console.ReadLine();
            }            
        }
    }
}
