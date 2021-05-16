using System;
namespace myInstagramClass.Models
{
    public class Users
    {
        
            public string first { get; set; }
            public string last { get; set; }

            public Users(string firstName, string lastName)
            {
                this.first = firstName;
                this.last = lastName;
            }
        
    }
}
