using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletsOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            short first = 0;
            short second = 0;
            short third = 0;
            for (first = 0; first < n; first++)
            {
                for (second = 0; second < n; second++)
                {
                    for (third = 0; third < n; third++)
                    {
                        Console.WriteLine(
                            "{0}{1}{2}",
                            (char)('a' + first),
                            (char)('a' + second),
                            (char)('a' + third)
                            );
                    }
                }
            }
        }
    }
}
