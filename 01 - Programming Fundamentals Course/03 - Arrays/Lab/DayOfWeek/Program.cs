using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { 
                "Invalid Day!",
                "Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday", 
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());
            if (day > 0 && day < 8)
            {
                Console.WriteLine(days[day]);
            }
            else
            {
                Console.WriteLine(days[0]);
            }
        }
    }
}
