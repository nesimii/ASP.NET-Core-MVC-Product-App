using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            IEnumerable<Product>? products = _manager.ProductService.GetAllProducts(false);
            return View(viewName: "Index", model: products);
        }

        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            Product? product = _manager.ProductService.GetOneProduct(id, false);
            return View(viewName: "Get", model: product);
        }
    }
}