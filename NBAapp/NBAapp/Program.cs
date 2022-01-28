using System;
using System.Collections.Generic;
namespace nba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var my_team = new Team("SuperSonics", "Seattle");
            var my_team2 = new Team("Hawks", "Atlanta");
            var my_player = new Player("Trae Young", "Atlanta Hawks");
            var my_player2 = new Player("Detlef Schrempf", "Seattle SuperSonics");
            var my_player3 = new Player("LeBron James", "Los Angeles Lakers");
            var my_team3 = new Team("Lakers", "Los Angeles");
            List<Player> players = new List<Player>();
            players.Add(my_player);
            players.Add(my_player2);
            players.Add(my_player3);
            foreach (var player in players)
            {
                Console.WriteLine(player.getInfo());
            }
            List<Team> teams = new List<Team>();
            teams.Add(my_team);
            teams.Add(my_team2);
            teams.Add(my_team3);
            foreach (var team in teams)
            {
                Console.WriteLine(team.getInfo());
            }
        }


        public class Team
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public Team(string Name, string Location)
            {
                this.Name = Name;
                this.Location = Location;
            }
            public string getInfo()
            {
                return $"{Location} {Name}";
            }

        }
        class Player
        {
            public string Name { get; set; }
            public string Team { get; set; }
            public string getInfo()
            {
                return $"{Name} plays for the {Team}!";
            }
            public Player(string Name, string Team)
            {
                this.Name = Name;
                this.Team = Team;
            }
        }



    }
}