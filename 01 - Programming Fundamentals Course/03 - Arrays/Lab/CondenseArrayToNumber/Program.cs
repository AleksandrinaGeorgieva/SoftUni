using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("{0} is already condensed to number", numbers[0]);
            }
            else
            {
                int count = numbers.Length - 1;
                int[] condensedArray = numbers.ToArray();
                while (count >= 1)
                {
                    int[] tempArray = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        tempArray[i] = condensedArray[i] + condensedArray[i + 1];
                    }
                   // Console.WriteLine(string.Join(" ", tempArray));
                    condensedArray = tempArray.ToArray();
                    count--;

                }
                Console.WriteLine(condensedArray[0]);
            }
        }
    }
}
