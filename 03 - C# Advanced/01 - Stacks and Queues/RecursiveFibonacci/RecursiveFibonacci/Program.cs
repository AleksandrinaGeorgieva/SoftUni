namespace RecursiveFibonacci
{
    using System;
    class Program
    {
        private static int getFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return getFibonacci(n - 1) + getFibonacci(n - 2);
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(getFibonacci(n));
        }
    }
}
