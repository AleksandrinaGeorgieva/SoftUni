using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var actionNumbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(numbers);

            int numbersToPop = actionNumbers[1];
            int numbersToSearch = actionNumbers[2];

            for(int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(numbersToSearch))
            {
                Console.WriteLine("true");
            }else
            {
                if(stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }else
                {
                    Console.WriteLine(0);
                }               
            }
        }
    }
}
