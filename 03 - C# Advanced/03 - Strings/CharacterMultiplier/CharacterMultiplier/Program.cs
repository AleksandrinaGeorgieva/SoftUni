using System;
using System.Numerics;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var firstWord = input[0];
            var secondWord = input[1];

            var n = Math.Min(firstWord.Length, secondWord.Length);
            BigInteger sum = 0;
            for (int i = 0; i < n; i++)
            {
                var a = (firstWord[i]);
                var b = (secondWord[i]);
                sum += a * b;
            }

            var remaining = firstWord.Substring(n, firstWord.Length - n);
            remaining += secondWord.Substring(n, secondWord.Length - n);

            foreach (var letter in remaining)
            {
                sum += letter;
            }
            Console.WriteLine(sum);
        }
    }
}
