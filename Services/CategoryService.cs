using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services;


public class CategoryService : ICategoryService
{
    private IRepositoryManager _manager;

    public CategoryService(IRepositoryManager manager)
    {
        _manager = manager;
    }

    public IEnumerable<Category> GetAllCategories(bool trackChanges)
    {
        return _manager.Category.FindAll(trackChanges);
    }
}