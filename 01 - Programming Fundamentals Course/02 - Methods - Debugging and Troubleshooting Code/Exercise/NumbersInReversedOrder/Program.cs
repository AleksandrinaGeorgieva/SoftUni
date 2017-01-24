using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        public static void PrintInReversedOrder(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

        static void Main(string[] args)
        {
            string textToReverse = Console.ReadLine();
            PrintInReversedOrder(textToReverse);
        }
    }
}
