using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Trainer
    {
        public string name;
        public int badges;
        public List<Pokemon> pokemon;

        public Trainer(string name, List<Pokemon> pokemon)
        {
            this.badges = 0;
            this.name = name;
            this.pokemon = pokemon;
        }
    }

    class Pokemon
    {
        public string name;
        public string element;
        public int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, Trainer>();

            while(input != "Tournament")
            {
                var spl = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = spl[0];
                if (!data.ContainsKey(trainerName))
                {
                    data[trainerName] = new Trainer(trainerName, new List<Pokemon>());
                }
                var newPokemon = new Pokemon(spl[1], spl[2], int.Parse(spl[3]));
                data[trainerName].pokemon.Add(newPokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while(input != "End")
            {
                foreach (var trainer in data)
                {
                    if(trainer.Value.pokemon.Any(x => x.element == input))
                    {
                        trainer.Value.badges++;
                    }else
                    {
                        foreach (var pm in trainer.Value.pokemon)
                        {
                            pm.health -= 10;
                        }
                        trainer.Value.pokemon = trainer.Value.pokemon
                            .Where(x => x.health > 0)
                            .ToList();
                    }
                }
                input = Console.ReadLine();
            }

            data
                 .OrderByDescending(x => x.Value.badges)
                 .ToList()
                 .ForEach(x => Console.WriteLine($"{x.Key} {x.Value.badges} {x.Value.pokemon.Count}"));

        }
    }
}
