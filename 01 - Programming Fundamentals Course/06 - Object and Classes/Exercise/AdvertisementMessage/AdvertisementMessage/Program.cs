using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        private static List<string> phrases = new List<string>
        {
            "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
        };

        private static List<string> events = new List<string>
        {
            "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great;"
        };

        private static List<string> authors = new List<string>
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        private static List<string> cities = new List<string>
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        private static string[] GenerateMessage(Random random)
        {
            int pRandom = random.Next(0, phrases.Count);
            int eRandom = random.Next(0, events.Count);
            int aRandom = random.Next(0, authors.Count);
            int cRandom = random.Next(0, cities.Count);

            return new string[] {
                phrases[pRandom],
                events[eRandom],
                authors[aRandom],
                cities[cRandom]
            };
        }

        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine());
            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                var message = GenerateMessage(random);
                Console.WriteLine($"{message[0]} {message[1]} {message[2]} - {message[3]}");
            }
        }
    }
}
