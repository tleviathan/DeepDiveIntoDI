using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Autofac;
using Autofac.Integration.Wcf;

namespace DI.WCF
{
    class Program
    {
        public static IContainer Container;

        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<DependencyComponent>().As<IDependency>();
            builder.RegisterType<SampleService>();

            Container = builder.Build();

            ServiceHost host = new ServiceHost(typeof(SampleService));

            host.AddDependencyInjectionBehavior(typeof(SampleService), Container);

            host.Open();

            Console.WriteLine("Service is running. Press 'Enter' to call operation.");
            Console.ReadLine();
            Console.WriteLine();

            ChannelFactory<ISampleService> channelFactory = new ChannelFactory<ISampleService>("");
            ISampleService proxy = channelFactory.CreateChannel();

            proxy.PerformOperation();

            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to end.");
            Console.ReadLine();
        }
    }
}
