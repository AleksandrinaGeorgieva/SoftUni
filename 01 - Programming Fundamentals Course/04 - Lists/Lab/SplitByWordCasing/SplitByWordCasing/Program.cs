using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        public static bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !char.IsLetter(ch));
        }

        static void Main(string[] args)
        {
            char[] splitters = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '};
            List<string> words = Console.ReadLine()
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowers = words.FindAll(x => x.ToLower() == x && !HasSpecialChars(x));
            List<string> uppers = words.FindAll(x => x.ToUpper() == x && !HasSpecialChars(x));
            words.RemoveAll(x => x.ToLower() == x && !HasSpecialChars(x));
            words.RemoveAll(x => x.ToUpper() == x && !HasSpecialChars(x));

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowers));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", words));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppers));
        }
    }
}
