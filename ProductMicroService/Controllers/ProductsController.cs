using Core.Abstract.Services;
using Core.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }


        // GET: api/<ProdutsController>
        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> Get()
        {
            return await _service.GetAll();
        }

        // GET api/<ProdutsController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<ProductDTO>> Get(int id)
        {
            return await _service.GetAllByCategory(id);
        }

        
    }
}
