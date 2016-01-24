using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DI.CastleWindsor
{
    public class Commerce
    {
        public Commerce(IBillingProcessor billingProcessor, ICustomer customer, INotifier notifier, ILogger logger)
        {
            _BillingProcessor = billingProcessor;
            _Customer = customer;
            _Notifier = notifier;
            _Logger = logger;
        }

        IBillingProcessor _BillingProcessor;
        ICustomer _Customer;
        INotifier _Notifier;
        ILogger _Logger;

        public void ProcessOrder(OrderInfo orderInfo)
        {
            _BillingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Price);
            _Logger.Log("Billing processed");
            _Customer.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
            _Logger.Log("Customer updated");
            _Notifier.SendReceipt(orderInfo);
            _Logger.Log("Receipt sent");
        }
    }
}
