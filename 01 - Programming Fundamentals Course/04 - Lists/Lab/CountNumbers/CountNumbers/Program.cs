using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        public static void PrintAndRemoveInteger(List<int> nums)
        {
            int num = nums[0];
            int countOfOccurrences = nums.RemoveAll(x => x == num);
            Console.WriteLine("{0} -> {1}", num, countOfOccurrences);
        }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            numbers.Sort();
            while (numbers.Count > 0)
            {
                PrintAndRemoveInteger(numbers);
            }
        }
    }
}
