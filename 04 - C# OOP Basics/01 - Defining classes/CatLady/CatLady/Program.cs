using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class Cat
    {
        public string name;
        public virtual void Print()
        {
            
        }
    }

    class Siamese : Cat
    {
        public int earSize;
        public override void Print()
        {
            Console.WriteLine($"Siamese {name} {earSize}");
        }
    }
    class Cymric : Cat
    {
        public decimal furLength;
        public override void Print()
        {
            Console.WriteLine($"Cymric {name} {furLength:f2}");
        }
    }
    class StreetExtraordinaire :Cat
    {
        public int decibels;
        public override void Print()
        {
            Console.WriteLine($"StreetExtraordinaire {name} {decibels}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var cats = new List<Cat>();

            while(input != "End")
            {
                var spl = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (spl[0])
                {
                    case "Siamese":
                        cats.Add(new Siamese{
                            name = spl[1],
                            earSize = int.Parse(spl[2])
                        });
                        break;
                    case "Cymric":
                        cats.Add(new Cymric {
                            name = spl[1],
                            furLength = decimal.Parse(spl[2])
                        });
                        break;
                    case "StreetExtraordinaire":
                        cats.Add(new StreetExtraordinaire
                        {
                            name = spl[1],
                            decibels = int.Parse(spl[2])
                        });
                        break;
                        
                }

                input = Console.ReadLine();

            }

            var searchedName = Console.ReadLine();

            var searchedCat = cats
                .FirstOrDefault(x => x.name == searchedName);

            if(searchedName != null)
            {
                searchedCat.Print();
            }
        }
    }
}
