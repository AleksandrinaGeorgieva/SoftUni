using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    class Program
    {
        private static bool IsSpaceFree(Dictionary<int, HashSet<int>> parking, int row, int col)
        {
            return !(parking.ContainsKey(row) && parking[row].Contains(col));
        }

        private static void OccupySpace(Dictionary<int, HashSet<int>> parking, int row, int col)
        {
            if (!parking.ContainsKey(row))
            {
                parking[row] = new HashSet<int>();
            }
            parking[row].Add(col);
        }

        private static int SearchSpace(Dictionary<int, HashSet<int>> parking, int row, int col, int totalSpacesOnRow)
        {
            int spaceIndex = -1;
            int minDistance = int.MaxValue;
            int currentDistance;

            if(parking.ContainsKey(row) && parking[row].Count == totalSpacesOnRow - 1)
            {
                return spaceIndex;
            }else
            {
                if(IsSpaceFree(parking, row, col))
                {
                    return col;
                }else
                {
                    for (int i = 1; i < totalSpacesOnRow; i++)
                    {
                        currentDistance = Math.Abs(i - col);
                        if(currentDistance < minDistance && IsSpaceFree(parking, row, i))
                        {
                            minDistance = currentDistance;
                            spaceIndex = i;
                        }
                    }
                }
            }

            return spaceIndex;
        }

        static void Main(string[] args)
        {
            var parking = new Dictionary<int, HashSet<int>>();
            var dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            var input = Console.ReadLine();
            while(input.ToLower() != "stop")
            {
                var splitted = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                int entryRow = splitted[0];
                int targetRow = splitted[1];
                int targetCol = splitted[2];

                int space = SearchSpace(parking, targetRow, targetCol, cols);
                if(space < 0)
                {
                    Console.WriteLine($"Row {targetRow} full");
                }else
                {
                    OccupySpace(parking, targetRow, space);
                    int distance = Math.Abs(targetRow - entryRow) + space + 1;
                    Console.WriteLine(distance);
                }

                
                    
                input = Console.ReadLine();
            }
        }
    }
}
