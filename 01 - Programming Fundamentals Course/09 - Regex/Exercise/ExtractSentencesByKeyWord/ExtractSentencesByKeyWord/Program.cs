using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine();
            var reg = new Regex(@"\b" + keyword + @"\b");
            var sentences = text.Split(new[] { '.', '!', '?' });

            for (int i = 0; i < sentences.Length; i++)
            {
                if (reg.IsMatch(sentences[i]))
                {
                    Console.WriteLine(sentences[i].Trim());
                }
            }
        }
    }
}
