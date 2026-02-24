using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsApp
{
    internal class User
    {

    // properties
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    // constructors
        
        // default
        public User()
        {
            Email = "";
            Password = "";
            FirstName = "";
            LastName = "";
        }

        // paratemerized
        public User(string email, string password, string firstName, string lastName)
        {
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

    // methods

        public void displayUser()
        {
            Console.WriteLine($"{FirstName} {LastName} {Email}");
        }
    }
}
