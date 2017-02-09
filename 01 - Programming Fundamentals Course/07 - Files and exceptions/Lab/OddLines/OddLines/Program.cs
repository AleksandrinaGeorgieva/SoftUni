using System;
using System.Linq;
using System.IO;

namespace OddLines
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fileContent = File.ReadAllLines("Input.txt");
            var oddLines = fileContent
                .Where((x, index) => index % 2 == 1)
                .ToArray();
            //oddLines.ForEach(Console.WriteLine);
            File.WriteAllLines("Output.txt", oddLines);
        }
    }
}
