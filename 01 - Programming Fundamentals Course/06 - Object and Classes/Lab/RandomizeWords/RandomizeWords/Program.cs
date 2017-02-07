using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToList();
            var randomized = new List<string>();
            var random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var temp = random.Next(0, i);
                randomized.Insert(temp, words[i]);
            }
            randomized.ForEach(Console.WriteLine);
        }
    }
}
