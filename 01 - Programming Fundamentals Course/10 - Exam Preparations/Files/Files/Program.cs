using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var files = new List<File>();
            string input, path, name, r;
            long size;
            File f;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                var splitted = input.Split(';');
                path = splitted[0];
                var splitAgain = path.Split('\\');
                name = splitAgain.Last();
                r = splitAgain.First();
                size = long.Parse(splitted[1]);
                f = new File
                {
                    size = size,
                    name = name,
                    path = path,
                    root = r
                };

                var existing = files.FindIndex(x => x.root == r && x.name == name);
                if (existing > -1)
                {
                    files.RemoveAt(existing);
                }

                files.Add(f);
            }
            var query = Console.ReadLine().Split(' ');
            var root = query[2];
            var type = query[0];

            var filesInRoot = files
                .Where(x => x.path.StartsWith(root));
            var filesWithExtension = filesInRoot
                .Where(x => x.name.EndsWith("." + type))
                .ToList();

            if (filesWithExtension.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                var sorted = filesWithExtension
                    .OrderByDescending(x => x.size)
                    .ThenBy(x => x.name)
                    .ToList();
                for (int i = 0; i < sorted.Count; i++)
                {
                    Console.WriteLine($"{sorted[i].name} - {sorted[i].size} KB");
                }
            }
        }
    }
}
