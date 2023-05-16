using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using MegaCity.API.Models.RequestModels;

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
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<ProductModel> products = _productService.GetAllProducts();
            List<ProductResponseModel> allProducts = _mapper.Map<List<ProductResponseModel>>(products);

            return Ok(allProducts);

        } 

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            ProductModel product = _productService.GetProductById();
            ProductResponseModel productId = _mapper.Map<ProductResponseModel>(product);

            return Ok(productId);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductRequestModel model)
        {
            ProductModel productModel = _mapper.Map<ProductModel>(model);
            _productService.AddProduct(productModel);

            ProductResponseModel newProduct = _mapper.Map<ProductResponseModel>(productModel);

            return Created(new Uri("Product", UriKind.Relative), newProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProductById(int id, ProductRequestModel product)
        {
            ProductResponseModel productOutput = new ProductResponseModel()
            {
                Name = product.Name,
                Price = product.Price,
                Count = product.Count
            };

            return Ok(productOutput);
        }
    }
}
