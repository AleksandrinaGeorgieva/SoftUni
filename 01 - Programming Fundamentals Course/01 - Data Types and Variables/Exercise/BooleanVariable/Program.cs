using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            Console.WriteLine(Convert.ToBoolean(answer) ? "Yes" : "No");
        }
    }
}
