using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public interface IBillingProcessor
    {
        void ProcessPayment(string customer, string creditCard, double price);
    }
}