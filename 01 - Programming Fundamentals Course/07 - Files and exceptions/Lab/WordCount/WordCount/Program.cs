using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt")
                .Split(' ')
                .Select(x => x.ToLower())
                .ToList();
            var textWords = File.ReadAllText("text.txt")
                .Split(new[] { '.', ',', '-', '?', '!', ' ', '\r', '\n'}, StringSplitOptions.None)
                .Select(x => x.ToLower())
                .ToList();
            var dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var count = textWords
                    .Where(x => x == word)
                    .ToList()
                    .Count;
                dict.Add(word, count);
            }
            var list = new List<string>();
            foreach (var word in dict.OrderByDescending(x => x.Value))
            {
                list.Add($"{word.Key} - {word.Value}");
            }
            File.WriteAllLines("Output.txt", list);
        }
    }
}
