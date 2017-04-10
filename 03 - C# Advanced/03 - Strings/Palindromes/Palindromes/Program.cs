using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var splitters = new[] { ' ', ',', '.', '!', '?', '\'', '"', '@', '#', '$', '%', '&', '*', '(', ')', '-', '_', '+', '=', '~', '\\', '/'};
            var words = Console.ReadLine()
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var temp = new string(words[i].Reverse().ToArray());
                if(string.Compare(temp, words[i]) == 0)
                {
                    palindromes.Add(temp);
                }
            }
            palindromes = palindromes
                .OrderBy(x => x)
                .Distinct()
                .ToList();
            Console.WriteLine("[" + string.Join(", ", palindromes) + "]");
        }
    }
}
