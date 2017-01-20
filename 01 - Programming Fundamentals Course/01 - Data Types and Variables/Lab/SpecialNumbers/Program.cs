using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                foreach (char symbol in i.ToString())
                {
                    sum += int.Parse(symbol.ToString());
                }
                bool special = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
