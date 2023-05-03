using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AllProductController : ControllerBase
    {
        [HttpGet("product")]
        public IActionResult GetAllProducts()
        {
            List<ProductOutputModel> products = new List<ProductOutputModel>()
            {
                new ProductOutputModel()
                {
                    Id=5,
                    Name = "productOne",
                    Price = 100,
                    Count=150
                },

                new ProductOutputModel()
                {
                    Id=8,
                    Name = "productTwo",
                    Price = 200,
                    Count=60
                },

                new ProductOutputModel()
                {
                    Id=3,
                    Name = "productThree",
                    Price = 300,
                    Count=50
                }
            };

            return Ok(products);
        }
    }
}
