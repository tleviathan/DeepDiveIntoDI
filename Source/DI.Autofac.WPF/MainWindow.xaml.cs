using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DI.WPF.ViewModels;
using Autofac;

namespace DI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IMainWindowViewModel viewModel 
                = App.Container.Resolve<IMainWindowViewModel>();
            
            this.DataContext = viewModel;
        }
    }
}
