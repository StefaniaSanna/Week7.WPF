using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.BindingDemo.Models;
using WPF.BindingDemo.ViewModels;

namespace WPF.BindingDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //specifico quale implementazione del repo voglio usare eper la gestione dei dati
            //collegamento tra interfaccia del repo e implementazione
            IRepositoryPerson repositoryPerson = new RepositoryPersonMock();
            //view model da utilizzare nell'app
            MainWindowViewModel vm = new MainWindowViewModel(repositoryPerson);
            //finestra da visualizzare in fase di startup
            MainWindow window = new MainWindow(vm);
            window.Show(); //voglio mostrare a video questa finestra
        }
    }
}
