using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components;
public class ProductSummaryViewComponent : ViewComponent
{
    private readonly IServiceManager __manager;

    public ProductSummaryViewComponent(IServiceManager manager)
    {
        __manager = manager;
    }

    public string Invoke()
    {
        return __manager.ProductService.GetAllProducts(false).Count().ToString();
    }
}