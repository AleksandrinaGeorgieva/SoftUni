namespace Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        private static List<List<long>> matrix = new List<List<long>>();
        private static int n;
        private static int m;

        private static void InitMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                matrix.Add(new List<long>());
                for (int j = 1; j <= m; j++)
                {
                    matrix[i].Add(i * m + j);
                }
            }
        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            n = dimensions[0];
            m = dimensions[1];

            InitMatrix();

            var input = Console.ReadLine();

            while(input != "Nuke it from orbit")
            {
                var splitted = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                int row = splitted[0];
                int col = splitted[1];
                int radius = splitted[2];
                
                int start = col - radius;
                int count = 2 * radius + 1;
                if(row > -1 && row < matrix.Count)
                {
                    for (long i = start; i < start + count; i++)
                    {
                        if (matrix[row].Count > start && start > -1)
                        {
                            matrix[row].RemoveAt(start);
                        }
                    }
                }

                int st = row - radius;
                for (int i = st; i <= row + radius; i++)
                {
                    if (
                        i > -1 && i < matrix.Count
                        && col > -1 && col < matrix[i].Count
                        && i != row
                        )
                    {
                        matrix[i].RemoveAt(col);
                    }

                }

                input = Console.ReadLine();
            }

            PrintMatrix();
        }
    }
}
