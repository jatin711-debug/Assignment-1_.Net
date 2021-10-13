using System;
using System.Collections.Generic;


namespace Assignment_1
{
    abstract class Player

    {

        public string PlayerName { get; set; }
        public int PlayerId { get; set; }
        public string TeamName { get; set; }
        public int GamesPlayed { get; set; }


        protected Player(string name,int id,string team,int games)
        {
            this.PlayerId = id;
            this.PlayerName = name;
            this.TeamName = team;
            this.GamesPlayed = games;
        }
        public abstract override string ToString();
        public abstract int GetPoints();
    }
}
