using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuit
{
    class SpecialCookOrder : BiscuitOrder
    {
        private string reason;

        public SpecialCookOrder(int orderNumber, string customerName, string cookieType, int numberOfDozens, string reason) : base(orderNumber, customerName, cookieType, numberOfDozens)
        {
            this.reason = reason;
        }

        public override double TotalCost
        {
            get
            {
                if (base.TotalCost < 50)
                {
                    return base.TotalCost + 15;
                }
                else
                {
                    return base.TotalCost + 25;
                }
            }
        }

        public override void DisplayOrder()
        {
            Console.WriteLine($"{orderNumber}\t{customerName}\t{cookieType}\t{numberOfDozens}\t{reason}\t{TotalCost}");
        }
    }
}
