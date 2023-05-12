﻿using MegaCity.API.Models.RequestModel;
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

        [HttpPost]
        public IActionResult AddProduct(ProductRequestModel model)
        {
            ProductResponseModel product = new ProductResponseModel()
            {
                Name = model.Name,
                Price = model.Price,
                Count = model.Count
            };

            return Created("Product", "NewProduct");
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
