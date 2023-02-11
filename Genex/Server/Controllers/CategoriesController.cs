using Genex.Server.Models.Repository.CategoryRepository;
using Genex.Server.Models.Repository.ProductRepository;
using Genex.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Genex.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]

        public async Task<ActionResult<Product>> GetAllProducts()
        {
            try
            {
                return Ok(await categoryRepository.GetAllCategories());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving");
            }
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<Product>> GetCategoryById (int id)
        {
            try
            {
                return Ok(await categoryRepository.GetCategoryById(id));
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retreieving");
            }
        }
    }
}
