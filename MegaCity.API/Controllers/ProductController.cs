using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
﻿using MegaCity.API.Models.InputModel;
using MegaCity.API.Models.OutputModel;
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
            List<ProductModel> products = _productService.GetAllProducts();
            List<ProductResponseModel> allProducts = _mapper.Map<List<ProductResponseModel>>(products);

            return Ok(allProducts);

        } 

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
<<<<<<< Updated upstream
            var a = _productService.GetProductById(id);
            var product = _mapper.Map<ProductResponseModel>(a);

            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductRequestModel model)
        {
            ProductModel productModel = _mapper.Map<ProductModel>(model);
            ProductModel newProduct = _productService.AddProduct(productModel);
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
            _productService.UpdateProductById(id, productModel);
            ProductResponseModel productOutput = _mapper.Map<ProductResponseModel>(productModel);

            return Ok(productOutput);
        }

            ProductResponseModel product = new ProductResponseModel()
            {
                Id = 20000,
                Name = "product",
                Price = 20,
                Count = 70
            };

            return Ok(product);
        }
>>>>>>> Stashed changes
    }
}

[HttpGet("Spoiled")]
        public IActionResult GetSpoiledProducts()
        {
            List<ProductOutputModel> SpoiledProducts = new List<ProductOutputModel>()
            {
                new ProductOutputModel()
                {
                    Name = "productOne",
                    Count = 11
                },

                new ProductOutputModel()
                {
                    Name = "productTwo",
                    Count = 17
                }
            };

            return Ok(SpoiledProducts);
        }



        [HttpPost()]
        public IActionResult AddProduct(ProductInputModel product)
        {
            ProductInputModel newProduct = new ProductInputModel()
            {
                Id = 1,
                Name = product.Name,
                DataInput = product.DataInput,
                Count = product.Count,
                Price = product.Price,

            };

            return Created("Product", "product");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductInputModel product)
        {
            ProductInputModel productOutput = new ProductInputModel()
            {
                Id = id,
                Name = product.Name,
                DataInput = product.DataInput,
                Count = product.Count,
                Price = product.Price,

            };

            return Ok(productOutput);
        }
    }
}


                

                
>>>>>>> 1.16AddEndPointsForFilial
