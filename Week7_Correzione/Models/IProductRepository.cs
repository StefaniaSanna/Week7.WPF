using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Correzione.Models
{
    public interface IProductRepository
    {
        public IList<Product> GetAll();
    }
}
