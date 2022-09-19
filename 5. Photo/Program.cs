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
            Photo normalPhoto = new Photo(200, 300);
            normalPhoto.DisplayPhoto();
            MattedPhoto mattedPhoto = new MattedPhoto(200, 300, "Blue");
            mattedPhoto.DisplayPhoto();
        }
    }
}
