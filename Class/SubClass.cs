using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class SubClass : Class
    {
        public int Age { get; }

        public SubClass(string name, int age) : base(name)
        {
            Age = age;
        }
    }
}
