using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        private static bool CheckExchangeable(string firstWord, string secondWord)
        {
            bool result = true;
            
            var firstCharArray = firstWord
                .ToCharArray()
                .Distinct()
                .ToArray();
            var secongCharArray = secondWord
                .ToCharArray()
                .Distinct()
                .ToArray();

            if (firstCharArray.Length != secongCharArray.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, char>();

            for (int i = 0; i < firstWord.Length; i++)
            {
                if(secondWord.Length > i)
                {
                    if (!dict.ContainsKey(firstWord[i]))
                    {
                        dict[firstWord[i]] = secondWord[i];
                    }
                    else
                    {
                        if (dict[firstWord[i]] != secondWord[i])
                        {
                            return false;
                        }
                    }
                }                
            }

            if(secondWord.Length > firstWord.Length)
            {
                var remaining = secondWord.Substring(firstWord.Length);
                foreach (var letter in remaining)
                {
                    if (!dict.ContainsValue(letter))
                    {
                        result = false;
                        break;
                    }
                }
            }       

            return result;
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            var firstWord = input[0];
            var secondWord = input[1];

            var result = CheckExchangeable(firstWord, secondWord)
                        .ToString()
                        .ToLower();
            Console.WriteLine(result);            
        }
    }
}
