using System;
namespace myInstagramClass.DTOS
{
    public class CommentsDTO
    {
        public string comment1 { get; set; }

        public CommentsDTO(string newComment1)
        {
            this.comment1 = newComment1;
        }
    }
}
