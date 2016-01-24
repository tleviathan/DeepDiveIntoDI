using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Composition;

namespace DI.WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerListViewModel : ViewModelBase
    {
        [ImportingConstructor]
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
