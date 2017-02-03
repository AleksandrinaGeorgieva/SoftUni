using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        private static void AddContact (Dictionary<string, string> pBook, string name, string phone)
        {
            pBook[name] = phone;
        }

        private static void SearchContact(Dictionary<string, string> pBook, string name)
        {
            if (pBook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {pBook[name]}");
            }else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
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
                }

                input = Console.ReadLine()
                        .Split(' ')
                        .ToArray();
                command = input[0].ToLower();
            }


        }
    }
}
