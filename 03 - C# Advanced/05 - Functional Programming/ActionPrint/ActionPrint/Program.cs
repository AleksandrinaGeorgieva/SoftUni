using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Action<string> printString = Print;
            inputs.ForEach(printString);
        }

        public static void Print (string str)
        {
            Console.WriteLine(str);
        }
    }
}
