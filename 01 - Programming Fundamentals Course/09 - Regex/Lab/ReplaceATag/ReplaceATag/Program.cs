namespace ReplaceATag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @"<a(.*href=(?:'|"").*?(?:'|""))>(.*?)<\/a>";
            Regex regex = new Regex(pattern);

            var resultList = new List<string>();
            var text = Console.ReadLine();
            while(text != "end")
           {
                string replacement = Regex.Replace(text, @"\t|\n|\r", "");
                var matches = regex.Matches(replacement);
                replacement = regex.Replace(replacement, "[URL$1]$2[/URL]");
                resultList.Add(replacement);
                text = Console.ReadLine();
            }

            resultList.ForEach(Console.WriteLine);
        }
    }
}
