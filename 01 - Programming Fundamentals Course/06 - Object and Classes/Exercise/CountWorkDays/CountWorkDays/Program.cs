using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CountWorkDays
{
    class Program
    {
        private static List<string> officialHolidays = new List<string>
        {
            "01-01", "03-03", "01-05", "06-05", "24-05", "06-09", "22-09", "01-11", "24-12", "25-12", "26-12"
        };

        static void Main(string[] args)
        {
            var startDateString = Console.ReadLine();
            var startDate = DateTime.ParseExact(
                startDateString,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture
                );

            var endDateString = Console.ReadLine();
            var endDate = DateTime.ParseExact(
                endDateString,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture
                );

            int workDays = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var dayToCompareWithHoliday = i.ToString("dd-MM");
                bool isHoliday = officialHolidays.Contains(dayToCompareWithHoliday);
                if(i.DayOfWeek != DayOfWeek.Sunday
                    && i.DayOfWeek != DayOfWeek.Saturday
                    && !isHoliday)
                {
                    workDays++;
                }
            }
            Console.WriteLine(workDays);
        }
    }
}
