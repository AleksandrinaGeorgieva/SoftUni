using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFunction
{
    
    class Program
    {
        private static bool MyFunc(string name, int n)
        {
            return name
                .ToCharArray()
                .Select(x => (int)x)
                .Sum() >= n;
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string[], int, Func<string, int, bool>, string> fn = (name, num, func) => names.FirstOrDefault(x => func(x, num));
            Console.WriteLine(fn(names, n, MyFunc));
        }
    }
}
