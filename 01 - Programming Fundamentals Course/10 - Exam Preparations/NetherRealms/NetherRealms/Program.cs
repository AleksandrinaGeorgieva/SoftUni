using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class Program
    {
        private static Regex regHealth = new Regex(@"[^0-9\+\-\*\.\/\s\,]");
        private static decimal CalculateHealth(string name)
        {
            decimal health = 0;
            var chars = name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (regHealth.IsMatch(chars[i].ToString()))
                {
                    health += (int)chars[i];
                }
            }
            return health;
        }


        private static decimal CalculateDamage(string name)
        {
            var numbersRegex = new Regex(@"(\-|\+)?\d+\.?\d*");
            var nums = numbersRegex.Matches(name);
            double sum = 0;
            foreach (Match m in nums)
            {
                double temp = double.Parse(m.Value);
                sum += temp;
            }
            for (int i = 0; i < name.Length; i++)
            {
                var symbol = name[i];
                if(symbol == '/')
                {
                    sum /= 2;
                }
                if(symbol == '*')
                {
                    sum *= 2;
                }
            }
            return (decimal) sum;
        }

        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < names.Count; i++)
            {
                var name = names[i];
                decimal health = CalculateHealth(name);
                decimal damage = CalculateDamage(name);
                Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
            }
        }
    }
}
