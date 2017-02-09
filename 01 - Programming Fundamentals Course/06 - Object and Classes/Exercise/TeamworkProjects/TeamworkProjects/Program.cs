using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        public static List<Team> teams = new List<Team>();

        private static void CreateTeams()
        {
            int n = int.Parse(Console.ReadLine());
            string teamName, creator;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split('-');
                teamName = input[1];
                creator = input[0];
                if (teams.Exists(x => x.name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                } else if (teams.Exists(x => x.creator == creator)) {
                    Console.WriteLine($"{creator} cannot create another team!");
                } else
                {
                    var currentTeam = new Team
                    {
                        creator = creator,
                        name = teamName,
                        members = new List<string>()
                    };
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }                
            }
        }

        private static void AddMembers()
        {
            var input = Console.ReadLine();
            string teamName;
            Team currentTeam;
            int teamIndex;
            string newMember;
            while (input != "end of assignment")
            {
                var splitted = input.Split(new string[] { "->" }, StringSplitOptions.None);
                teamName = splitted[1];
                newMember = splitted[0];
                teamIndex = teams
                        .FindIndex(x => x.name == teamName);

                if(teamIndex < 0)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }else if (teams.Exists(
                    x => x.members.Contains(newMember)
                    )
                    || teams.Exists(x => x.creator == newMember))
                {
                    Console.WriteLine($"Member {newMember} cannot join team {teamName}!");
                }else
                {
                    currentTeam = teams[teamIndex];
                    currentTeam.members.Add(newMember);
                }
                input = Console.ReadLine();
            }
        }

        private static void PrintTeams()
        {
            var temp = teams
                .Where(x => x.members.Count > 0)
                .OrderByDescending(x => x.members.Count)
                .ThenBy(x => x.name)
                .ToList();
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"{temp[i].name}");
                Console.WriteLine($"- {temp[i].creator}");
                temp[i].members
                    .OrderBy(x => x)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"-- {x}"));
            }
            var disbanded = teams
                .Where(x => x.members.Count == 0)
                .OrderBy(x => x.name)
                .ToList();
                Console.WriteLine("Teams to disband:");
                disbanded.ForEach(x => Console.WriteLine(x.name));        
        }

        public static void Main(string[] args)
        {
            CreateTeams();
            AddMembers();
            PrintTeams();
        }
    }
}
