using Genex.Server.Data;
using Genex.Server.Models.Repository.CategoryRepository;
using Genex.Shared;
using Microsoft.EntityFrameworkCore;


namespace Genex.Server.Models.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;

        private readonly ICategoryRepository categoryRepository;

        public ProductRepository(AppDbContext appDbContext, ICategoryRepository categoryRepository)
        {
            this.appDbContext = appDbContext;
            this.categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryId(int categoryId)
        {
            var category = await categoryRepository.GetCategoryById(categoryId);
            return await appDbContext.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
