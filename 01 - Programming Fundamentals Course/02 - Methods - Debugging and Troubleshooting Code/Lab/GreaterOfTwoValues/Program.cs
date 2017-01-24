using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }

        public static string GetMax(string a, string b)
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNumber, secondNumber));
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else if (type == "string")
            {
                string firsString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firsString, secondString));
            }
        }
    }
}
