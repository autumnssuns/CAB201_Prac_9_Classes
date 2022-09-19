using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class MattedPhoto : Photo
    {
        public string Colour { get; }

        public MattedPhoto(int length, int width, string colour) : base(length, width)
        {
            Colour = colour;
        }
        public override void DisplayPhoto()
        {
            base.DisplayPhoto();
            Console.WriteLine($"Colour {Colour}");
        }
    }
}
