using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var actionNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numbersToDequeue = actionNumbers[1];
            int numberToSearch = actionNumbers[2];

            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(numbers);

            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(numberToSearch))
            {
                Console.WriteLine("true");
            }else
            {
                if(queue.Count > 0)
                {
                    Console.WriteLine(queue.Min());
                }else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
