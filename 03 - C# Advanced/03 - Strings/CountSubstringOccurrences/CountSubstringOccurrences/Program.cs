using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var search = Console.ReadLine().ToLower();
            var lowerText = inputText.ToLower();
            int count = 0;
            int index = 0;
            int foundIndex = 0;
            while (true)
            {
                foundIndex = lowerText.IndexOf(search, index);
                if(foundIndex< 0)
                {
                    break;
                }else
                {
                    count++;
                    index = foundIndex + 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
