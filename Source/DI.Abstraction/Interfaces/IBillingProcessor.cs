using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Abstraction
{
    public interface IBillingProcessor
    {
        void ProcessPayment(string customer, string creditCard, double price);
    }
}
