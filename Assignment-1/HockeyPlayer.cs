using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class HockeyPlayer : Player
    {
        public int Assist { get; set; }
        public int Goals { get; set; }

        public HockeyPlayer(string name,int id,string team,int games,int assist,int goals):base(name,id,team,games)
        {
            this.PlayerName = name;
            this.TeamName = team;
            this.PlayerId = id;
            this.GamesPlayed = games;
            this.Assist = assist;
            this.Goals = goals;
        }

        override
        public String ToString()
        {
            return $" {PlayerId} \t {PlayerName} {TeamName} {GamesPlayed} {Assist} {Goals} {GetPoints()} ";
        }

        public override int GetPoints()
        {
            return (int)(Assist + (2 * Goals));
        }
    }
}
