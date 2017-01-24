using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        public static void PrintHelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            PrintHelloName(userName);
        }
    }
}
