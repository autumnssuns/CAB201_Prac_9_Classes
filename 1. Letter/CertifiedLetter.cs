using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter
{
    class CertifiedLetter : Letter
    {
        /// <summary>
        /// The tracking number of the letter.
        /// </summary>
        public int TrackingNumber { get; }

        /// <summary>
        /// Create a new certified letter with a recipient name, sent date and tracking number.
        /// </summary>
        /// <param name="name">The name of the recipient</param>
        /// <param name="date">The date the letter was sent</param>
        /// <param name="trackingNumber">The letter's tracking number</param>
        public CertifiedLetter(string name, MyDate date, int trackingNumber) : base(name, date)
        {
            TrackingNumber = trackingNumber;
        }
    }
}
