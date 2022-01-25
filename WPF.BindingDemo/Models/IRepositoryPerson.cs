using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.BindingDemo.Models
{
    public interface IRepositoryPerson
    {
        IList<Person> GetAll();
    }
}
