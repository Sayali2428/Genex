using Genex.Server.Data;
using Genex.Shared;
using Microsoft.EntityFrameworkCore;

namespace Genex.Server.Models.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        { this.appDbContext = appDbContext; }
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await appDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await appDbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
        }
    }


}
