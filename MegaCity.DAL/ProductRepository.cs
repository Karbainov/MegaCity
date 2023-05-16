using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class ProductRepository
    {
        private MegaCityDbContext _context;

        public ProductRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllProducts()
        {
            _context.Products.ToList();
        }

        public ProductDto GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(i => i.Id == id);
        }

        public void AddProduct(ProductDto product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProductByid(int id)
        {
            
        }
    }

}
