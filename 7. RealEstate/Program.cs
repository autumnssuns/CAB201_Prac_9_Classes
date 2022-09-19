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
            House myHouse = new House(2, "George", 4000, false, false);
            House myOtherHouse = new House(2, "George", 4000, false, false);
            Console.WriteLine(myHouse.Equals(myOtherHouse));
        }

    }
}
