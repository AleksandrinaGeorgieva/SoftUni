namespace SinoTheWalker
{
    using System;
    using System.Numerics;
    using System.Globalization;
    class Program
    {
        public static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(
                Console.ReadLine(),
                "HH:mm:ss",
                CultureInfo.InvariantCulture
                );
            long steps = long.Parse(Console.ReadLine()) % 86400;
            long secPerStep = long.Parse(Console.ReadLine()) % 86400;
            long secondsToWalk = steps * secPerStep;
            startDate = startDate.AddSeconds(secondsToWalk);
           
            Console.WriteLine($"Time Arrival: {startDate.ToString("HH:mm:ss")}");
        }
    }
}
