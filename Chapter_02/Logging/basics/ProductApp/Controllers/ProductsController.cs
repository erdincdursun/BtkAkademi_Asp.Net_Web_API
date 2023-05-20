using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/[products]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;     //readonly: Değeri constructor veya tanımlandığı yerde verilir.Başka yerde verilmez.

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = new List<Product>()
            {
                 new Product(){Id=1,ProductName="Computer"},
                 new Product(){Id=2,ProductName="Keyboard"},
                 new Product(){Id=1,ProductName="Mouse"}


            };
            return Ok(products);
        }

    }
}
