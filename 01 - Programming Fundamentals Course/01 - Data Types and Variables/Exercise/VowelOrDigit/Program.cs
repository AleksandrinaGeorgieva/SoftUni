using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            char[] vowels = {'a', 'o', 'e', 'i', 'u', 'y'};
            int n;
            bool isNumeric = int.TryParse(symbol.ToString(), out n);
            if (isNumeric)
            {
                Console.WriteLine("digit");
            }
            else if (vowels.Contains(symbol))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
