using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS132MyGram.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS132MyGram.Controllers
{
    public class ImagesController : Controller
    {
        // GET: /<controller>/
        public IActionResult GetAllImages()
        {
            IList<Image> imageList = new List<Image>();

            Image image1 = new Image();
            image1.ImageId = 1;
            image1.ImageName = "Image 1";
            image1.ImageDescription = "Description 1";
            image1.ImageAltText = "Alt text 1";
            image1.ImagePath = "Path 1";
            imageList.Add(image1);

            Image image2 = new Image();
            image2.ImageId = 2;
            image2.ImageName = "Image 2";
            image2.ImageDescription = "Description 2";
            image2.ImageAltText = "Alt text 2";
            image2.ImagePath = "Path 2";
            imageList.Add(image2);

            Image image3 = new Image();
            image3.ImageId = 3;
            image3.ImageName = "Image 3";
            image3.ImageDescription = "Description 3";
            image3.ImageAltText = "Alt text 3";
            image3.ImagePath = "Path 3";
            imageList.Add(image3);

            Image image4 = new Image();
            image4.ImageId = 4;
            image4.ImageName = "Image 4";
            image4.ImageDescription = "Description 4";
            image4.ImageAltText = "Alt text 4";
            image4.ImagePath = "Path 4";
            imageList.Add(image4);

            Image image5 = new Image();
            image5.ImageId = 5;
            image5.ImageName = "Image 5";
            image5.ImageDescription = "Description 5";
            image5.ImageAltText = "Alt text 5";
            image5.ImagePath = "Path 5";
            imageList.Add(image5);

            Image image6 = new Image();
            image6.ImageId = 6;
            image6.ImageName = "Image 6";
            image6.ImageDescription = "Description 6";
            image6.ImageAltText = "Alt text 6";
            image6.ImagePath = "Path 6";
            imageList.Add(image6);

            Image image7 = new Image();
            image7.ImageId = 7;
            image7.ImageName = "Image 7";
            image7.ImageDescription = "Description 7";
            image7.ImageAltText = "Alt text 7";
            image7.ImagePath = "Path 7";
            imageList.Add(image7);

            Image image8 = new Image();
            image8.ImageId = 8;
            image8.ImageName = "Image 8";
            image8.ImageDescription = "Description 8";
            image8.ImageAltText = "Alt text 8";
            image8.ImagePath = "Path 8";
            imageList.Add(image8);

            Image image9 = new Image();
            image9.ImageId = 9;
            image9.ImageName = "Image 9";
            image9.ImageDescription = "Description 9";
            image9.ImageAltText = "Alt text 9";
            image9.ImagePath = "Path 9";
            imageList.Add(image9);

            Image image10 = new Image();
            image10.ImageId = 10;
            image10.ImageName = "Image 10";
            image10.ImageDescription = "Description 10";
            image10.ImageAltText = "Alt text 10";
            image10.ImagePath = "Path 10";
            imageList.Add(image10);

            Image image11 = new Image();
            image11.ImageId = 11;
            image11.ImageName = "Image 11";
            image11.ImageDescription = "Description 11";
            image11.ImageAltText = "Alt text 11";
            image11.ImagePath = "Path 11";
            imageList.Add(image11);

            Image image12 = new Image();
            image12.ImageId = 12;
            image12.ImageName = "Image 12";
            image12.ImageDescription = "Description 12";
            image12.ImageAltText = "Alt text 12";
            image12.ImagePath = "Path 12";
            imageList.Add(image12);

            Image image13 = new Image();
            image13.ImageId = 13;
            image13.ImageName = "Image 13";
            image13.ImageDescription = "Description 13";
            image13.ImageAltText = "Alt text 13";
            image13.ImagePath = "Path 13";
            imageList.Add(image13);

            Image image14 = new Image();
            image14.ImageId = 14;
            image14.ImageName = "Image 14";
            image14.ImageDescription = "Description 14";
            image14.ImageAltText = "Alt text 14";
            image14.ImagePath = "Path 14";
            imageList.Add(image14);

            Image image15 = new Image();
            image15.ImageId = 15;
            image15.ImageName = "Image 15";
            image15.ImageDescription = "Description 15";
            image15.ImageAltText = "Alt text 15";
            image15.ImagePath = "Path 15";
            imageList.Add(image15);

            Image image16 = new Image();
            image16.ImageId = 16;
            image16.ImageName = "Image 16";
            image16.ImageDescription = "Description 16";
            image16.ImageAltText = "Alt text 16";
            image16.ImagePath = "Path 16";
            imageList.Add(image16);

            Image image17 = new Image();
            image17.ImageId = 17;
            image17.ImageName = "Image 17";
            image17.ImageDescription = "Description 17";
            image17.ImageAltText = "Alt text 17";
            image17.ImagePath = "Path 17";
            imageList.Add(image17);

            Image image18 = new Image();
            image18.ImageId = 18;
            image18.ImageName = "Image 18";
            image18.ImageDescription = "Description 18";
            image18.ImageAltText = "Alt text 18";
            image18.ImagePath = "Path 18";
            imageList.Add(image18);

            Image image19 = new Image();
            image19.ImageId = 19;
            image19.ImageName = "Image 19";
            image19.ImageDescription = "Description 19";
            image19.ImageAltText = "Alt text 19";
            image19.ImagePath = "Path 19";
            imageList.Add(image19);

            Image image20 = new Image();
            image20.ImageId = 20;
            image20.ImageName = "Image 20";
            image20.ImageDescription = "Description 20";
            image20.ImageAltText = "Alt text 20";
            image20.ImagePath = "Path 20";
            imageList.Add(image20);

            return View(imageList);
        }
    }
}
