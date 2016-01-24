using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;

namespace DI
{
    public class Commerce8
    {
        public Commerce8()
        {
            //Program.Container.InjectProperties(this);
        }

        public IProcessorLocator _ProcessorLocator { get; set; }
        public IEnumerable<IPostOrderPlugin> _Plugins { get; set; }

        public void ProcessOrder(OrderInfo orderInfo)
        {
            IBillingProcessor billingProcessor = _ProcessorLocator.GetProcessor<IBillingProcessor>();
            ICustomerProcessor customerProcessor = _ProcessorLocator.GetProcessor<ICustomerProcessor>();
            INotificationProcessor notificationProcessor = _ProcessorLocator.GetProcessor<INotificationProcessor>();
            ILoggingProcessor loggingProcessor = _ProcessorLocator.GetProcessor<ILoggingProcessor>();

            billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Price);
            loggingProcessor.Log("Billing processed");
            customerProcessor.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
            loggingProcessor.Log("Customer updated");
            notificationProcessor.SendReceipt(orderInfo);
            loggingProcessor.Log("Receipt sent");

            foreach (IPostOrderPlugin plugin in _Plugins)
            {
                plugin.DoSomething();
            }
        }
    }
}
