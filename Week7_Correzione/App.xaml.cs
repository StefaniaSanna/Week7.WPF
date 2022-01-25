using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Week7_Correzione.ViewModels;
using Week7_Correzione.Views;

namespace Week7_Correzione
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new MainWindow();
            MainWindow.DataContext = new MainWindowViewModel();
            MainWindow.Show();
        }
    }
}
