using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using MegaCity.API.Models.RequestModels;
using Microsoft.EntityFrameworkCore;

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
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile())));
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _mapper.Map<List<ProductResponseModel>>(_productService.GetAllProducts());

            return Ok(products);

        } 

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var a = _productService.GetProductById(id);
            var product = _mapper.Map<ProductResponseModel>(a);

            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductRequestModel product)
        {
            ProductModel productMap = _mapper.Map<ProductModel>(product);
            var newProduct = _productService.AddProduct(productMap);
            ProductResponseModel result = _mapper.Map<ProductResponseModel>(newProduct);

            return Created(new Uri($"product", UriKind.Relative), result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            _productService.DeleteProductById(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProductById(int id, ProductRequestModel product)
        {
            ProductModel productModel = _mapper.Map<ProductModel>(product);
            productModel.Id = id;
            ProductModel newProduct = _productService.UpdateProductById(id, productModel);
            ProductResponseModel productOutput = _mapper.Map<ProductResponseModel>(newProduct);

            return Ok(productOutput);
        }
    }
}
