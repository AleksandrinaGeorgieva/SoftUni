using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var N = int.Parse(input[0]);
            if(N < 2 || N > 10)
            {
                return;
            }
            var number = BigInteger.Parse(input[1]);

            int reminder = 1;
            BigInteger temp = number;
            var result = new List<decimal>();
            while(temp > 0)
            {
                reminder = (int)(temp % N);
                temp = (temp / N);
                result.Add(reminder);
            }
            result.Reverse();
            result.ForEach(Console.Write);
        }
    }
}
