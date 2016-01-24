using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows.Input;

namespace DI.WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MainWindowViewModel : ViewModelBase, IPartImportsSatisfiedNotification
    {
        public MainWindowViewModel()
        {
            ToggleViewCommand = new ToggleViewCommand(this);
        }

        [Import]
        CustomerListViewModel _CustomerListViewModel;

        [Import]
        CustomerViewModel _CustomerViewModel;

        ViewModelBase _CurrentViewModel;

        public ICommand ToggleViewCommand { get; private set; }

        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
            	_CurrentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        internal void OnToggleViewCommand()
        {
            if (_CurrentViewModel.Equals(_CustomerListViewModel))
                CurrentViewModel = _CustomerViewModel;
            else
                CurrentViewModel = _CustomerListViewModel;
        }

        public void OnImportsSatisfied()
        {
            CurrentViewModel = _CustomerListViewModel;
        }
    }
}
