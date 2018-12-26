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
            return View(new NullSearchViewModel());
        }

        [HttpPost]
        public IActionResult Index([FromForm]SearchViewModel model)
        {
            var searchViewModel = _productService.Search(model.SearchTerm);
            return View(searchViewModel);
        }

        public IActionResult Product(int productId)
        {
            var productViewModel = _productService.GetProduct(productId);
            return View(productViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
