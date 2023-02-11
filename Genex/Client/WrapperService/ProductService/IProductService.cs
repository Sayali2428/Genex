using Genex.Shared;

namespace Genex.Client.WrapperService.ProductService
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task<IEnumerable<Product>> GetProductByCategoryId(int categoryId);
    }
}
