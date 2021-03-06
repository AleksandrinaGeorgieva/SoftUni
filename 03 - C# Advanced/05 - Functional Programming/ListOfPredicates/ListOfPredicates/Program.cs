﻿namespace ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Functions
    {
        public static List<Func<int, bool>> predicates = new List<Func<int, bool>>();

        public static void AddPredicate(Func<int, bool> predicate)
        {
            predicates.Add(predicate);
        }

        public static List<int> ApplyPredicates(List<int> numbers)
        {
            List<int> result = new List<int>();
            bool legal = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                int curNumber = numbers[i];
                foreach (var pr in predicates)
                {
                    if (!pr(curNumber))
                    {
                        legal = false;
                        break;
                    }
                }

                if (legal)
                {
                    result.Add(curNumber);
                }
                legal = true;
            }

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            var divisors = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var divisor in divisors)
            {
                Functions.AddPredicate(x => x % divisor == 0);
            }

            numbers = Functions.ApplyPredicates(numbers);
            numbers.ForEach(x => Console.Write($"{x} "));

        }
    }
}
