namespace RecursiveFibonacci
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        private static Dictionary<long, long> nums = new Dictionary<long, long>();

        private static long getFibonacci(long n)
        {
            long f;
            if (n <= 2)
            {
                return 1;
            }
            if (!nums.ContainsKey(n))
            {
                nums[n] = getFibonacci(n - 1) + getFibonacci(n - 2);
            }
            f = nums[n];
            
            return f;
        }

        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            
            Console.WriteLine(getFibonacci(n));
        }
    }
}
