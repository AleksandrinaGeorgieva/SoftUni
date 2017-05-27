using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Car
    {
        public string model;
        public Engine engine;
        public decimal weight;
        public string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }
    }

    class Engine
    {
        public string model;
        public decimal power;
        public decimal displacement;
        public string efficiency;

        public Engine(string model, decimal power)
        {
            this.model = model;
            this.power = power;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                decimal disp = 0;
                string eff = "n/a";
                if (input.Length > 2) {
                    bool hasDispl = decimal.TryParse(input[2], out disp);
                    if (hasDispl)
                    {
                        if(input.Length > 3)
                        {
                            eff = input[3];
                        }
                    }else
                    {
                        eff = input[2];
                    }
                }

                var newEngine = new Engine(input[0], decimal.Parse(input[1]))
                {
                    displacement = disp,
                    efficiency = eff
                };
                engines.Add(newEngine);
            }

            int m = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                var carInput = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentEngine = engines
                    .FirstOrDefault(x => x.model == carInput[1]);

                decimal weight = 0;
                string color = "n/a";
                if (carInput.Length > 2)
                {
                    bool hasDispl = decimal.TryParse(carInput[2], out weight);
                    if (hasDispl)
                    {
                        if (carInput.Length > 3)
                        {
                            color = carInput[3];
                        }
                    }
                    else
                    {
                        color = carInput[2];
                    }
                }

                var newCar = new Car(carInput[0], currentEngine)
                {
                    weight = weight,
                    color = color
                };
                cars.Add(newCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model}:");
                Console.WriteLine($"  {car.engine.model}:");
                Console.WriteLine($"    Power: {car.engine.power}");
                var d = car.engine.displacement == 0 ? "n/a" : car.engine.displacement.ToString();
                Console.WriteLine($"    Displacement: {d}");
                Console.WriteLine($"    Efficiency: {car.engine.efficiency}");
                var w = car.weight == 0 ? "n/a" : car.weight.ToString();
                Console.WriteLine($"  Weight: {w}");
                Console.WriteLine($"  Color: {car.color}");
            }
        }
    }
}
