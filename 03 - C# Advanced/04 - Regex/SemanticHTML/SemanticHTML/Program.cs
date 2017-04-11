using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SemanticHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            StringBuilder str = new StringBuilder();
            string[] semantics = { "main", "header", "nav", "article", "section", "aside", "footer"};

            while(input.ToLower() != "end")
            {
                str.AppendLine(input);
                input = Console.ReadLine();
            }
            var html = str.ToString();
            Regex reg = new Regex(@"<div\s+.*(id\s*=\s*""(.*?)""|class\s*=\s*""(.*?)"")\s*.*>");

            var matches = reg.Matches(html);
            foreach (Match m in matches)
            {
                string semanticName = m.Groups[2].Length > 0 ? m.Groups[2].Value : m.Groups[3].Value;
                if (semantics.Contains(semanticName))
                {
                    var temp = m.Value.ToString();
                    temp = temp.Replace("<div ", $"<{semanticName} ");
                    temp = temp.Replace(" " + m.Groups[1].Value, null);
                    temp = Regex.Replace(temp, "\\s*>", ">");
                    temp = Regex.Replace(temp, "\\s{2,}", " ");
                    html = html.Replace(m.Value, temp);

                    Regex r = new Regex(@"<\/div>\s*<!--\s*" + semanticName + @"\s*-->");
                    html = r.Replace(html, "</" + semanticName + ">");
                }
            }
            Console.WriteLine(html);
        }
    }
}
