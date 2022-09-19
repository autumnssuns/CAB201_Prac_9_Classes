using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuit
{
    class BiscuitOrder
    {
        protected int orderNumber;
        protected string customerName;
        protected string cookieType;
        protected int numberOfDozens;
        protected const double priceFirstTwo = 15,
            priceRest = 13;
        public virtual double TotalCost
        {
            get
            {
                if (numberOfDozens > 2)
                {
                    return priceFirstTwo * 2 + priceRest * (numberOfDozens - 2);
                } else
                {
                    return numberOfDozens * priceFirstTwo;
                }
            }
        }
        
        public BiscuitOrder(int orderNumber, string customerName, string cookieType, int numberOfDozens)
        {
            this.orderNumber = orderNumber;
            this.customerName = customerName;
            this.cookieType = cookieType;
            this.numberOfDozens = numberOfDozens;
        }

        public virtual void DisplayOrder()
        {
            Console.WriteLine($"{orderNumber}\t{customerName}\t{cookieType}\t{numberOfDozens}\t{TotalCost}");
        }
    }
}
