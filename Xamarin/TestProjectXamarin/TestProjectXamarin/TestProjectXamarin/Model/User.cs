using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectXamarin.Model
{
    public class User
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool CheckInformation()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }
    }
}
