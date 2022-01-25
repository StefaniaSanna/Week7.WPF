using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Correzione.ViewModels
{
    public class MainWindowViewModel:BaseViewModel
    {
        //ci andranno proprietà
        private bool ischecked = true;
        public bool IsChecked
        {
            get { return ischecked; }
            set { ischecked = value; NotifyPropertyChanged(); }

        }
    }
}
