using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class Unit:RealEstate
    {
        private int unitNumber;

        public Unit(int unitNumber, int streetNumber, string street, int postCode):base(streetNumber, street, postCode)
        {
            this.unitNumber = unitNumber;
        }

        public override string ToString()
        {
            return $"{unitNumber}\t{StreetNumber}\t{Street}\t{PostCode}";
        }
    }
}
