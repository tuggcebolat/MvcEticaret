using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Navbar()
        {
            return PartialView();
        }
        public PartialViewResult Footer()
        {
          
           return PartialView();
        }
        public IActionResult Index1()
        {
            var products = new List<ProductsItem>
            {
                new ProductsItem
                {
                     Title = "Product 1",
                      StartCount = 5,
                     OldPrice = 20.99M,
                      Price = 15.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },

            };
            return View("Index1",products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}