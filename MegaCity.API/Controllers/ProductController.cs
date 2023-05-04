﻿using MegaCity.API.Models;
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

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            ProductOutputModel product = new ProductOutputModel()
            {
                Id = 20000,
                Name="product",
                Price=20,
                Count=70
            };

            return Ok(product);
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
    }
}

                

                
