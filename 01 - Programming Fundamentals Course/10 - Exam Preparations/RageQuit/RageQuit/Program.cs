using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = new StringBuilder();
            var regex = new Regex(@"(.*?)(\d+)");
            var matches = regex.Matches(input);

            foreach (Match m in matches)
            {
                int n = int.Parse(m.Groups[2].Value);
                string tmp = m.Groups[1].Value.ToUpper();
                tmp = string.Concat(Enumerable.Repeat(tmp, n));
                output.Append(tmp);
            }
            var b = output.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {b}");
            Console.WriteLine(output);
        }
    }
}
