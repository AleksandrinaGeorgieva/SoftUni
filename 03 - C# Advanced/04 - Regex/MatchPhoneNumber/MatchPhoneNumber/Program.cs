using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            Regex reg = new Regex(pattern);

            var input = Console.ReadLine();
            while(input.ToLower() != "end")
            {
                if (reg.IsMatch(input))
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
