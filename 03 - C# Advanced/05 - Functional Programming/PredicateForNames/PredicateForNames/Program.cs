using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
    class Program
    {
        private static List<string> FilterNames(List<string> names, Func<string, bool> fn)
        {
            var result = new List<string>();
            foreach (var n in names)
            {
                if (fn(n))
                {
                    result.Add(n);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = FilterNames(names, x => x.Length <= n);

            result.ForEach(Console.WriteLine);
        }
    }
}
