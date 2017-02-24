using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootbalStandings
{
    class Program
    {
        private static string decryptionKey = "";
        private static Dictionary<string, Team> teams = new Dictionary<string, Team>();
        private static Regex reg;

        private static void ExtractData(string input)
        {
            var matches = reg.Matches(input);
            Team t;
            var tempTeams = new List<string>();
            foreach (Match m in matches)
            {
                var tName = m.Groups[1].Value
                    .ToUpper()
                    .Reverse()
                    .ToArray();
                var name = new string(tName);
                if (!teams.ContainsKey(name))
                {
                    t = new Team
                    {
                        name = name,
                        goals = 0,
                        points = 0
                    };
                    teams.Add(name, t);
                }
                tempTeams.Add(name);
            }

            var tempPoints = input
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Last()
                .Split(':')
                .ToArray();
            var firstTeamPoints = int.Parse(tempPoints[0]);
            var secondTeamPoints = int.Parse(tempPoints[1]);
            teams[tempTeams[0]].goals += firstTeamPoints;
            teams[tempTeams[1]].goals += secondTeamPoints; 
            if (firstTeamPoints == secondTeamPoints)
            {
                teams[tempTeams[0]].points++;
                teams[tempTeams[1]].points++;
            }else if(firstTeamPoints > secondTeamPoints)
            {
                teams[tempTeams[0]].points += 3;
            }else
            {
                teams[tempTeams[1]].points += 3;
            }
        }

        private static void PrintStandings()
        {
            var temp = teams
                .OrderByDescending(x => x.Value.points)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var t in temp)
            {
                Console.WriteLine($"{count}. {t.Key} {t.Value.points}");
                count++;
            }
        }

        private static void PrintTop()
        {
            Console.WriteLine("Top 3 scored goals:");
            var temp = teams
                .OrderByDescending(x => x.Value.goals)
                .ThenBy(x => x.Key)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var t in temp)
            {
                Console.WriteLine($"- {t.Key} -> {t.Value.goals}");
            }
        }

        static void Main(string[] args)
        {
            decryptionKey = Console.ReadLine();
            var command = Console.ReadLine();
            var regEsc = Regex.Escape(decryptionKey);
            reg = new Regex(regEsc + @"(.*?)" + regEsc);
            while (command.ToLower() != "final")
            {
                ExtractData(command);
                command = Console.ReadLine();
            }
            PrintStandings();
            PrintTop();
        }
    }
}
