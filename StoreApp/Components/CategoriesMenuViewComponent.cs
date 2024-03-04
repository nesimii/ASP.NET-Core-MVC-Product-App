using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components;

public class CategoriesMenuViewComponent : ViewComponent
{
    private readonly IServiceManager _manager;

    public CategoriesMenuViewComponent(IServiceManager manager)
    {
        _manager = manager;
    }

    public IViewComponentResult Invoke()
    {
        IEnumerable<Category> categories = _manager.CategoryService.GetAllCategories(false);
        return View(viewName: "Categories", model: categories);
    }
}