using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DI.WPF.ViewModels;

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

            MainWindowViewModel viewModel =
                App.Container.GetExportedValue<MainWindowViewModel>();
            this.DataContext = viewModel;
        }
    }
}
