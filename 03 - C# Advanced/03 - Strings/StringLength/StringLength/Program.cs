using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string result = input.Length >= 20 ? input.Substring(0, 20) : input.PadRight(20, '*');
            Console.WriteLine(result);
        }
    }
}
