using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DI
{
    public class Commerce2
    {
        public Commerce2(IBillingProcessorLocator billingProcessorLocator, ICustomerProcessor customer, INotificationProcessor notifier, ILoggingProcessor logger)
        {
            _BillingProcessorLocator = billingProcessorLocator;
            _Customer = customer;
            _Notifier = notifier;
            _Logger = logger;
        }

        IBillingProcessorLocator _BillingProcessorLocator;
        ICustomerProcessor _Customer;
        INotificationProcessor _Notifier;
        ILoggingProcessor _Logger;

        public void ProcessOrder(OrderInfo orderInfo)
        {
            IBillingProcessor billingProcessor = _BillingProcessorLocator.GetBillingProcessor();

            billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Price);
            _Logger.Log("Billing processed");
            _Customer.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
            _Logger.Log("Customer updated");
            _Notifier.SendReceipt(orderInfo);
            _Logger.Log("Receipt sent");
        }
    }
}
