using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            long portions = (long)Math.Ceiling((decimal)(guests / 6.0));
            double priceForSet = 2 * bananaPrice + 4 * eggPrice + 0.2 * berriesPrice;
            double totalPrice = priceForSet * portions;
            if(totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }else
            {
                double diff = totalPrice - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:f2}lv more.");
            }
        }
    }
}
