using System;
namespace myInstagramClass.Models
{
    public class Posts
    {
        public string post1 { get; set; }
        public string post2 { get; set; }

        public Posts(string newPost1, string newPost2)
        {
            this.post1 = newPost1;
            this.post2 = newPost2;
        }
    }
}
