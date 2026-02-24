using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsApp.Classes
{
    internal class Team
    {

    // this class can be a main class for the two different sport types possibly.

    // properties
        
        public int TeamID {  get; set; }
        public String Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

    // constructors

        public Team()
        {
            TeamID = 0;
            Name = "";
            Wins = 0;
            Losses = 0;
        }

        public Team(int teamID, string name, int wins, int losses)
        {
            TeamID = teamID;
            Name = name;
            Wins = wins;
            Losses = losses;
        }


        // methods

        public void displayTeamAndRecord()
        {
            Console.WriteLine($"{Name} {Wins}-{Losses}");
        }
    }
}
