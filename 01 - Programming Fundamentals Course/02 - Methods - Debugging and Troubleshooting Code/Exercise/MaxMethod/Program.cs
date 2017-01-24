using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
        
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int max = GetMax(firstNum, secondNum);
            Console.WriteLine(GetMax(max, thirdNum));
        }
    }
}
