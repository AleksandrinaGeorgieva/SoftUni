using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var secondArray = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int len = (int)Math.Max(firstArray.Length, secondArray.Length);
            for (int i = 0; i < len; i++)
            {
                int a = i;
                int b = i;
                if (a >= firstArray.Length)
                {
                    a = i % firstArray.Length;
                }
                if (b >= secondArray.Length)
                {
                    b = i % secondArray.Length;
                }
                Console.Write("{0} ", firstArray[a] + secondArray[b]);

            }

        }
    }
}
