using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Car
    {
        public string model;
        public decimal fuelAmount;
        public decimal fuelCost;
        public decimal distanceTravelled;

        public Car(string model, decimal fAmount, decimal fCost)
        {
            this.model = model;
            this.fuelAmount = fAmount;
            this.fuelCost = fCost;
            this.distanceTravelled = 0;
        }

        public bool CheckCanGo(decimal dist)
        {
            return this.fuelCost * dist <= this.fuelAmount;
        }

        public void Drive(decimal dist)
        {

            var cost = dist * this.fuelCost;
            this.fuelAmount -= cost;
            this.distanceTravelled += dist;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                cars.Add(new Car (input[0], decimal.Parse(input[1]), decimal.Parse(input[2])));
            }

            var driveInput = Console.ReadLine();

            while(driveInput.ToLower() != "end")
            {

                var spl = driveInput.Split();
                var car = cars
                    .Where(x => x.model == spl[1])
                    .FirstOrDefault();
                var d = decimal.Parse(spl[2]);
                if (car.CheckCanGo(d))
                {
                    car.Drive(d);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }


                driveInput = Console.ReadLine();
            }

            cars
                .ForEach(x => Console.WriteLine($"{x.model} {x.fuelAmount:f2} {x.distanceTravelled}"));
        }
    }
}
