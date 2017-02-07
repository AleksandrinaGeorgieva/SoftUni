using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "d-M-yyyy";
            string date = Console.ReadLine();

            var parsedDate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            Console.WriteLine(parsedDate.DayOfWeek);

        }
    }
}
