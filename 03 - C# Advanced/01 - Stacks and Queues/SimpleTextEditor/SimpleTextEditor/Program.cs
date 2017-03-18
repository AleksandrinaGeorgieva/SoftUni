using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class Program
    {
        private static Stack<string> history = new Stack<string>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            history.Push("");
            for (int i = 0; i < n; i++)
            {
                string text = history.Peek();
                var input = Console.ReadLine()
                    .Split(' ');
                int commandId = int.Parse(input[0]);
                switch (commandId)
                {
                    case 1:
                        text += input[1];
                        history.Push(text);
                        break;
                    case 2:
                        int count = int.Parse(input[1]);
                        text = text.Substring(0, text.Length - count);
                        history.Push(text);
                        break;
                    case 3:
                        int pos = int.Parse(input[1]) - 1;
                        Console.WriteLine(text[pos]);
                        break;
                    case 4:
                        history.Pop();
                        break;
                }                
            }
        }
    }
}
