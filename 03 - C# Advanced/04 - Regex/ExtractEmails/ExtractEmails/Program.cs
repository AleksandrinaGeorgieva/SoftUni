using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex reg = new Regex(@"\s[a-z0-9A-Z]+(-|\.)?\w+@([a-z]+(-|\.)){1,}([a-z]+)");

            var matches = reg.Matches(input);
            foreach (Match m in matches)
            {
                var trimmed = m.Value.Trim();
                Console.WriteLine(trimmed);
            }
        }
    }
}
