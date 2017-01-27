using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        public static void PrintArrays(char[] array1, char[] array2)
        {
            Console.WriteLine(string.Join("", array1));
            Console.WriteLine(string.Join("", array2));
        }

        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool printed = false;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (i < secondArray.Length)
                {
                    if (firstArray[i].CompareTo(secondArray[i]) == 0)
                    {
                        continue;
                    }
                    else if (firstArray[i].CompareTo(secondArray[i]) > 0)
                    {
                        PrintArrays(secondArray, firstArray);
                        printed = true;
                        break;
                    }
                    else
                    {
                        PrintArrays(firstArray, secondArray);
                        printed = true;
                        break;
                        
                    }
                }
            }

            if (!printed)
            {
                if (firstArray.Length == secondArray.Length)
                {
                    PrintArrays(secondArray, firstArray);
                }
                else if (firstArray.Length < secondArray.Length)
                {
                    PrintArrays(firstArray, secondArray);
                }
                else
                {
                    PrintArrays(secondArray, firstArray);
                }

            }


        }
    }
}
