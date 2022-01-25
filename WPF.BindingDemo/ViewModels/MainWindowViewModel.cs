using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF.BindingDemo.Models;

namespace WPF.BindingDemo.ViewModels
{
    
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private IRepositoryPerson _repoPerson;

        //Lista di persone da collegarein binding con la view, il view model è l'intermediario tra view e model
        public IList<Person> People => _repoPerson.GetAll();

        //Proprietà che conterrà la persona selezionata
        private Person _selectedPerson = null;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if(_selectedPerson == value)
                {
                    return; //se la persona selezionata è già selezionata return
                }
                //se invece sto selezionando una nuova persona devo scatenare l'evento di binding
                _selectedPerson = value;
                //scateno evento di binding
                NotifyPropertyChanged();
                //richiamiamo l'operazione da eseguire quando la proprietà viene modificata
                SalutaCommand.RaiseCanExecuteChanged();
            }

        }
        private string txtSaluto = null;

        public event PropertyChangedEventHandler? PropertyChanged; //importato dalla nuova interfaccia

        public string TextSaluto
        {
            get { return txtSaluto; }
            set
            {
                txtSaluto = value;
                //richiama l'esecuzione dell'evento
                NotifyPropertyChanged();
            }
        }

        public RelayCommand SalutaCommand { get; private set; } //voglio che il comando non sia modificato da fuori


        public MainWindowViewModel(IRepositoryPerson repo)
        {
            _repoPerson = repo;
            SalutaCommand = new RelayCommand(salutaExecute, salutaCanExecute);

        }

        //public void Saluta()
        //{
        //    if(SelectedPerson != null)
        //    {
        //        TextSaluto = $"Hi, {SelectedPerson}";
        //    }

        //}

        private bool salutaCanExecute(object param)
        {
            return SelectedPerson != null;
        }

        private void salutaExecute(object? param)
        {
            if (SelectedPerson != null)
            {
                TextSaluto = $"Hi, {SelectedPerson}";
            }
        }

        //mettiamo un metodo per gestire il cambiamento della propietà
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
