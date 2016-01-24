using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;

namespace DI.Unity
{
    public class Program
    {
        public static UnityContainer Container;

        static void Main(string[] args)
        {
            Container = new UnityContainer();

            Container.RegisterType<IBillingProcessor, BillingProcessor>();
            Container.RegisterType<ICustomer, Customer>();
            Container.RegisterType<INotifier, Notifier>();
            Container.RegisterType<ILogger, Logger>();

            #region factory
            Container.RegisterType<IBillingProcessorFactory, UnityBillingProcessorFactory>();
            #endregion

            Console.WriteLine("Unity DI Container Example");
            Console.WriteLine();

            OrderInfo orderInfo = new OrderInfo()
            {
                CustomerName = "Miguel Castro",
                Email = "miguel@dotnetdude.com",
                Product = "Laptop",
                Price = 1200,
                CreditCard = "1234567890"
            };

            Console.WriteLine("Production:");
            Console.WriteLine();

            Commerce commerce = Container.Resolve<Commerce>();

            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
