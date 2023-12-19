using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDA.Classes
{
    public class User
    {
        // Properties
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string UserRole { get; set; }

        // Constructor
        public User( int userID,string userName,string Password, string firstName, string lastName, string email, string gender, string contact, string userRole)
        {
            this.UserID = userID;
            UserName = userName;
            this.Password = Password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            Contact = contact;
            UserRole = userRole;
        }
        public User()
        {
            UserID = 0;
            UserName ="";
            this.Password = "";
            FirstName = "";
            LastName = "";
            Email = "";
            Gender = "";
            Contact = "";
            UserRole = "";
        }


        // You can also add methods or additional functionality as needed
    }

}
