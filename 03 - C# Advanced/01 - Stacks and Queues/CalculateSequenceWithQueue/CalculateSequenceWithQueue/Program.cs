using System;
using System.Collections.Generic;

namespace CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            int count = 0;
            var queue = new Queue<long>();
            queue.Enqueue(N);
            while(count != 50)
            {
                long el = queue.Dequeue();
                Console.Write($"{el} ");
                queue.Enqueue(el + 1);
                queue.Enqueue(2 * el + 1);
                queue.Enqueue(el + 2);

                count++;
            }
        }
    }
}
