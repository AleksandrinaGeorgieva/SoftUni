using System.IO;
using System.Collections.Generic;

namespace MergeFiles
{
    class Program
    {
        public static void Main(string[] args)
        {
            var firstFile = File.ReadAllLines("FileOne.txt");
            var secondFile = File.ReadAllLines("FileTwo.txt");
            var list = new List<string>();
            for (int i = 0; i < firstFile.Length; i++)
            {
                list.Add(firstFile[i]);
                list.Add(secondFile[i]);
            }
            File.WriteAllLines("Output.txt", list);
        }
    }
}
