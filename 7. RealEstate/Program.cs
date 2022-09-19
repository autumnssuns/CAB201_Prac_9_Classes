using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("StreetNumber\tStreet\tPostCode\tHasPool\tHasTennisCourt");
            Console.WriteLine("--------------------------------");
            House newHouse = new House(2, "George", 4000, false, false);
            Console.WriteLine(newHouse);
            Unit newUnit = new Unit(518, 2, "George", 4000);
            Console.WriteLine(newUnit);
        }
    }
}