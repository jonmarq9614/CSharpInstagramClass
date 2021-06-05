using System;
namespace myInstagramClass.Models
{
    public class Users
    {
        
            public string first { get; set; }
            public string last { get; set; }
            public string email { get; set; }
            public string user { get; set; }
            public string password { get; set; }

            public Users(string firstName, string lastName, string Email, string userName, string Password)
            {
                this.first = firstName;
                this.last = lastName;
                this.email = Email;
                this.user = userName;
                this.password = Password;
            }

        public Users()
        {
        }
    }
}
