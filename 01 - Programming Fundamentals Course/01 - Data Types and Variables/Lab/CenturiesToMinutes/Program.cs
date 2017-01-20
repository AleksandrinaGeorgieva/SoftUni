using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    static class Constants
    {
        public const int yearsInCenturies = 100;
        public const double daysInYear = 365.2422;
        public const short hoursInDay = 24;
        public const short minutesInHour = 60;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * Constants.yearsInCenturies;
            int days = (int) (years * Constants.daysInYear);
            long hours = days * Constants.hoursInDay;
            long minutes = hours * Constants.minutesInHour;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", 
                centuries,
                years, 
                days, 
                hours,
                minutes);

        }
    }
}
