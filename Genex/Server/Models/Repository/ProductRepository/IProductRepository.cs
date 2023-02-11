using Genex.Shared;

namespace Genex.Server.Models.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task<IEnumerable<Product>> GetProductByCategoryId(int categoryId);
    }
}
