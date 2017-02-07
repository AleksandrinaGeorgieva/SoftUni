using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var firstRectangle = Rectangle.Create(firstInput[0], firstInput[1], firstInput[2], firstInput[3]);
            var secondRectangle = Rectangle.Create(secondInput[0], secondInput[1], secondInput[2], secondInput[3]);

            if (firstRectangle.IsInside(secondRectangle))
            {
                Console.WriteLine("Inside");
            }else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
