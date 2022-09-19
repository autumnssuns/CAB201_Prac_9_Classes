using System;

namespace Photo
{
    /// <summary>
    /// A class that tests a Photo.
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// The length of the photo.
        /// </summary>
        public int Legnth { get; }

        /// <summary>
        /// The width of the photo.
        /// </summary>
        public int Width { get; }

        /// <summary>
        ///  A class that tests a Photo.
        /// </summary>
        /// <param name="length">The length of the photo.</param>
        /// <param name="width">The width of the photo.</param>
        public Photo(int length, int width) {
            this.Legnth = length;
            this.Width = width;
        }

        /// <summary>
        /// Displays the photo's fields.
        /// </summary>
        public virtual void DisplayPhoto()
        {
            Console.WriteLine("Photo Length " + Legnth + " Width " + Width);
        }
    }
}
