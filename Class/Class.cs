using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    /// <summary>
    /// A class for Class that contains a name.
    /// </summary>
    class Class
    {
        /// <summary>
        /// The name of the class
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Creates a Class with a Name
        /// </summary>
        /// <param name="name">The Name for the class</param>
        public Class(string name)
        {
            Name = name;
        }
    }
}
