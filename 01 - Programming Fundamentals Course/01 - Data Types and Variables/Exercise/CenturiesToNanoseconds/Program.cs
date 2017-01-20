using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    static class Constants
    {
        public const int yearsInCenturies = 100;
        public const double daysInYear = 365.2422;
        public const short hoursInDay = 24;
        public const short minutesInHour = 60;
        public const short secondsInMinute = 60;
        public const int milliSecondsInSecond = 1000;
        public const int microSecondsInMilliSecond = 1000;
        public const int nanoSecondsInMicroSecond = 1000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * Constants.yearsInCenturies;
            int days = (int)(years * Constants.daysInYear);
            long hours = days * Constants.hoursInDay;
            long minutes = hours * Constants.minutesInHour;
            long seconds = minutes * Constants.secondsInMinute;
            BigInteger milliSeconds = seconds * Constants.milliSecondsInSecond;
            BigInteger microSeconds = milliSeconds * Constants.microSecondsInMilliSecond;
            BigInteger nanoSeconds = microSeconds * Constants.nanoSecondsInMicroSecond;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries,
                years,
                days,
                hours,
                minutes,
                seconds,
                milliSeconds,
                microSeconds,
                nanoSeconds);

        }
    }
}
