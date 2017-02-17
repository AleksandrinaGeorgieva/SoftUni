using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var regexUserName = new Regex(@"\b[a-zA-z]{1}([a-zA-Z0-9_]){2,25}\b");

            var matches = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (regexUserName.IsMatch(input[i].Trim()))
                {
                    matches.Add(input[i]);
                }
            }

            int longestSum = int.MinValue;
            string first = "";
            string second = "";

            for (int i = 0; i < matches.Count-1; i++)
            {
                int tempLength = matches[i].Length + matches[i + 1].Length;
                if (tempLength > longestSum)
                {
                    longestSum = tempLength;
                    first = matches[i];
                    second = matches[i + 1];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
