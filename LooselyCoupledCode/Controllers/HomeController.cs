using LooselyCoupledCode.Models;
using LooselyCoupledCode.Viewmodels;
using Loosly_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LooselyCoupledCode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            if (productService == null)
            {
                throw new ArgumentNullException(nameof(productService));
            }

            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            //var vm = new FeaturedProductsViewModel(new[]
            //{
            //    new ProductViewModel("Product 1", 10.00m),
            //    new ProductViewModel("Product 2", 20.00m),
            //    new ProductViewModel("Product 3", 30.00m)
            //});

            var products = _productService.GetFeaturedProducts();
            var vm = new FeaturedProductsViewModel(products.Select(p => new ProductViewModel(p.Name, p.UnitPrice)).ToArray());

            return View(vm);
        }

        public IActionResult Privacy()
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
