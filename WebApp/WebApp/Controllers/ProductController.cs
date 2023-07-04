using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products;
        public ProductController()
        {
            _products = new List<Product>()
            {
                new Product {Id=1,Name="C#",Price=50 },
                new Product {Id=2,Name="C++",Price=55 },
                new Product {Id=3,Name="C",Price=59 },

            };
        }
        public IActionResult Index()
        {

            ViewBag.Products = _products;
            return View();



        }
        public IActionResult Detail(int id)
        {
            Product product = _products.Find(p => p.Id == id);
            if (product == null)
            {
                return View("Error");
            }

            ViewBag.Name = product.Name;
            ViewBag.Price = product.Price;

            return View();
        }
    }
}

