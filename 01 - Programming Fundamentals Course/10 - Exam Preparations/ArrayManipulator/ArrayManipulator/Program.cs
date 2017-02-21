using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        private static int[] arr = new int[1];

        private static void Exchange(string input)
        {
            var splitted = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(splitted[1]);
            if(index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            var newArr = new List<int>();

            for (int i = index + 1; i < arr.Length; i++)
            {
                newArr.Add(arr[i]);
            }
            for (int i = 0; i <= index; i++)
            {
                newArr.Add(arr[i]);
            }
            arr = newArr.ToArray();
        }

        private static void MaxOdd(string input)
        {
            try
            {
                var max = arr.Where(x => x % 2 == 1).Max();
                var index = arr.ToList().LastIndexOf(max);
                Console.WriteLine(index);
            }
            catch
            {
                Console.WriteLine("No matches");
            }            
        }

        private static void MaxEven(string input)
        {

            try
            {
                var max = arr.Where(x => x % 2 == 0).Max();
                 var index = arr.ToList().LastIndexOf(max);
                Console.WriteLine(index);
            }catch
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MinOdd(string input)
        {
            try
            {
                var min = arr.Where(x => x % 2 == 1).Min();
                var index = arr.ToList().LastIndexOf(min);
                Console.WriteLine(index);
            }
            catch
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MinEven(string input)
        {

            try
            {
                var min = arr.Where(x => x % 2 == 0).Min();
                var index = arr.ToList().LastIndexOf(min);
                Console.WriteLine(index);
            }
            catch
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FirstEven(string input)
        {
            var splitted = input
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(splitted[1]);
            if(count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var even = arr
                .Where(x => x % 2 == 0)
                .Take(count)
                .ToArray();
            Console.WriteLine("[" + string.Join(", ", even) + "]");
        }

        private static void FirstOdd(string input)
        {
            var splitted = input
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(splitted[1]);
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var odd = arr
                .Where(x => x % 2 == 1)
                .Take(count)
                .ToArray();
            Console.WriteLine("[" + string.Join(", ", odd) + "]");
        }

        private static void LastOdd(string input)
        {
            var splitted = input
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(splitted[1]);
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var odd = arr
                .Where(x => x % 2 == 1)
                .Reverse()
                .Take(count)
                .Reverse()
                .ToArray();
            Console.WriteLine("[" + string.Join(", ", odd) + "]");
        }

        private static void LastEven(string input)
        {
            var splitted = input
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(splitted[1]);
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var even = arr
                .Where(x => x % 2 == 0)
                .Reverse()
                .Take(count)
                .Reverse()
                .ToArray();
            Console.WriteLine("[" + string.Join(", ", even) + "]");
        }

        static void Main(string[] args)
        {
            arr = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var input = Console.ReadLine();
            while(input.ToLower() != "end")
            {
                if (input.Contains("exchange"))
                {
                    Exchange(input);
                }
                if(input.Contains("max") && input.Contains("odd"))
                {
                    MaxOdd(input);
                }
                if (input.Contains("max") && input.Contains("even"))
                {
                    MaxEven(input);
                }
                if (input.Contains("min") && input.Contains("odd"))
                {
                    MinOdd(input);
                }
                if (input.Contains("min") && input.Contains("even"))
                {
                    MinEven(input);
                }

                if (input.Contains("first"))
                {
                    if (input.Contains("even"))
                    {
                        FirstEven(input);
                    }
                    if (input.Contains("odd"))
                    {
                        FirstOdd(input);
                    }
                }

                if (input.Contains("last"))
                {
                    if (input.Contains("even"))
                    {
                        LastEven(input);
                    }
                    if (input.Contains("odd"))
                    {
                        LastOdd(input);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
    }
}
