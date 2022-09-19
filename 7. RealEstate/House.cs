using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class House : RealEstate
    {
        private bool hasPool;
        private bool hasTennisCourt;

        public House(int streetNumber, string street, int postCode, bool hasPool, bool hasTennisCourt):base(streetNumber, street, postCode)
        {
            this.hasPool = hasPool;
            this.hasTennisCourt = hasTennisCourt;
        }

        public override string ToString()
        {
            return $"{StreetNumber}\t{Street}\t{PostCode}\t{hasPool}\t{hasTennisCourt}";
        }

        public override bool Equals(object otherObject)
        {
            House otherHouse = (House)otherObject;
            return otherHouse.StreetNumber == StreetNumber &&
                otherHouse.Street == Street &&
                otherHouse.PostCode == PostCode &&
                otherHouse.hasPool == hasPool &&
                otherHouse.hasTennisCourt == hasTennisCourt;
        }
    }
}
