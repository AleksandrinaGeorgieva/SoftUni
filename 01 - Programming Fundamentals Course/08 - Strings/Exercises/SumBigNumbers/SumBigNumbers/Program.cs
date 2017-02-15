using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var revA = a.Reverse().ToList();
            var revB = b.Reverse().ToList();
            var n = Math.Max(revA.Count, revB.Count);
            int remainder = 0;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                if(revA.Count <= i)
                {
                    revA.Add('0');
                }
                if(revB.Count <= i)
                {
                    revB.Add('0');
                }
                double tempSum = char.GetNumericValue(revA[i]) + char.GetNumericValue(revB[i]) + remainder;
                if(tempSum > 9)
                {
                    result += tempSum % 10;
                    remainder = 1;
                }else
                {
                    result += tempSum;
                    remainder = 0;
                }
            }
            if(remainder > 0)
            {
                result += remainder;
            }

            var resultNumber = result.Reverse().ToArray();
            var output = new string(resultNumber).TrimStart('0');
            Console.WriteLine(output);
            
        }
    }
}
