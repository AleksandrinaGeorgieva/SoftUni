using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentSequenceCount = 1;
            int longestSequenceCount = 1;
            int longestSequenceEnd = numbers[0];
            int longestSequenceStart = numbers[0];
            int currentSequenceStart = numbers[0];
            int longestSequenceStartIndex = -1;
            int currentSequenceStartIndex = -1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                int nextNumber = numbers[i + 1];

                if (currentNumber < nextNumber)
                {
                    currentSequenceCount++;
                    if (longestSequenceCount < currentSequenceCount)
                    {
                        longestSequenceCount = currentSequenceCount;
                        longestSequenceEnd = nextNumber;
                        longestSequenceStart = currentSequenceStart;
                        longestSequenceStartIndex = currentSequenceStartIndex;
                    }
                }
                else
                {
                    currentSequenceCount = 1;
                    currentSequenceStart = nextNumber;
                    currentSequenceStartIndex = i;
                }
            }

            for (int i = longestSequenceStartIndex + 1; i < longestSequenceStartIndex + longestSequenceCount + 1; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}