using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BasketballPlayer : Player
    {
        public int FieldGoals { get; set; }
        public int ThreePointer { get; set; }

        public BasketballPlayer(string name, int id, string team, int games, int field, int threePointer) : base(name, id, team, games)
        {
            this.PlayerName = name;
            this.TeamName = team;
            this.PlayerId = id;
            this.GamesPlayed = games;
            this.FieldGoals = field;
            this.ThreePointer = threePointer;
        }

        override
        public String ToString()
        {
            return $" {PlayerId} \t {PlayerName} {TeamName} {GamesPlayed} {FieldGoals} {ThreePointer} {GetPoints()} ";
        }

        public override int GetPoints()
        {
            return (int)((FieldGoals - ThreePointer) + (2* ThreePointer));
        }
    }
}
