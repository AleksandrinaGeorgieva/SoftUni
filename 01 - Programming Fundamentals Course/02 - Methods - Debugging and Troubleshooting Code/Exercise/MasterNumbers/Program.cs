using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        public static Boolean IsPalindrom(int n2)
        {
            var n = n2.ToString();

            //looks better nut works slowly
            /*char[] n1 = n.ToString().ToCharArray();
            char[] n2 = n.ToString().ToCharArray();
            Array.Reverse(n2);

            return new string(n1) == new string(n2);*/

            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i]) { return false; }
            }
            return true;

        }

        public static int SumOfDigits(int n)
        {
            int sum = 0;
            foreach(char symbol in n.ToString()){
                sum += (int)Char.GetNumericValue(symbol);
            }
            return sum;
        }

        public static bool HasEvenDigit(int n)
        {
            foreach (char symbol in n.ToString())
            {
                short temp = (short)Char.GetNumericValue(symbol);
                if (temp % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }
        
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if(
                    IsPalindrom(i)
                    && SumOfDigits(i) % 7 == 0
                    && HasEvenDigit(i)
                    ){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
