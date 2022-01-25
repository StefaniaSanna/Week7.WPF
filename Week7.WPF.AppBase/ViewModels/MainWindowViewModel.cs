using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.WPF.AppBase.ViewModels
{
    public class MainWindowViewModel:BaseViewModel
        //mettiamo tutti gli elementi della view che voglio controllare con il binding
    {
        //aggiungo le proprietà che ci servono
        private string _myProperty = "Testo di prova"; //per queste operazioni di binding abbiamo sempre uno privato e uno pubblico
        public string MyProperty
        {
            get
            {
                //System.Diagnostics.Debug.WriteLine("Get");
                return _myProperty;
            }
            set 
            {
                _myProperty = value;
                NotifyPropertyChanged();
                
            }
        }

        private int _myProperty2;
        public int MyProperty2
        {
            get
            {
                return _myProperty2;
            }
            set
            {
                _myProperty2 = value;
            }
        }

        private bool ischecked =true;
            public bool IsChecked
        {
            get { return ischecked; }
            set { ischecked = value; NotifyPropertyChanged(); }

        }
    }
}
