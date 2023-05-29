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

        public List <ProductModel>GetAllProducts()
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

        public ProductModel AddProduct(List<ComponentModel> components)
        {
            ProductDto productDto = new ProductDto();

            var newProductDto = _productRepository.AddProduct(productDto);

            if (newProductDto != null)
            {
                foreach (var component in components)
                {
                    _productRepository.AddComponent(component.Count, component.GoodsId, component.ProductId);
                }

                ProductModel newProduct = _mapper.Map<ProductModel>(newProductDto);

                return newProduct;
            }
            else
            {
                throw new Exception("Продукт не создан!");
            }
        }

        public ProductModel UpdateProductById(ProductModel product)
        {
            return product;

            //ProductDto updateProduct = _mapper.Map<ProductDto>(product);

            //if (updateProduct != null)
            //{
            //    updateProduct.Name = product.Name;
            //    updateProduct.Price = product.Price;
            //    updateProduct.Count = product.Count;

            //    ProductModel newUpdate = _mapper.Map<ProductModel>(updateProduct);

            //    return newUpdate;
            //}
            //else
            //{
            //    throw new Exception("Не удалось изменить!");
            //}
        }
    }
}
