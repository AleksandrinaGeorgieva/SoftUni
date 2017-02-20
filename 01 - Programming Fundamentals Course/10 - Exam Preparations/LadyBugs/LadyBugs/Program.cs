using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        private static int[] field = new int[1];

        private static void FillFields(int fieldSize)
        {
            var indexes = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < indexes.Length; i++)
            {
                var currentIndex = indexes[i];
                if (currentIndex > -1 && currentIndex < fieldSize)
                {
                    field[currentIndex] = 1;
                }
            }
        }

        private static void PrintResult()
        {
            var output = string.Join(" ", field);
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            field = new int[fieldSize];
            FillFields(fieldSize);

            var input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                var splittedCommand = input.Split(' ');
                int startIndex = int.Parse(splittedCommand[0]);            
                string direction = splittedCommand[1];
                int length = int.Parse(splittedCommand[2]);
                bool cont = true;
                if(startIndex < fieldSize && startIndex > -1)
                {
                    if(field[startIndex] == 0)
                    {
                        cont = false;
                    }
                    field[startIndex] = 0;

                    if (cont)
                    {
                        long newPosition = startIndex;
                        for (int i = 0; i < fieldSize; i++)
                        {
                            if(direction == "right")
                            {
                                newPosition += length;
                            }else
                            {
                                newPosition -= length;
                            }
                            
                            if (newPosition < fieldSize && newPosition > -1)
                            {
                                if (field[newPosition] == 0)
                                {
                                    field[newPosition] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            PrintResult();
        }
    }
}
