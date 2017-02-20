using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int avgLaps = int.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long possibleRunnersForAllDays = days * trackCapacity;
            long raceRunners = Math.Min(possibleRunnersForAllDays, runners);
            long totalMeters = raceRunners * avgLaps * lapLength;
            long totalKm = totalMeters / 1000;
            decimal moneyRased = totalKm * (decimal)moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRased:f2}");
        }
    }
}
