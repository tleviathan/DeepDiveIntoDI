using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Coupled
{
    public class Commerce
    {
        public Commerce()
        {
            _BillingProcessor = new BillingProcessor();
            _Customer = new Customer();
            _Notifier = new Notifier();
            _Logger = new Logger();
        }

        BillingProcessor _BillingProcessor;
        Customer _Customer;
        Notifier _Notifier;
        Logger _Logger;

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
