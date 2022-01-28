using System;
using System.Collections.Generic;

namespace nba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var my_team = new Team("SuperSonics", "Seattle",1);
            var my_team2 = new Team("Hawks", "Atlanta",1);
            var my_player = new Player("Trae Young", "Atlanta Hawks");
            var my_player2 = new Player("Detlef Schrempf", "Seattle SuperSonics");
            var my_player3 = new Player("LeBron James", "Los Angeles Lakers",32000,1003);
            var my_team3 = new Team("Lakers", "Los Angeles",17,1000,600);
            List<Player> players = new List<Player>();
            players.Add(my_player);
            players.Add(my_player2);
            players.Add(my_player3);
            foreach (var player in players)
            {
                Console.WriteLine(player.getInfo());
                Console.WriteLine(player.PointsPerGame());
            }
            List<Team> teams = new List<Team>();
            teams.Add(my_team);
            teams.Add(my_team2);
            teams.Add(my_team3);
            foreach (var team in teams)
            {
                Console.WriteLine(team.getInfo());
                Console.WriteLine(team.WinPercentage());
            }
        }


        public class Team
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public int RingsWon { get; set; }
            public int GamesPlayed  { get; set; }
            public int GamesWon { get; set; }
            public Team(string Name, string Location, int Rings)
            {
                this.Name = Name;
                this.Location = Location;
                this.RingsWon = Rings;
                this.GamesPlayed= 1;
                this.GamesWon = 1;
            }
            public Team(string Name, string Location, int Rings, int GamesPlayed, int GamesWon)
            {
                this.Name = Name;
                this.Location = Location;
                this.RingsWon = Rings;
                this.GamesPlayed = GamesPlayed;
                this.GamesWon = GamesWon;
            }
            public string getInfo()
            {
                return $"The {Location} {Name} have won {RingsWon} Championship(s)!";
            }
            public string WinPercentage()
            {
                decimal winrate;
                winrate= (GamesPlayed / GamesWon);
                decimal myRoundedWR = Math.Round(winrate);
                string my_wr = winrate.ToString();
                return $"The {Location} {Name} have won {my_wr} of their {GamesPlayed} games played";


            } 


        }
        class Player
        {
            public string Name { get; set; }
            public string Team { get; set; }
            public int TotalPoints { get; set; }
            public int TotalGamesPlayed     { get; set; }
            public string getInfo()
            {
                return $"{Name} plays for the {Team}!";
            }
            public string PointsPerGame()
            {
                int average;
                average = TotalPoints / TotalGamesPlayed ;
                string my_average =average.ToString();
                return $"{Name} averaged {average} point(s) per game.";                    


            }
            public Player(string Name, string Team)
            {
                this.Name = Name;
                this.Team = Team;
                this.TotalGamesPlayed = 1;
                this.TotalPoints = 0;
            }
            public Player(string Name,string Team,int TotalPoints, int TotalGamesPlayed)
            {
                this.Name = Name;
                this.Team=Team;
                this.TotalPoints = TotalPoints;
                this.TotalGamesPlayed=TotalGamesPlayed;

            }
        }



    }
}