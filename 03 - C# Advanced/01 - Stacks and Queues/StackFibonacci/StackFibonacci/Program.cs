using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);

            /* softuni tests are not correct. the loop must be until i < n-2 */
            for (int i = 0; i < n-2; i++)
            {
                long a = stack.Pop();
                long b = stack.Pop();
                stack.Push(a);
                stack.Push(a + b);
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
