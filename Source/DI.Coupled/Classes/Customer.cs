using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Coupled
{
    public class Customer
    {
        public void UpdateCustomerOrder(string customer, string product)
        {
            // update customer record with purchase
            Console.WriteLine(string.Format("Customer record for '{0}' updated with purchase of product '{1}'.", customer, product));
        }
    }
}
