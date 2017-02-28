using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        private static bool OnlyDigits (string s)
        {
            return s.All(char.IsDigit);
        }

        private static bool OnlyLettersAndDigits(string s)
        {
            return s.All(c => Char.IsLetterOrDigit(c));
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var broadcasts = new List<string>();
            var messages = new List<string>();
            while (input != "Hornet is Green")
            {
                if (input.Contains(" <-> "))
                {
                    var splitterIndex = input.IndexOf(" <-> ");
                    var firstQuery = input.Substring(0, splitterIndex);
                    var secondQuery = input.Substring(splitterIndex + 5);


                    if(OnlyDigits(firstQuery) && OnlyLettersAndDigits(secondQuery))
                    {
                        var t = firstQuery.Reverse().ToArray();
                        var str = string.Join("", t);
                        messages.Add(str + " -> " + secondQuery);
                    }

                    if(!firstQuery.Any(char.IsDigit) && OnlyLettersAndDigits(secondQuery))
                    {
                        var t = new List<string>();
                        for (int i = 0; i < secondQuery.Length; i++)
                        {
                            if (char.IsLetter(secondQuery[i]))
                            {
                                if (char.IsLower(secondQuery[i]))
                                {
                                    t.Add(secondQuery[i].ToString().ToUpper());
                                }
                                else
                                {
                                    t.Add(secondQuery[i].ToString().ToLower());
                                }
                            }else
                            {
                                var a = char.ToString(secondQuery[i]);
                                t.Add(a);
                            }
                        }

                        var m = string.Join("", t) + " -> " + firstQuery;
                        broadcasts.Add(m);
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if(broadcasts.Count > 0)
            {
                broadcasts.ForEach(Console.WriteLine);
            }else
            {
                Console.WriteLine("None");
            }
            
            Console.WriteLine("Messages:");
            if(messages.Count > 0)
            {
                messages.ForEach(Console.WriteLine);
            }else
            {
                Console.WriteLine("None");
            }
            

        }
    }
}
