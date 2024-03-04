using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Controllers;

public class CategoryController : Controller
{
    private IServiceManager _manager;

    public CategoryController(IServiceManager manager)
    {
        _manager = manager;
    }

    public IActionResult Index()
    {
        IEnumerable<Category>? categories = _manager.CategoryService.GetAllCategories(false);
        return View(viewName: "Index", model: categories);
    }

}