using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        public static bool CompareStrings(string str1, string str2)
        {
            return str1.CompareTo(str2) == 0;
        }

        public static int GetCommonFirstWordsCount(string[] arr1, string[] arr2)
        {
            int count = 0;

            for (int i = 0, len = arr1.Length; i < len; i++)
            {
                if (i < arr2.Length && CompareStrings(arr1[i], arr2[i]))
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        public static void PrintResult(string endName, int count, string[] array)
        {
            Console.Write("The largest common end is at the {0}: ", endName);
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void PrintResult(bool hasCommonWords)
        {
            if (!hasCommonWords)
            {
                Console.WriteLine("No common words at the left and right");
            }
        }

        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var secondArray = Console.ReadLine()
                .Split(' ')
                .ToArray();

            /* use reversed arraysto count the right end words */
            var firstArrayReversed = firstArray.Reverse().ToArray();
            var secondArrayReversed = secondArray.Reverse().ToArray();

            int commonLeftWords = GetCommonFirstWordsCount(firstArray, secondArray);
            int commonRightWords = GetCommonFirstWordsCount(firstArrayReversed, secondArrayReversed);

            Console.WriteLine(Math.Max(commonLeftWords, commonRightWords));

            /*if (commonRightWords == 0 && commonLeftWords == 0)
            {
                PrintResult(false);
            }else if (commonLeftWords > commonRightWords)
            {
                PrintResult("left", commonLeftWords, firstArray);
            }
            else
            {
                PrintResult("right", commonRightWords, firstArrayReversed);
            }*/
            
        }
    }
}
