using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Week7.WPF.AppBase.Converters
{
    public class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //tutti i valori che contengono un int32 hanno il toString
            return value.ToString(); //converte da intero a stringa
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            //conversione da stringa ad intero, si fa con il tryparse
            int.TryParse(value.ToString(), out int valore);
            return valore == 0 ? parameter : valore;
            //questo converter lo usiamo nella view per dire che questo elemento è caratterizzato da una conversione
        }
    }
}
