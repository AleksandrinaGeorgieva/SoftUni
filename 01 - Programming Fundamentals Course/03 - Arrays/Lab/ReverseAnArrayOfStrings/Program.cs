using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var reversedArray = array.Reverse();
            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}
