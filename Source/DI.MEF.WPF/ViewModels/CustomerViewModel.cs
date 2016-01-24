using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace DI.WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerViewModel : ViewModelBase
    {
        [ImportingConstructor]
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