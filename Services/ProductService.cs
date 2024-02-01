using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services;

public class ProductService : IProductService
{
    private readonly IRepositoryManager _manager;

    public ProductService(IRepositoryManager manager)
    {
        _manager = manager;
    }

    public IEnumerable<Product> GetAllProducts(bool trackChanges)
    {
        return _manager.Product.GetAllProducts(trackChanges);
    }

    public Product? GetOneProduct(int id, bool trackChanges)
    {
        Product? product = _manager.Product.GetOneProductById(id, trackChanges);
        if (product == null) throw new Exception("Product not found");
        return product;
    }
}