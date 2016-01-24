using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Unity
{
    public interface IBillingProcessor
    {
        void ProcessPayment(string customer, string creditCard, double price);
    }
}