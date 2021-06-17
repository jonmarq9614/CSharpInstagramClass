using System;
namespace myInstagramClass.Models
{
    public class Comments
    {
        public string comment1 { get; set; }

        public Comments(string newComment1)
        {
            this.comment1 = newComment1;
        }

        public Comments()
        {
        }

        public static implicit operator string(Comments v)
        {
            throw new NotImplementedException();
        }
    }
}
