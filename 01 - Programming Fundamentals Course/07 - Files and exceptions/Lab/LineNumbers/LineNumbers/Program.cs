using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLines = File.ReadAllLines("Input.txt");
            var linesToWrite = fileLines
                .Select((line, index) => $"{index + 1}. {line}")
                .ToArray();
            File.WriteAllLines("Output.txt", linesToWrite);
        }
    }
}
