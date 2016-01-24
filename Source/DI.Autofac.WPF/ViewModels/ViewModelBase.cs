using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DI.WPF.ViewModels
{
    public interface IViewModel : INotifyPropertyChanged
    {
        
    }

    public abstract class ViewModelBase : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
