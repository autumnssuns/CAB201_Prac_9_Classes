using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class SubSubClass : SubClass
    {
        public string Location { get; }

        public SubSubClass(string name, int age, string location) : 
            base(name, age)
        {
            Location = location;
        }
    }
}
