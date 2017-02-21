using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < N; i++)
            {
                decimal pricePerCapsula = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(
                    Console.ReadLine(),
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture
                    );
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = daysInMonth * capsulesCount * pricePerCapsula;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
