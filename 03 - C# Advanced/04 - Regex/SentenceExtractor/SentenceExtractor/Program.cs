using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SentenceExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            string pattern = @"(\w[^.!?]*)?(\b" + keyword + @"\b)[^.!?]*[.!?]";
            Regex reg = new Regex(pattern);

            var sentences = Console.ReadLine();
            var matches = reg.Matches(sentences);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}
