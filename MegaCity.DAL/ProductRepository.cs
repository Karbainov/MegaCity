namespace MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

public class ProductRepository
{
    private MegaCityDbContext _context;

    public ProductRepository()
    {
        _context = new MegaCityDbContext();
    }
     
    public ProductDto AddProduct(int userId, ProductDto model)
    {
        var product = _context.Products.FirstOrDefault();

        if (product != null)
        {
            _context.Products.Add(product);

            //product.Products.Add(model);
            //model.User = product;

            _context.SaveChanges();
        }

        return model;
    }

    public List<ProductDto>GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public ProductDto GetProductById(int id)
    {
        return _context.Products.Include(g => g.Components).ThenInclude(k => k.Goods).FirstOrDefault(i => i.Id == id);
    }

    public void DeleteProductById(int id)
    {
        var model = _context.Products.FirstOrDefault(i => i.Id == id);

        if(model!=null)
        {
            _context.Products.Remove(model);
            _context.SaveChanges();
        }
    }

    public ProductDto UpdateProduct(ProductDto model)
    {
        var u = _context.Products.FirstOrDefault(i => i.Id == model.Id);
        u.Name = model.Name;
        u.Price = model.Price;
        u.Count = model.Count;
        _context.SaveChanges();
        return u;
    }
}