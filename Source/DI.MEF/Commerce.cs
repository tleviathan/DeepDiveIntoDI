using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Composition;

namespace DI.MEF
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Commerce
    {
        #region Constructor injection

        [ImportingConstructor]
        public Commerce(IBillingProcessor billingProcessor,
            ICustomer customer, INotifier notifier, ILogger logger)
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

        #endregion

        #region Setter injection

        //public Commerce()
        //{
        //    //Program.Container.SatisfyImportsOnce(this);
        //}

        //[Import]
        //IBillingProcessor _BillingProcessor;

        //[Import]
        //ICustomer _Customer;

        //[Import]
        //INotifier _Notifier;

        //[Import]
        //ILogger _Logger;

        #endregion

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
