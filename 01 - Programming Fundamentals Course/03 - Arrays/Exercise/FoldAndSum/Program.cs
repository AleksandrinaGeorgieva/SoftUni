using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int len = numbers.Length;
            // k == central index and the length of the folded sides
            int k = len / 4;
            int[] result = new int[k * 2];

            Array.Copy(numbers, k, result, 0, k*2);

            for (int i = 0; i < k; i++)
            {
                result[i] += numbers[k - 1 - i]; 
            }

            int count = result.Length - 1;
            for (int i = k * 3; i < len; i++)
            {
                result[count] += numbers[i];
                count--;
            }

            Console.WriteLine(string.Join(" ",result));

        }
    }
}
