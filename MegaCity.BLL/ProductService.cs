using MegaCity.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MegaCity.DAL;
using MegaCity.DAL.Dots;
using System.Diagnostics;
using System.Xml.Linq;


namespace MegaCity.BLL
{
    public class ProductService
    {
        private IMapper _mapper;
        private ProductRepository _productRepository;

        public ProductService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _productRepository = new ProductRepository();
        }

        public List<ProductModel> GetAllProducts()
        {
            return _mapper.Map<List<ProductModel>>(_productRepository.GetAllProducts());
        }

        public ProductModel GetProductById(int id)
        {
            var a = _productRepository.GetProductById(id);

            return _mapper.Map<ProductModel>(a);
        }

        public void DeleteProductById(int id)
        {
            _productRepository.DeleteProductById(id);
        }

        public ProductModel AddProduct(ProductModel product)
        {

            ProductDto productDto = _mapper.Map<ProductDto>(product);

            var newProductDto = _productRepository.AddProduct(productDto);

            if (newProductDto != null)
            {
                foreach (var component in product.Components)
                {
                    _productRepository.AddComponent(component.Count, component.GoodsId);
                }

                ProductModel newProduct = _mapper.Map<ProductModel>(newProductDto);

                return newProduct;
            }
            else
            {
                throw new Exception("Продукт не создан!");
            }
        }

        public ProductModel UpdateProductById(int id, ProductModel product)
        {
            var updateProduct = _mapper.Map<ProductModel>(product);

            return updateProduct;
        }
    }
}
