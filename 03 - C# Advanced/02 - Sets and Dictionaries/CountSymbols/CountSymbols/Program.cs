using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var data = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!data.ContainsKey(text[i]))
                {
                    data[text[i]] = 0;
                }

                data[text[i]]++;
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
