using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Photo originalPhoto = new Photo(100, 150);
            originalPhoto.DisplayPhoto();
            MattedPhoto mattedPhoto = new MattedPhoto(100, 150, "orange");
            mattedPhoto.DisplayPhoto();
            FramedPhoto framedPhoto = new FramedPhoto(100, 150, "silver", "modern");
            framedPhoto.DisplayPhoto();
        }
    }
}
