using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace StoreApp.Controllers;

public class CategoryController : Controller
{
    private IRepositoryManager _manager;

    public CategoryController(IRepositoryManager manager)
    {
        _manager = manager;
    }

    public IActionResult Index()
    {
        IQueryable<Category>? model = _manager.Category.FindAll(false);
        return View("Index", model);
    }

}