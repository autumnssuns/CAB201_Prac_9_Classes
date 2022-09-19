using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Worker:Person
    {
        /// <summary>
        /// The salary of the worker
        /// </summary>
        protected double Salary { get; }

        /// <summary>
        /// The lunch of the worker
        /// </summary>
        private string lunch;

        /// <summary>
        /// A class to represent a person. 
        /// </summary>
        /// <param name="name">The name.</param>
        public Worker(string name, double salary, string lunch) : base(name)
        {
            Salary = salary;
            this.lunch = lunch;
        }

        /// <summary>
        /// Retrieve all the details of the worker
        /// </summary>
        /// <returns>The details of the worker</returns>
        public string IntroduceWorker()
        {
            return $"My salary is {Salary} and I am having {lunch} for lunch.";
        }
    }
}
