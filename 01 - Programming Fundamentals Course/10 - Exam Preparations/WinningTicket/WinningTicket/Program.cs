namespace WinningTicket
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        private static char[] separators = new[] { ' ', '\t', ','};
        public static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            var tickets = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var winningSymbol = new Regex(@"(\$|@|\^|#)\1{5,}");

            for (int i = 0; i < tickets.Length; i++)
            {
                string current = tickets[i];
                if (current.Length == 20)
                {
                    var left = current.Substring(0, 10);
                    var right = current.Substring(10, 10);
                    if(winningSymbol.IsMatch(left) && winningSymbol.IsMatch(right))
                    {
                        var leftMatch = winningSymbol.Match(left).Value;
                        var rightMatch = winningSymbol.Match(right).Value;
                        var minLength = Math.Min(leftMatch.Length, rightMatch.Length);
                        if(minLength == 10)
                        {
                            Console.WriteLine($"ticket \"{current}\" - 10{leftMatch[0]} Jackpot!");
                                
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{current}\" - {minLength}{leftMatch[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{current}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
