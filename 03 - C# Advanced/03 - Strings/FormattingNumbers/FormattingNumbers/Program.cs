using System;
using System.Text;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);


            var a = int.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);
            StringBuilder result = new StringBuilder();
            var aPart = a.ToString("X").PadRight(10, ' ');
            result.Append('|');
            result.Append(aPart);
            result.Append('|');

            var aSecondPart = Convert.ToString(a, 2);
            
            aSecondPart = aSecondPart.Length > 10 ? aSecondPart.Substring(0, 10) : aSecondPart.PadLeft(10, '0');

            result.Append(aSecondPart);
            result.Append('|');
            var bPart = b.ToString("0.00").PadLeft(10);
            result.Append(bPart);
            result.Append('|');

            var cPart = c.ToString("0.000").PadRight(10);
            result.Append(cPart);

            result.Append('|');


            Console.WriteLine(result.ToString());
        }
    }
}
