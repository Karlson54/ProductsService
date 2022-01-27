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
            return await _productsService.GetAllProducts
        }
    }
}