using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductService _productService;
        Mapper _mapper;

        public ProductController()
        {
            _productService = new ProductService();

            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperApiProfile());
            });
            _mapper = new Mapper(configuration);
        }
        [HttpGet()]
        public IActionResult GetAllProducts()
        {
            List<ProductModel> product = _productService.GetAllProducts();
            List<ProductResponseModel> products = _mapper.Map<List<ProductResponseModel>>(product);
            return Ok(products);

        } 


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            ProductResponseModel product = new ProductResponseModel()
            {
                Id = 20000,
                Name="product",
                Price=20,
                Count=70
            };

            return Ok(product);
        }
    }
}
