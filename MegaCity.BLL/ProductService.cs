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

        public ProductModel UpdateProduct(ProductModel productModel)
        {
            var model = _mapper.Map<ProductDto>(productModel);
            return _mapper.Map<ProductModel>(_productRepository.UpdateProduct(model));
        }

        public void DeleteProductById(int id)
        {
            _productRepository.DeleteProductById(id);
        }

        public ProductModel AddProduct(ProductModel productModel)
        {
            var model = _mapper.Map<ProductDto>(productModel);
            return _mapper.Map<ProductModel>(_productRepository.AddProduct(model));
        }
    }
    
}
