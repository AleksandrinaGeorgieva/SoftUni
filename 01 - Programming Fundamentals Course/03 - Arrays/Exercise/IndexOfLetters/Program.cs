using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[26];
            int count = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                array[count] = i;
                count++;
            }

            char[] text = Console.ReadLine().ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                int index = Array.IndexOf(array, text[i]);
                Console.WriteLine("{0} -> {1}", text[i], index);
            }
        }
    }
}
