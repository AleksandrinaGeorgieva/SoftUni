namespace ExtractHyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>] +))[^>]*>";
            Regex reg = new Regex(pattern);

            var input = Console.ReadLine();
            StringBuilder str = new StringBuilder();
            while(input.ToLower() != "end")
            {
                str.Append(input);
                input = Console.ReadLine();
            }

            var matches = reg.Matches(str.ToString());
            foreach (Match hyperlink in matches)
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (hyperlink.Groups[i].Length > 0)
                    {
                        Console.WriteLine(hyperlink.Groups[i].Value);
                    }
                }
            }
        }
    }
}
