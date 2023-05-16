namespace MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

public class ProductRepository
{
    private ProductDbContext _context;

    public ProductRepository()
    {
        _context = new ProductDbContext();
    }
     
    public ProductDto AddProduct(ProductDbContext model)
    {
        _context.Products.Add(model);
        _context.SaveChanges();
        return model;
    }

    public List<ProductDto>GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public ProductDto GetProductById(int id)
    {
        return _context.Products.Include(g => g.Goods).FirstOrDefault(i => i.Id == id);
    }

    public void deleteProductById(int id)
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