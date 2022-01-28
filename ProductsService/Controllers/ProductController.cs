using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsBusinessLayer;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsPresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static ProductsService _productsService;

        static ProductController()
        {
            _productsService = new ProductsService();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var items =  await _productsService.GetAllProducts();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById (Guid id)
        {
            var item = await _productsService.GetProductById(id);
            if (item != null)
            {
                return Ok(item);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteProductById(Guid id)
        {
            var item = await _productsService.DeleteProductById(id);
            if (item != null)
            {
                return Ok(item);
            }
            return NotFound();
        }
    }
}