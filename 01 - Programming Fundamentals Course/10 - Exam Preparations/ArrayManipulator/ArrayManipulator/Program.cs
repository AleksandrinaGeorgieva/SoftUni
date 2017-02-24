using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        private static List<int> array = new List<int>();

        private static void Exchange(int index)
        {
            if (index < array.Count && index > -1)
            {
                var temp = array.GetRange(0, index + 1);
                array.RemoveRange(0, index + 1);
                array.AddRange(temp);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

        }

        private static void GetMinOrMax(string type, string remainderType)
        {
            int remainder = remainderType == "even" ? 0 : 1;
            var tempValues = array
                .Where(x => x % 2 == remainder)
                .ToList();
            if(tempValues.Count == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            int num = type == "max" ? tempValues.Max() : tempValues.Min();
            int index = array.LastIndexOf(num);
            Console.WriteLine(index);       
        }

        private static void GetFirstOrLast(string type, string remainderType, int count)
        {
            if(count > array.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int remainder = remainderType == "even" ? 0 : 1;
            var tempValues = array
                .Where(x => x % 2 == remainder)
                .ToList();
            if(type == "first")
            {
                tempValues = tempValues
                    .Take(count)
                    .ToList();
            }else
            {
                int skip = Math.Max(0, tempValues.Count - count);
                tempValues = tempValues
                    .Skip(skip)
                    .Take(count)
                    .ToList();
            }
            Console.WriteLine($"[{string.Join(", ", tempValues)}]");
        }

        static void Main(string[] args)
        {
            array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string commandType;
            int tmpNumber;
            var command = Console.ReadLine();
            while(command.ToLower() != "end")
            {
                var splitted = command.Split(' ');
                commandType = splitted[0];

                switch (commandType)
                {
                    case "exchange":
                        tmpNumber = int.Parse(splitted[1]);
                        Exchange(tmpNumber);
                        break;
                    case "max": 
                    case "min": GetMinOrMax(commandType, splitted[1]); break;
                    case "first":
                    case "last":
                        tmpNumber = int.Parse(splitted[1]);
                        GetFirstOrLast(commandType, splitted[2], tmpNumber);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }
}
