using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        private static char[] stringSeparators = new[] { ',', ' ', '\t' };
        private static Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        private static Regex reg = new Regex(@",\s+");

        private static void PrintResults()
        {
            var sortedDict = dict
                .OrderByDescending(x => x.Value.Distinct().ToArray().Length)
                .ThenBy(x => x.Key);
            bool printedAwards = false;
            foreach (var singer in sortedDict)
            {
                var awards = singer.Value
                    .Distinct()
                    .OrderBy(x => x)
                    .ToArray();
                var awardsCount = awards.Length;
                if(awards.Length > 0)
                {
                    printedAwards = true;
                    Console.WriteLine($"{singer.Key}: {awardsCount} awards");
                    for (int i = 0; i < awards.Length; i++)
                    {
                        Console.WriteLine($"--{awards[i]}");
                    }
                }                
            }

            if (!printedAwards)
            {
                Console.WriteLine("No awards");
            }
        }

        private static string[] SplitInput(string input)
        {
            var result = reg.Replace(input, ",");
            var splitted = result
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return splitted;
        }

        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            var participants = Console.ReadLine()
                .Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();
            for (int i = 0; i < participants.Count; i++)
            {
                dict[participants[i]] = new List<string>();
            }
            var songsInput = Console.ReadLine();
            var songs = SplitInput(songsInput)
                .ToList();
            var input = Console.ReadLine();
            
            while(input.ToLower() != "dawn")
            {
                var splitted = SplitInput(input);
                string name = splitted[0];
                string song = splitted[1];
                string award = splitted[2];

                if (dict.ContainsKey(name) && songs.Contains(song))
                {
                    dict[name].Add(award);
                }

                input = Console.ReadLine();
            }
            PrintResults();
        }
    }
}
