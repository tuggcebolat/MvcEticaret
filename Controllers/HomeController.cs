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
                new ProductsItem
                {
                     Title = "Product 2",
                      StartCount = 6,
                     OldPrice = 22.99M,
                      Price = 18.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },
                new ProductsItem
                {
                     Title = "Product 3",
                      StartCount = 5,
                     OldPrice = 50.99M,
                      Price = 35.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },
                new ProductsItem
                {
                     Title = "Product 4",
                      StartCount = 6,
                     OldPrice = 22.99M,
                      Price = 18.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },
                new ProductsItem
                {
                     Title = "Product 5",
                      StartCount = 5,
                     OldPrice = 50.99M,
                      Price = 35.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },
                new ProductsItem
                {
                     Title = "Product 6",
                      StartCount = 6,
                     OldPrice = 22.99M,
                      Price = 18.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },
                new ProductsItem
                {
                     Title = "Product 7",
                      StartCount = 6,
                     OldPrice = 22.99M,
                      Price = 18.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },
                new ProductsItem
                {
                     Title = "Product 8",
                      StartCount = 6,
                     OldPrice = 22.99M,
                      Price = 18.99M,
                    ImageUrl = "product1.jpg",
                     IsSale = true
                },
            };
            return View(products);
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
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}