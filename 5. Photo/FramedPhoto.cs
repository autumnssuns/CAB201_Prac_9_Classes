using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class FramedPhoto:Photo
    {
        private string material;
        private string style;
        public FramedPhoto(int length, int width, string material, string style): base(length, width)
        {
            this.material = material;
            this.style = style;
        }

        public override void DisplayPhoto()
        {
            Console.WriteLine("This is a framed photo");
            base.DisplayPhoto();
            Console.WriteLine($"The frame is made of {material} and has a {style} style.");
        }
    }
}
