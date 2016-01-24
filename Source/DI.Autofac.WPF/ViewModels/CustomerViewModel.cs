using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.WPF.ViewModels
{
    public interface ICustomerViewModel : IViewModel
    {
        Customer CustomerModel { get; }
    }
    
    public class CustomerViewModel : ViewModelBase, ICustomerViewModel
    {
        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            _CustomerModel = customerRepository.GetById(1);
        }

        Customer _CustomerModel;

        public Customer CustomerModel
        {
            get { return _CustomerModel; }
        }
    }
}
