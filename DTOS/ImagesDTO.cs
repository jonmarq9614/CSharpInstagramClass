using System;
namespace myInstagramClass.DTOS
{
    public class ImagesDTO
    {
        public string image1 { get; set; }
        public string image2 { get; set; }


        public ImagesDTO(string newImage1, string newImage2)
        {
            this.image1 = newImage1;
            this.image2 = newImage2;
        }
    }
}
