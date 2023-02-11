using Genex.Shared;

namespace Genex.Server.Models.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int categoryId);
    }
}
