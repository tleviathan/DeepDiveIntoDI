using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public class CustomerProcessor : ICustomerProcessor
    {
        void ICustomerProcessor.UpdateCustomerOrder(string customer, string product)
        {
            // update customer record with purchase
            Console.WriteLine(string.Format("Customer record for '{0}' updated with purchase of product '{1}'.", customer, product));
        }
    }
}