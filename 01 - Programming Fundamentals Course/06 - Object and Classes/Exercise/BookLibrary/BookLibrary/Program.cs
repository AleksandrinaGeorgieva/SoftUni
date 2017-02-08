using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibrary
{
    class Program
    {
        private static Library lib = new Library {
            books = new List<Book>()
        };

        private static void AddBook(string[] input)
        {
            var book = new Book
            {
                title = input[0],
                author = input[1],
                publisher = input[2],
                date = DateTime.ParseExact(
                        input[3],
                        "dd.MM.yyyy",
                        CultureInfo.InvariantCulture
                    ),                
                ISBNNumber = input[4],
                price = double.Parse(input[5])
            };
            lib.books.Add(book);
        }

        private static void PrintResults()
        {
            var dict = new Dictionary<string, double>();
            var authors = lib.books
                .Select(x => x.author)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
            for (int i = 0; i < authors.Length; i++)
            {
                var sum = lib.books
                    .Where(x => x.author == authors[i])
                    .Select(x => x.price)
                    .Sum();
                dict.Add(authors[i], sum);
            }

            foreach (var author in dict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
        /*print all titles released after given date ordered by date and then by title lexicographically. The date is given if format “day-month-year” at the last line in the input.*/
        private static void PrintTitlesAfterDate(DateTime d)
        {
            var books = lib.books
                .Where(x => x.date > d)
                .OrderBy(x => x.date)
                .ThenBy(x => x.title)
                .ToList();
            books.ForEach(x => Console.WriteLine($"{x.title} -> {x.date.ToString("dd.MM.yyyy")}"));
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                AddBook(input);
            }
            var dateString = Console.ReadLine();
            var date = DateTime.ParseExact(
                dateString,
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture
                );
            //PrintResults();
            PrintTitlesAfterDate(date);
        }
    }
}
