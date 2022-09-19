namespace RealEstate
{
    /// <summary>
    /// A class that represents real estate.
    /// </summary>
    class RealEstate
    {

        /// <summary>
        /// The street number.
        /// </summary>
        protected int StreetNumber;

        /// <summary>
        /// The street.
        /// </summary>
        protected string Street;

        /// <summary>
        /// The postcode.
        /// </summary>
        protected int PostCode;

        /// <summary>
        /// A class that represents real estate. 
        /// </summary>
        /// <param name="streetNumber">The street number.</param>
        /// <param name="street">The street.</param>
        /// <param name="postCode">The postcode.</param>
        public RealEstate(int streetNumber, string street, int postCode)
        {
            StreetNumber = streetNumber;
            Street = street;
            PostCode = postCode;
        }
    }
}
