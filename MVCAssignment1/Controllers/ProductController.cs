using Microsoft.AspNetCore.Mvc;
using MVCAssignment1.Models;

namespace MVCAssignment1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            
            List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Sofa", Price = 100 },
            new Product { Id = 2, Name = "Table", Price = 200 },
            new Product { Id = 3, Name = "Chair", Price = 300 }
        };

            
            ViewData["Message"] = "This is the product list";

           
            ViewBag.Products = products;

            return View();
        }
    }
}
