using Genex.Server.Models.Repository.ProductRepository;
using Genex.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Genex.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]

        public async Task<ActionResult<Product>> GetAllProducts()
        {
            try
            {
                return Ok(await productRepository.GetAllProducts());
            }
            catch (Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving");
            }
        }


        [HttpGet("{id:int}")]

        public async Task<ActionResult<Product>> GetAllProductsByCategoryId(int id)
        {
            try
            {
                return Ok(await productRepository.GetProductByCategoryId(id));
            }

            catch (Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retreieving");
            }
        }
    }
}
