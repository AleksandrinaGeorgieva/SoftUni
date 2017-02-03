using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        private static void PrintCards(Dictionary<string, List<string>> cards)
        {
            foreach (var item in cards)
            {
                var cardsSum = item
                    .Value
                    .Distinct()
                    .Select( x=> GetCardValue(x))
                    .ToList()
                    .Sum();

                Console.WriteLine($"{item.Key}: {cardsSum}");
            }
        }

        private static int GetCardValue(string card)
        {
            int value = 0;
            var cardsWeight = new Dictionary<char, int>()
            {
                { '2', 2},
                { '3', 3},
                { '4', 4},
                { '5', 5},
                { '6', 6},
                { '7', 7},
                { '8', 8},
                { '9', 9},
                { 'J', 11 },
                { 'Q', 12 },
                { 'K', 13},
                { 'A', 14}
            };

            var typesWeight = new Dictionary<char, int>
            {
                { 'S', 4},
                { 'H', 3},
                { 'D', 2},
                { 'C', 1}
            };

            var cardSymbols = card.ToCharArray();
            if (cardSymbols.Length == 3)
            {
                value = 10 * typesWeight[cardSymbols[2]];
            } else if (card == "JOKER") {
                value = 0;
            } else
            {
                value = cardsWeight[cardSymbols[0]] * typesWeight[cardSymbols[1]];
            }
            return value;
        }

        static void Main(string[] args)
        {
            var cards = new Dictionary<string, List<string>>();
            bool jokerDrawn = false;

            while (!jokerDrawn)
            {
                var input = Console.ReadLine()
                    .Split(':')
                    .ToArray();
                
                if (input.Contains("JOKER"))
                {
                    jokerDrawn = true;
                }

                if(input.Length > 1)
                {
                    string name = input[0];
                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new List<string>();
                    }
                    string[] drawnCards = input[1]
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                    cards[name].AddRange(drawnCards);
                }                
            }
            PrintCards(cards);
        }
    }
}
