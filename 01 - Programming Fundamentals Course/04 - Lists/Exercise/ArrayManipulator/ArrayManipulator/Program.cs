using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        private static string ExtractCommand(string message)
        {
            var splitted = message.Split(' ').ToArray();
            return splitted[0].ToLower();
        }

        private static void AddNumber(List<int> nums, string input)
        {
            var splitted = input.Split(' ').ToArray();
            int index = int.Parse(splitted[1]);
            int number = int.Parse(splitted[2]);
            nums.Insert(index, number);
        }

        private static void AddManyNumbers(List<int> nums, string input)
        {
            var temp = input.Split(' ').ToList();
            int index = int.Parse(temp[1]);
            //remove the command and the index
            temp.RemoveAt(0);
            temp.RemoveAt(0);
            var numbers = temp.Select(int.Parse).ToList();
            nums.InsertRange(index, numbers);
        }

        private static void RemoveNumber(List<int> nums, string input)
        {
            var temp = input.Split(' ').ToList();
            int number = int.Parse(temp[1]);

            nums.RemoveAt(number);
        }


        private static void ShiftNumbers(List<int> nums, string input)
        {
            var temp = input.Split(' ').ToList();
            int reps = int.Parse(temp[1]);

            for (int i = 0; i < reps; i++)
            {
                int n = nums[0];
                nums.RemoveAt(0);
                nums.Add(n);
            }
        }

        private static List<int> SumPairs(List<int> nums, string input)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i += 2)
            {
                if (i + 1 < nums.Count)
                {
                    result.Add(nums[i] + nums[i + 1]);
                }
                else
                {
                    result.Add(nums[i]);
                }
            }
            return result;
        }

        private static void CheckIfContains(List<int> nums, string input)
        {
            var temp = input.Split(' ').ToList();
            int number = int.Parse(temp[1]);

            int index = nums.FindIndex(x => x == number);
            Console.WriteLine(index);
        }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "print")
            {
                string command = ExtractCommand(input);
                switch (command)
                {
                    case "add": AddNumber(numbers, input); break;
                    case "addmany": AddManyNumbers(numbers, input); break;
                    case "contains": CheckIfContains(numbers, input); break;
                    case "remove": RemoveNumber(numbers, input); break;
                    case "shift": ShiftNumbers(numbers, input); break;
                    case "sumpairs": numbers = SumPairs(numbers, input); break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));

        }
    }
}
