using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore2.Models
{
    public class DataRepository: IRepository
    {
        // private readonly List<Product> _data = new();
        private DataContext _context;
        public DataRepository(DataContext context) => _context = context;
        public IEnumerable<Product> Products => _context.Products.ToArray();
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
