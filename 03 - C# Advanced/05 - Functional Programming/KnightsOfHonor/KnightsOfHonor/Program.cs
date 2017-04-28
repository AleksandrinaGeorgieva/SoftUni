using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => "Sir " + x)
                .ToList();

            Action<string> printData = Print;
            inputs.ForEach(printData);
        }

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
