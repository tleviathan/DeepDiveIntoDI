using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DI
{
    public class Commerce4
    {
        public Commerce4(IProcessorLocator2 processorLocator, ISingleTester singleTester)
        {
            _ProcessorLocator = processorLocator;
            _SingleTester = singleTester;
        }

        IProcessorLocator2 _ProcessorLocator;
        ISingleTester _SingleTester;

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

            _SingleTester.DisplayCounter();

            _ProcessorLocator.ReleaseScope();
        }
    }

    public interface ISingleTester
    {
        void DisplayCounter();
    }

    public class SingleTester : ISingleTester
    {
        int _Counter = 0;

        public void DisplayCounter()
        {
            _Counter++;

            Console.WriteLine("Counter inside class 'SingleTester' is now: {0}", _Counter);
        }
    }
}
