using System;
namespace CS132MyGram.Models
{
    public class Image
    {
        public Image()
        {
        }

        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string ImageDescription { get; set; }
        public string ImageAltText { get; set; }
    }
}
