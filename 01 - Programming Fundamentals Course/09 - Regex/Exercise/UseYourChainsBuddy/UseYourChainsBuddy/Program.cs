using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {

            int bufSize = 1024;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));
            var input = Console.ReadLine();
            var regexPar = new Regex(@"<p>(.*?)<\/p>");
            var regForSpaces = new Regex(@"[^a-z0-9]");
            var regToRemoveMultipleSpaces = new Regex(@"[ ]{2,}");
            var paragraphs = regexPar.Matches(input);

            var parTexts = new List<string>();

            foreach (Match p in paragraphs)
            {
                var t = regForSpaces
                    .Replace(p.Groups[1].Value, " ");
                var t1 = regToRemoveMultipleSpaces
                    .Replace(t, " ")
                    .ToCharArray();
                var decrypted = new char[t1.Length];

                for (int i = 0; i < t1.Length; i++)
                {
                    if(t1[i] - 'a' >= 0)
                    {
                        if (t1[i] - 'a' >= 13)
                        {
                            decrypted[i] = (char)((int)(t1[i]) - 13);
                        }
                        else
                        {
                            decrypted[i] = (char)((int)(t1[i]) + 13);
                        }
                    }else
                    {
                        decrypted[i] = t1[i];
                    }
                }

                parTexts.Add(new string(decrypted));
            }

            parTexts.ForEach(Console.Write);
        }

       
    }
}
