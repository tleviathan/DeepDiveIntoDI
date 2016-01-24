using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Coupled
{
    public class BillingProcessor
    {
        public void ProcessPayment(
            string customer, string creditCard, double price)
        {
            // perform billing gateway processing
            Console.WriteLine(string.Format("Payment processed for customer '{0}' on credit card '{1}' for {2:c}.", customer, creditCard, price));
        }
    }
}
