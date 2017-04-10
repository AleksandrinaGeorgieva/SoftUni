using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerlahShake
{
    class Program
    {
        private static string pattern = "";
        private static string str = "";

        private static bool ShakeOff()
        {
            bool success = false;
            var firstMatch = str.IndexOf(pattern);
            var lastMatch = str.LastIndexOf(pattern);
            if(
                !string.IsNullOrEmpty(pattern) &&
                (firstMatch > -1 && lastMatch > -1 && lastMatch != firstMatch)
                )
            {
                str = str.Remove(firstMatch, pattern.Length);
                lastMatch = str.LastIndexOf(pattern);
                str = str.Remove(lastMatch, pattern.Length);
                Console.WriteLine("Shaked it.");
                success = true;

                int index = pattern.Length / 2;
                pattern = pattern.Remove(index, 1);
            }else
            {
                Console.WriteLine("No shake.");
            }
            return success;
        }

        static void Main(string[] args)
        {
            str = Console.ReadLine();
            pattern = Console.ReadLine();

            while (true)
            {
                bool success = ShakeOff();
                if (!success)
                {
                    break;
                }
            }
            Console.WriteLine(str);
        }
    }
}
