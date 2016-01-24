using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace DI.WPF.ViewModels
{
    public interface IMainWindowViewModel : IViewModel
    {
        ICommand ToggleViewCommand { get; }
        IViewModel CurrentViewModel { get; set; }
        void OnToggleViewCommand();
    }

    public class MainWindowViewModel : ViewModelBase, IViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(ICustomerListViewModel customerListViewModel,
                                   ICustomerViewModel customerViewModel)
        {
            _CustomerListViewModel = customerListViewModel;
            _CustomerViewModel = customerViewModel;
            
            CurrentViewModel = _CustomerListViewModel;
            ToggleViewCommand = new ToggleViewCommand(this);
        }

        ICustomerListViewModel _CustomerListViewModel;
        ICustomerViewModel _CustomerViewModel;

        IViewModel _CurrentViewModel;
        
        public ICommand ToggleViewCommand { get; private set; }

        public IViewModel CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
            	_CurrentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        public void OnToggleViewCommand()
        {
            if (_CurrentViewModel.Equals(_CustomerListViewModel))
                CurrentViewModel = _CustomerViewModel;
            else
                CurrentViewModel = _CustomerListViewModel;
        }
    }
}
