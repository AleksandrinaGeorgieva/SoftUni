using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            int max = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                switch (input[0])
                {
                    case 1:
                        stack.Push(input[1]);
                        if(input[1] > max)
                        {
                            max = input[1];
                        }
                        break;
                    case 2:
                        int el = stack.Pop();
                        if(el == max)
                        {
                            if(stack.Count > 0)
                            {
                                max = stack.Max();
                            }
                            else
                            {
                                max = int.MinValue;
                            }                            
                        }
                        break;
                    case 3:
                        Console.WriteLine(max);
                        break;
                }
            }
        }
    }
}
