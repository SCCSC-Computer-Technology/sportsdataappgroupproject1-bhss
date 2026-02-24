using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace sportsApp.Classes
{
    internal class Player
    {

    // properties

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Position { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int SportId { get; set; }


    // constructors

        // default
        public Player()
        {
            FirstName = "";
            LastName = "";
            Position = "";
            Height = 0;
            Weight = 0;
            SportId = 0;
        }

        // parameterized
        public Player(String firstName, String lastName,  String position, int height, int weight, int sportId)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Height = height;
            Weight = weight;
            SportId = sportId;
        }

    // methods

        public void displayPlayer()
        {
            Console.WriteLine($"{FirstName} {LastName} {Position}");
        }
    }
}
