using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        public static void ExtractNumbers(List<int> output, string numbersList)
        {
            string trimmed = numbersList.Trim();
            int[] nums = trimmed.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            output.AddRange(nums);
        }

        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|')
                .ToList();
            lists.Reverse();

            List<int> output = new List<int>();
            lists.ForEach(x => ExtractNumbers(output, x));

            output.ForEach(x => Console.Write($"{x} "));
        }
    }
}
