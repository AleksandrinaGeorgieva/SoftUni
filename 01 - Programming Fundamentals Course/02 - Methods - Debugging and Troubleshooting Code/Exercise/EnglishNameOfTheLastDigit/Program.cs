using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        public static string DigitName(long n)
        {
            string digitName = "";
            switch (n)
            {
                case 0: digitName = "zero"; break;
                case 1: digitName = "one"; break;
                case 2: digitName = "two"; break;
                case 3: digitName = "three"; break;
                case 4: digitName = "four"; break;
                case 5: digitName = "five"; break;
                case 6: digitName = "six"; break;
                case 7: digitName = "seven"; break;
                case 8: digitName = "eight"; break;
                case 9: digitName = "nine"; break;
                default: digitName = ""; break;
            }
            return digitName;


            /*
             with array: 
             * 
             * long a = long.Parse(Console.ReadLine());
 
            string[] names = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
 
            Console.WriteLine(names[Math.Abs(a % 10)]);
             */
        }
        
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long lastNumber = Math.Abs(number) % 10;
            Console.WriteLine(DigitName(lastNumber));
        }
    }
}
