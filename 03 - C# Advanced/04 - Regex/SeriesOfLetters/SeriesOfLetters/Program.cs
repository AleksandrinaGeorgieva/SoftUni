using System;
using System.Text.RegularExpressions;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var replaced = Regex.Replace(input, @"(.)\1+", m => m.Groups[1].Value[0].ToString());
            Console.WriteLine(replaced);
        }
    }
}
