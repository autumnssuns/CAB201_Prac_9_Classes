using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class CEOWorker : Worker
    {
        public CEOWorker(string name, double salary, string lunch): 
            base(name, salary, lunch)
        {

        }

        /// <summary>
        /// Retreives all the details about a CEOWorker
        /// </summary>
        /// <returns>All the details about a CEOWorker</returns>
        public string IntroduceCEOWorker()
        {
            return $"I am a CEO and my salary is {Salary}";
        }
    }
}
