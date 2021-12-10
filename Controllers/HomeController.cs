using Microsoft.AspNetCore.Mvc;
using SportsStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore2.Controllers
{
    public class HomeController: Controller
    {
        private IRepository _repository;
        public HomeController(IRepository repository) => _repository = repository;
        public IActionResult Index() 
        {
            // System.Console.Clear();
            return View(_repository.Products);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _repository.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UpdateProduct(long key)
        {
            return View(_repository.GetProduct(key));
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _repository.UpdateProduct(product);
            return RedirectToAction(nameof(Index));
        }

    }
}
