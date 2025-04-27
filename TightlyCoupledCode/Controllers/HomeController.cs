using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TightlyCoupledCode.Models;

namespace TightlyCoupledCode.Controllers
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
            bool isFeaturatedCustomer = this.User.IsInRole("PreferredCustomer");
            var service = new ProductService();

            var products = service.GetFeaturesProducts(isFeaturatedCustomer);
            this.ViewData["Products"] = products;

            return View();
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
