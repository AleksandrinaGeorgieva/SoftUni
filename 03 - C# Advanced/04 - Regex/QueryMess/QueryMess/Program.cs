using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, List<string>>();
            var reg = new Regex(@"([^?&\n])+={1}([^?&\n])+");
            var wsReg = new Regex(@"(\+|%20)+");
            while(input.ToLower() != "end")
            {
                var pairs = reg.Matches(input);

                foreach (Match match in pairs)
                {
                    var splitted = match.Value.Split('=');
                    var field = splitted[0];
                    var value = splitted[1];
                    field = wsReg.Replace(field, " ").Trim();
                    value = wsReg.Replace(value, " ").Trim();

                    if (!dict.ContainsKey(field))
                    {
                        dict[field] = new List<string>();
                    }
                    dict[field].Add(value);
                }

                foreach (var field in dict)
                {
                    var values = string.Join(", ", field.Value);
                    Console.Write($"{field.Key}=[{values}]");
                }
                Console.WriteLine();
                dict.Clear();
                input = Console.ReadLine();
            }
        }
    }
}
