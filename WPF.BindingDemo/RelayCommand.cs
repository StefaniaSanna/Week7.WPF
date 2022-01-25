using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.BindingDemo
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<object?> executeMethod; //rappresenta il puntatore alla funzion execute, non restitusce nulla

        private Predicate<object?> canExecuteMethod; //sono metodo che usano dei particolari delegati d ic#
        //restituisce true o false a seconda di una determinata condizione
        // è analogo a Func<object,bool> canExecute

        public RelayCommand(Action<object?> Execute, Predicate<object?> CanExecute)
        {
            this.executeMethod = Execute;
            this.canExecuteMethod = CanExecute;
        }

        public bool CanExecute(object? parameter)
        {
            if (canExecuteMethod == null)
            {
                return true; //se non è stato istanziato il metodo canExecuteMethod do per scontato che questo comando sarà sempre abilitato
            }
            return canExecuteMethod.Invoke(parameter);


            //potevamo scrivere tutto così
            //return (canExecuteMethod == null) ? true : canExecuteMethod.Invoke(parameter);
        }

        internal void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);  //invoco il metodo canExecuteChanged
        }

        public void Execute(object? parameter)
        {
            //richiamo il metodo da eseguire
            executeMethod?.Invoke(parameter); 

            //è analogo a 

            //if(executeMethod != null)
            //{
            //    executeMethod.Invoke(parameter);
            //}
        }
    }
}
