using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Engine
    {
        public int speed;
        public int power;
    }

    class Cargo
    {
        public string type;
        public int weight;
    }

    class Tire
    {
        public int age;
        public double pressure;
    }

    class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
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
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var engine = new Engine {
                    speed = int.Parse(input[1]),
                    power = int.Parse(input[2])
                };

                var cargo = new Cargo
                {
                    weight = int.Parse(input[3]),
                    type = input[4]
                };

                var tires = new List<Tire>();
                tires.Add(new Tire
                {
                    pressure = double.Parse(input[5]),
                    age = int.Parse(input[6])
                });
                tires.Add(new Tire
                {
                    pressure = double.Parse(input[7]),
                    age = int.Parse(input[8])
                });
                tires.Add(new Tire
                {
                    pressure = double.Parse(input[9]),
                    age = int.Parse(input[10])
                });
                tires.Add(new Tire
                {
                    pressure = double.Parse(input[11]),
                    age = int.Parse(input[12])
                });

                var car = new Car(input[0], engine, cargo, tires);
                cars.Add(car);
            }

            var requestedCars = Console.ReadLine();
            if(requestedCars == "fragile")
            {
                cars
                    .Where(x => x.cargo.type == "fragile"
                        && x.tires.Any(y => y.pressure < 1))
                        .ToList()
                        .ForEach(x => Console.WriteLine(x.model));

            }else
            {
                cars
                    .Where(x => x.cargo.type == "flamable"
                        && x.engine.power > 250)
                        .ToList()
                        .ForEach(x => Console.WriteLine(x.model));
            }
        }
    }
}
