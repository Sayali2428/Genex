using Genex.Shared;

namespace Genex.Client.WrapperService.CategoryService
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int categoryId);
    }
}
