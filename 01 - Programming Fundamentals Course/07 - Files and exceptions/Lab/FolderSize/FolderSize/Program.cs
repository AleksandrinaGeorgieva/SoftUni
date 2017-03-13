using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            // var dirFiles = Directory.GetFiles("TestFolder", "*.*", SearchOption.AllDirectories);

            var dirFiles = Directory.GetFiles("TestFolder");

            var sum = 0d;

            foreach (var file in dirFiles)
            {
                sum+= new FileInfo(file).Length;
            }
            sum = sum / 1024.0 / 1024.0; // divide to go to MB.
            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
