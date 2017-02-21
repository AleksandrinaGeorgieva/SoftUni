using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            var regDigits = new Regex(@"\d");
            var message = Console.ReadLine();
            while(message != "Over!")
            {
                var messageLength = int.Parse(Console.ReadLine());
                var reg = new Regex(@"^[0-9]+([A-Za-z]{" + messageLength + @"})[^A-Za-z]*$");
                if (reg.IsMatch(message))
                {
                    var digits = regDigits.Matches(message);
                    var verification = new List<char>();
                    var core = reg.Match(message).Groups[1].Value;

                    foreach (Match digit in digits)
                    {
                        var index = int.Parse(digit.Value);
                        if(index > -1 && index < core.Length)
                        {
                            verification.Add(core[index]);
                        }else
                        {
                            verification.Add(' ');
                        }
                    }
                    Console.WriteLine($"{core} == {string.Join("", verification)}");
                }
                
                message = Console.ReadLine();
            }
        }
    }
}
