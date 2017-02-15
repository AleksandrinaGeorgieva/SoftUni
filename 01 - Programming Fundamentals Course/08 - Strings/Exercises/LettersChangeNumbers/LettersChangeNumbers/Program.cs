using System;
using System.Linq;
using System.Numerics;

namespace LettersChangeNumbers
{
    class Program
    {
        private static decimal CalculateNumber(string s)
        {            
            char firstLetter = s.First();
            char secondLetter = s.Last();
            var tempNumber = s.Remove(0, 1).Remove(s.Length - 2, 1);
            decimal result = decimal.Parse(tempNumber);

            var firstLetterPosition = (int)firstLetter % 32;
            var secondLetterPosition = (int)secondLetter % 32;
            if (char.IsUpper(firstLetter))
            {
                result /= firstLetterPosition;
            }else
            {
                result *= firstLetterPosition;
            }

            if (char.IsUpper(secondLetter))
            {
                result -= secondLetterPosition;
            }else
            {
                result += secondLetterPosition;
            }

            return result;
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal sum = 0M;
            for (int i = 0; i < input.Length; i++)
            {
                sum += CalculateNumber(input[i]);
            }
            Console.WriteLine($"{sum:f2}");
            

        }
    }
}
