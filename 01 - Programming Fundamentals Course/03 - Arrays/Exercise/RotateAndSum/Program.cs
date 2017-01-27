using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            int[] rotated = numbers.ToArray();
            for (int i = 0; i < k; i++)
            {
                rotated[0] = numbers[numbers.Length - 1];
                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = numbers[j - 1];
                }

                for (int m = 0; m < rotated.Length; m++)
                {
                    sum[m] += rotated[m];
                }
                numbers = rotated.ToArray();
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
