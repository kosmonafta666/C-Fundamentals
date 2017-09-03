namespace Teamwork_projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TeamworkProjects
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Team> teamList = new List<Team>();
           
            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split('-');

                var name = input[1];
                var creator = input[0];

                var teamExist = teamList.Any(x => x.Name == name);
                var creatorExist = teamList.Any(x => x.Creator == creator);

                if (teamExist)
                {
                    Console.WriteLine("Team {0} was already created!", name);
                }
                else if (creatorExist)
                {
                    Console.WriteLine("{0} cannot create another team!", creator);
                }
                else
                {
                    Team currentTeam = CreateTeam(name, creator);
                    teamList.Add(currentTeam);
                    Console.WriteLine("Team {0} has been created by {1}!", name, creator);
                }
                
            }

            var line = Console.ReadLine();

            while (line != "end of assignment")
            {
                var userName = line.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)[0];
                var teamName = line.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)[1];
                
                var teamExist = teamList.Any(x => x.Name == teamName);
                var creatorExist = teamList.Any(x => x.Creator == userName);
                var memberExist = teamList.Any(x => x.Members.Contains(userName));

                if (!teamExist)
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                }
                else if (creatorExist || memberExist)
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", userName, teamName);
                }
                else
                {
                    int teamIndex = GetTeamIndex(teamList, teamName);
                    teamList[teamIndex].Members.Add(userName);
                } 
   
                line = Console.ReadLine();
            }

            var sortedList = teamList.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (var team in sortedList)
            {
                Console.WriteLine("{0} ", team.Name);
                Console.WriteLine("- {0}", team.Creator);

                List<string> membersList = team.Members.OrderBy(x => x).ToList();

                foreach (var user in membersList)
                {
                    Console.WriteLine("-- {0}", user);
                } 
            }

            Console.WriteLine("Teams to disband:");
            var disbandList = teamList.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).ToList();

            foreach (var team in disbandList)
            {
                Console.WriteLine(team.Name);
            }
        }


        public static Team CreateTeam(string name, string creator)
        {
            Team team = new Team();

            team.Name = name;
            team.Creator = creator;
            team.Members = new List<string>();
            return team;
        }

        public static int GetTeamIndex(List<Team> teamList, string teamName) 
        {
            int teamIndex = 0;

            for (int i = 0; i < teamList.Count; i++)
            {
                if (teamList[i].Name.Equals(teamName))
                {
                    teamIndex = i;
                    break;
                }
            }

            return teamIndex;
        }
    }
}
