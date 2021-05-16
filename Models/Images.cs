using System;
namespace myInstagramClass.Models
{
    public class Images
    {
        public string image1 { get; set; }
        public string image2 { get; set; }
        

        public Images(string newImage1, string newImage2)
        {
            this.image1 = newImage1;
            this.image2 = newImage2;
        }
    }
}
