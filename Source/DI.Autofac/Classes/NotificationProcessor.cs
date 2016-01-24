using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public class NotificationProcessor : INotificationProcessor
    {
        void INotificationProcessor.SendReceipt(OrderInfo orderInfo)
        {
            // send email to customer with receipt
            Console.WriteLine(string.Format("Receipt sent to customer '{0}' via email.", orderInfo.CustomerName));
        }
    }
}