using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetAllProducts()
        {
            List<ProductResponseModel> products = new List<ProductResponseModel>()
            {
                new ProductResponseModel()
                {
                    Id=5,
                    Name = "productOne",
                    Price = 100,
                    Count=150
                },

                new ProductResponseModel()
                {
                    Id=8,
                    Name = "productTwo",
                    Price = 200,
                    Count=60
                },

                new ProductResponseModel()
                {
                    Id=3,
                    Name = "productThree",
                    Price = 300,
                    Count=50
                }
            };

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            ProductResponseModel product = new ProductResponseModel()
            {
                Id = 20000,
                Name = "product",
                Price = 20,
                Count = 70
            };

            return Ok(product);
        }
    }
}
