namespace ConvertFromBaseNToBase10
{
    using System;
    using System.Linq;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int N = int.Parse(input[0]);
            var number = input[1];
            number = new string(number.Reverse().ToArray());

            BigInteger  result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                BigInteger cur = new BigInteger(char.GetNumericValue(number[i]));
                BigInteger b = BigInteger.Pow(N, i);
                BigInteger tempSum = (BigInteger)(cur * b);
                result += tempSum;
            }
            Console.WriteLine(result);
        }
    }
}
