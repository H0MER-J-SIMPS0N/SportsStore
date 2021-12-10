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
        public Product GetProduct(long key) => _context.Products.Find(key);
        public void AddProduct(Product product)
        { 
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            Product p = GetProduct(product.Id);
            p.Name = product.Name;
            p.Category = product.Category;
            p.PurchasePrice = product.PurchasePrice;
            p.RetailPrice = product.RetailPrice;
            // _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
