using System;


namespace Assignment_1
{
    class BaseballPlayer:Player
    {
        public int Runs { get; set; }
        public int HomeRuns { get; set; }

        public BaseballPlayer(string name, int id, string team, int games, int runs, int home) : base(name, id, team, games)
        {
            this.PlayerName = name;
            this.TeamName = team;
            this.PlayerId = id;
            this.GamesPlayed = games;
            this.Runs = runs;
            this.HomeRuns = home;
        }

        override
        public String ToString()
        {
            return $" {PlayerId} \t {PlayerName} {TeamName} {GamesPlayed} {Runs} {HomeRuns} {GetPoints()} ";
        }

        public override int GetPoints()
        {
            return (int)((Runs - HomeRuns) + (2 * HomeRuns));
        }
    }
}
