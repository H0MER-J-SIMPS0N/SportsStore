using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore2.Models
{
    public class DataRepository: IRepository
    {
        private readonly List<Product> _data = new();
        public IEnumerable<Product> Products => _data;
        public void AddProduct(Product product)
        {
            _data.Add(product);
        }
    }
}
