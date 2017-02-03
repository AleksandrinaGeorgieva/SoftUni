using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        private static string namePrefix = "user=";
        private static string ipPrefix = "IP=";

        private static string ExtractName(string text)
        {
            return string.Join("", text.Skip(namePrefix.Length));
        }

        private static string ExtractIP(string text)
        {
            return string.Join("", text.Skip(ipPrefix.Length));
        }

        private static void PrintResults(SortedDictionary<string, Dictionary<string, int>> logs)
        {
            string temp = "";
            foreach (var item in logs)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var ip in item.Value)
                {
                    temp += $"{ip.Key} => {ip.Value}, ";
                }
                temp = temp.Remove(temp.Length - 2, 2);
                Console.WriteLine(temp + ".");
                temp = "";
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splitted = new string[3];
            var logs = new SortedDictionary<string, Dictionary<string, int>>();
            string username, userIp;
            while(input.ToLower() != "end")
            {
                splitted = input
                    .Split(' ')
                    .ToArray();

                username = ExtractName(splitted[2]);
                userIp = ExtractIP(splitted[0]);

                if (!logs.ContainsKey(username))
                {
                    logs[username] = new Dictionary<string, int>();
                }
                if (!logs[username].ContainsKey(userIp))
                {
                    logs[username][userIp] = 0;
                }

                logs[username][userIp]++;

                input = Console.ReadLine();
            }
            PrintResults(logs);
        }
    }
}
