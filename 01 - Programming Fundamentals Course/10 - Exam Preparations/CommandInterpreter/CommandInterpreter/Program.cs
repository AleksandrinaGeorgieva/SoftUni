using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        private static List<string> array = new List<string>();
        private static List<string> tempArr = new List<string>();
        private static void Reverse(string input)
        {
            var numbers = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            tempArr.Clear();
            int start = int.Parse(numbers[2]);
            int count = int.Parse(numbers[4]);
            int end = start + count;
            if (start < 0 || start >= array.Count
                || count < 0
                || count + start > array.Count
                )
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            tempArr = array.Skip(start).Take(count).Reverse().ToList();
            array.RemoveRange(start, count);
            array.InsertRange(start, tempArr);
        }

        private static void Sort(string input)
        {
            
            int start = 0;
            int count = 0;
            string temp = input.Replace("sort", "");
            temp = temp.Replace("from", "");
            temp = temp.Replace("count", "");
            var numbers = temp.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            tempArr.Clear();
            start = int.Parse(numbers[0]);
            count = int.Parse(numbers[1]);

            if (start < 0 || start >= array.Count
            || count < 0
            || count + start > array.Count
            )
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            int end = start + count;
            var pieceSorted = array
                .GetRange(start, count)
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < start; i++)
            {
                tempArr.Add(array[i]);
            }
            tempArr.AddRange(pieceSorted);
            for (int i = end; i < array.Count; i++)
            {
                tempArr.Add(array[i]);
            }
            array = tempArr.ToList();
        }

        private static void RollLeft(string input)
        {
            //try
            // {
            
                string temp = input.Replace("rollLeft", "");
                temp = temp.Replace("times", "");
            
            var numbers = temp.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                long count = 0;
            
            count = long.Parse(numbers[0]);
            
            if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    return;
                }
            if(count > array.Count && array.Count > 0)
            {
                count = count % array.Count;
            }
            if(array.Count > 0)
            {
                for (int i = 0; i < count; i++)
                {

                    var t = array[0];
                    array.RemoveAt(0);
                    array.Add(t);
                }
            }
            
        }

        private static void RollRight(string input)
        {
            try
            {
                string temp = input.Replace("rollRight", "");
                temp = temp.Replace("times", "");
                var numbers = temp.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                count = int.Parse(numbers[0]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    return;
                }
                if (count > array.Count && array.Count > 0)
                {
                    count = count % array.Count;
                }
                    
                if(array.Count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {

                        var t = array[array.Count - 1];
                        array.RemoveAt(array.Count - 1);
                        array.Insert(0, t);
                    }
                }
               
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        static void Main(string[] args)
        {
            array = Console.ReadLine()
                .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (command.ToLower().Contains("reverse"))
                {
                    Reverse(command);
                }

                if (command.ToLower().Contains("sort"))
                {
                    Sort(command);
                }
                if (command.ToLower().Contains("rollleft"))
                {
                    RollLeft(command);
                }
                if (command.ToLower().Contains("rollright"))
                {
                    RollRight(command);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
    }
}
