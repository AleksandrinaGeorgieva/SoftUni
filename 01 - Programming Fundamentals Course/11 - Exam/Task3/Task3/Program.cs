using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            long hornetsPower = 0;
            for (int i = 0; i < beehives.Count; i++)
            {
                hornetsPower = hornets.Sum();
                if(beehives[i] >= hornetsPower)
                {
                    beehives[i] -= hornetsPower;
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                        
                    
                }else
                {
                    beehives[i] = 0;
                }
            }

            if(beehives.Any(x => x > 0))
            {
                for (int i = 0; i < beehives.Count; i++)
                {
                    if(beehives[i] > 0)
                    {
                        Console.Write($"{beehives[i]} " );
                    }
                }
            }else
            {
                hornets.ForEach(x => Console.Write($"{x} "));
            }
            Console.WriteLine();
        }
    }
}
