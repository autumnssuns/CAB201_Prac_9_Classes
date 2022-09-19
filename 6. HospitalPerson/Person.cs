using System;

namespace HospitalPerson
{
    /// <summary>
    /// A class to represent a person.
    /// </summary>
    class Person
    {
        /// <summary>
        /// The name.
        /// </summary>
        protected string Name { get; set; }


        /// <summary>
        /// A class to represent a person. 
        /// </summary>
        /// <param name="name">The name.</param>
        public Person(string name)
        {
            Name = name;
        }

        /// <summary>
        /// A class to display the name.
        /// </summary>
        public virtual void Details()
        {
            Console.WriteLine("The name is: " + Name);
        }
    }
}
