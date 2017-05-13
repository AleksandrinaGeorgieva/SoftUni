using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LittleJohn
{
    class Program
    {
        private const string small = ">----->";
        private const string medium = ">>----->";
        private const string large = ">>>----->>";
        private static string input = "";
        
        static void Main(string[] args)
        {
            var data = new Dictionary<string, int>
            {
                { small, 0},
                { medium, 0},
                { large, 0}
            };

            
            var reg = new Regex($"({large})|({medium})|({small})");

            for (int i = 0; i < 4; i++)
            {
                input = Console.ReadLine();

                var matches = reg.Matches(input);

                foreach (Match m in matches)
                {
                    switch (m.Value)
                    {
                        case small: data[small]++; break;
                        case medium: data[medium]++; break;
                        case large: data[large]++; break;
                    }
                }
            }           

            var message = int.Parse(data[small]
                .ToString() + data[medium].ToString() + data[large].ToString());
            
            var bin = Convert.ToString(message, 2);
            var tempMessage = bin + new string(bin.Reverse().ToArray());
            Console.WriteLine(Convert.ToInt32(tempMessage, 2));

        }
    }
}
