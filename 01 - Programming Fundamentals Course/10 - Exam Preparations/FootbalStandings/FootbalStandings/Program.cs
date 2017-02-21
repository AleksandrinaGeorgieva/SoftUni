using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalStandings
{
    class Program
    {
        private static string decryptionKey = "";
        private static Dictionary<string, Team> teams = new Dictionary<string, Team>();

        private static void ExtractData(string input)
        {
            //the first name
            var firstIndex = input.IndexOf(decryptionKey);
            var firstNameIndex = firstIndex + decryptionKey.Length;
            var str = input.Substring(firstNameIndex);
            var secondIndex = str.IndexOf(decryptionKey);
            var name = str.Substring(0, secondIndex);
            var firstName = new string(name.Reverse().ToArray());
            firstName = firstName.Trim().ToUpper();
            str = str.Substring(name.Length + decryptionKey.Length);

            if (!teams.ContainsKey(firstName))
            {
                var t = new Team
                {
                    name = firstName,
                    goals = 0,
                    points = 0
                };
                teams.Add(firstName, t);
            }

            var lastIndex = str.LastIndexOf(decryptionKey);
            str = str.Substring(0, lastIndex);
            secondIndex = str.LastIndexOf(decryptionKey);
            name = str.Substring(secondIndex + decryptionKey.Length);


            var secondName = new string(name.Reverse().ToArray());
            secondName = secondName.Trim().ToUpper();

            if (!teams.ContainsKey(secondName))
            {
                var t = new Team
                {
                    name = secondName,
                    goals = 0,
                    points = 0
                };
                teams.Add(secondName, t);
            }

            // extract goals

            var splitted = input.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var secondTeamGoals = long.Parse(splitted.Last());
            var firstTeamGoals = long.Parse(splitted[splitted.Length - 2]);

            teams[firstName].goals += firstTeamGoals;
            teams[secondName].goals += secondTeamGoals;

            if(firstTeamGoals == secondTeamGoals)
            {
                teams[firstName].points++;
                teams[secondName].points++;
            }
            if(firstTeamGoals > secondTeamGoals)
            {
                teams[firstName].points += 3;
            }
            if (secondTeamGoals > firstTeamGoals)
            {
                teams[secondName].points += 3;
            }
        }

        private static void PrintStandings()
        {
            Console.WriteLine("League standings:");
            var teamsSorted = teams
                .OrderByDescending(x => x.Value.points)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            int place = 1;
            foreach (var team in teamsSorted)
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value.points}");
                place++;
            }
        }

        private static void PrintTop()
        {
            Console.WriteLine("Top 3 scored goals:");
            var teamsSorted = teams.
                OrderByDescending(x => x.Value.goals)
                .ThenBy(x => x.Key)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var team in teamsSorted)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.goals}");
            }
        }

        static void Main(string[] args)
        {
            decryptionKey = Console.ReadLine();

            var input = Console.ReadLine();
            while(input.ToLower() != "final")
            {
                ExtractData(input);
                input = Console.ReadLine();
            }
            PrintStandings();
            PrintTop();
        }
}
}
