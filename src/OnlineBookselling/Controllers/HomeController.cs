using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineBookselling.ViewModels;
using OnlineBookselling.Services;

namespace OnlineBookselling.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]ISearchViewModel model)
        {
            var searchViewModel = _productService.Search(model.SearchTerm);
            return View(searchViewModel);
        }

        public IActionResult Product(long productId)
        {
            var productViewModel = _productService.GetProduct(productId);
            return View(productViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
