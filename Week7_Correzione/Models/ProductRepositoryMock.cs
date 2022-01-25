using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Correzione.Models
{
    public class ProductRepositoryMock : IProductRepository
    {
        private IList<Product> products = new List<Product>()
        {
            new Product()
            {
                Name ="Smartphone",
                Description="IPhone XR 128 GB",
                Price=450.45
            },
            new Product()
            {
                Name ="Borsa Gucci",
                Description="Borsa in pelle",
                Price=200
            }
        }; 
        public IList<Product> GetAll()
        {
            return products;
        }
    }
}
