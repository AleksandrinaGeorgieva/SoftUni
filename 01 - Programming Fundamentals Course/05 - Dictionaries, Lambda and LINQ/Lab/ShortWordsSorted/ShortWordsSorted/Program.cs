using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
            var words = Console.ReadLine()
               .Split(separators, StringSplitOptions.RemoveEmptyEntries)
               .Select(x=> x.ToLower())
               .ToArray();

            var shortWords = words
                .Where(x => x.Length < 5)
                .Distinct()
                .ToList();
            shortWords.Sort();
            Console.WriteLine(string.Join(", ", shortWords));

        }
    }
}
