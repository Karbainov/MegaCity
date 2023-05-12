﻿using MegaCity.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL
{
    public class ProductService
    {
        public List<ProductModel> GetAllProducts()
        {
            
            List<ProductModel> products = new List<ProductModel>()
            {
                new ProductModel()
                {
                    Id=5,
                    Name = "productOne",
                    Price = 100,
                    Count=150
                },

                new ProductModel()
                {
                    Id=8,
                    Name = "productTwo",
                    Price = 200,
                    Count=60
                },

                new ProductModel()
                {
                    Id=3,
                    Name = "productThree",
                    Price = 300,
                    Count=50
                }
            };

            return products;
        }
    }
    
}