using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        public static int[] CalculateSums(int[] numbers)
        {
            int[] result = Enumerable.Repeat(int.MinValue, numbers.Length).ToArray();
            //int[] result = new int[numbers.Length];
            result[0] = numbers[0] + numbers[1];
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                result[i] = numbers[i + 1] + result[i - 1];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int j = i+1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if(rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}

