using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            long varLong;
            if (!long.TryParse(n, out varLong))
            {
                Console.WriteLine("{0} can't fit in any type", n);
            }
            else
            {
                Console.WriteLine("{0} can fit in:", n);
                sbyte varSByte;byte varByte;short varShort;
                ushort varUShort;int varInt;uint varUInt;

                if (sbyte.TryParse(n, out varSByte))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(n, out varByte))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(n, out varShort))
                {
                    Console.WriteLine("* short");
                }
                if (ushort.TryParse(n, out varUShort))
                {
                    Console.WriteLine("* ushort");
                }
                if (int.TryParse(n, out varInt))
                {
                    Console.WriteLine("* int");
                }
                if (uint.TryParse(n, out varUInt))
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }           
        }
    }
}
