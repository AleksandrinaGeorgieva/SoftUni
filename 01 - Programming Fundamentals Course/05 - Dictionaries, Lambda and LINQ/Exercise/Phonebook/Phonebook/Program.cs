using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        private static void AddContact (SortedDictionary<string, string> pBook, string name, string phone)
        {
            pBook[name] = phone;
        }

        private static void SearchContact(SortedDictionary<string, string> pBook, string name)
        {
            if (pBook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {pBook[name]}");
            }else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        private static void ListContacts(SortedDictionary<string, string> pBook)
        {
            foreach (var item in pBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            var input = Console.ReadLine()
                        .Split(' ')
                        .ToArray();
            var command = input[0].ToLower();
            while(command != "end")
            {
                switch (command)
                {
                    case "a": AddContact(phonebook, input[1], input[2]); break;
                    case "s": SearchContact(phonebook, input[1]); break;
                    case "listall": ListContacts(phonebook); break;
                }

                input = Console.ReadLine()
                        .Split(' ')
                        .ToArray();
                command = input[0].ToLower();
            }


        }
    }
}
