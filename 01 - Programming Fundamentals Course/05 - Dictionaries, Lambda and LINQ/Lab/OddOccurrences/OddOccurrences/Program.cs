using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .Select(x => x.ToLower())
                .ToArray();
            var occurrences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!(occurrences.ContainsKey(words[i])))
                {
                    occurrences[words[i]] = 0;
                }
                occurrences[words[i]]++;
            }

            var oddOccurrences = occurrences.Where(x => x.Value % 2 == 1).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(string.Join(", ", oddOccurrences.Keys));
        }
    }
}
