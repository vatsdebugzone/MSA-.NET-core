using Microsoft.AspNetCore.Mvc;
using ProductAPI.DTO;
using ProductAPI.Entities;
using ProductAPI.Services;
using ProductAPI.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private  IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var products = await _service.GetAllProducts();
                return this.ToApiResponse(products);
            }
            catch (Exception ex)
            {
                return this.ToApiErrorResponse(ex.Message);
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var product = await _service.GetProductByIdAsync(id);
                return this.ToApiResponse(product);
            }
            catch(Exception ex)
            {
                return this.ToApiErrorResponse(ex.Message);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductDto product)
        {
            try
            {
                var response=await _service.CreateUpdateProductAsync(product);
                return this.ToApiResponse(product);
            }
            catch (Exception ex)
            {
                return this.ToApiErrorResponse(ex.Message);
                //return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
