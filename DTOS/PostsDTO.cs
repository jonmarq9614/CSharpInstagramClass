using System;
namespace myInstagramClass.DTOS
{
    public class PostsDTO
    {
        public string post1 { get; set; }
        public string post2 { get; set; }

        public PostsDTO(string newPost1, string newPost2)
        {
            this.post1 = newPost1;
            this.post2 = newPost2;
        }
    }
}
