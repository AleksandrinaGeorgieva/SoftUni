using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email;
            while(name.ToLower() != "stop")
            {
                email = Console.ReadLine();
                if(!email.ToLower().EndsWith("uk") && !email.ToLower().EndsWith("us"))
                {
                    contacts[name] = email;
                }
                name = Console.ReadLine();
            }

            foreach (var item in contacts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
