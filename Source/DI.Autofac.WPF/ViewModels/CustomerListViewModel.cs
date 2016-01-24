using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.WPF.ViewModels
{
    public interface ICustomerListViewModel : IViewModel
    {
        List<Customer> CustomersModel { get; }
    }

    public class CustomerListViewModel : ViewModelBase, ICustomerListViewModel
    {
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            _CustomersModel = customerRepository.GetAll();
        }

        List<Customer> _CustomersModel;

        public List<Customer> CustomersModel
        {
            get { return _CustomersModel; }
        }
    }
}
