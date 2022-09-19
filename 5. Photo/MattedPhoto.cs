using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class MattedPhoto : Photo
    {
        private string colour; 

        /// <summary>
        /// Creates a Matted Photo with a colour
        /// </summary>
        /// <param name="length">The length of the photo</param>
        /// <param name="width">The width of the photo</param>
        /// <param name="colour">The colour of the photo</param>
        public MattedPhoto(int length, int width, string colour): base(length, width)
        {
            this.colour = colour;
        }

        public override void DisplayPhoto()
        {
            Console.WriteLine($"Photo Length: {this.Legnth} Width: {this.Width}");
            Console.WriteLine($"Colour: {colour}");
        }
    }
}
