using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class Program
    {
        private static char findOpeningParenthesis(char close)
        {
            char opening = ' ';
            switch (close)
            {
                case ']': opening = '['; break;
                case '}': opening = '{'; break;
                case ')': opening = '('; break;
            }
            return opening;
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if(input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            var openSymbols = new char[] { '{', '(', '['};
            var closeSymbols = new char[] { '}', ')', ']'};

            var stackOpened = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (openSymbols.Contains(input[i]))
                {
                    stackOpened.Push(input[i]);
                }else
                {
                    var closing = input[i];
                    var lastInStack = stackOpened.Peek();
                    if(findOpeningParenthesis(closing) == lastInStack)
                    {
                        stackOpened.Pop();
                    }else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
