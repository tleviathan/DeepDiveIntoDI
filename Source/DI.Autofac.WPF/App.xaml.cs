using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DI.WPF.ViewModels;
using Autofac;

namespace DI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IContainer Container;

        protected override void OnStartup(StartupEventArgs e)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>();
            builder.RegisterType<CustomerListViewModel>().As<ICustomerListViewModel>();
            builder.RegisterType<CustomerViewModel>().As<ICustomerViewModel>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();

            Container = builder.Build();

            base.OnStartup(e);
        }
    }
}
