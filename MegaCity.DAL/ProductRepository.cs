namespace MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

public class ProductRepository
{
    private MegaCityDbContext _context;

    public ProductRepository()
    {
        _context = new MegaCityDbContext();
    }
     
    public ProductDto AddProduct(ProductDto product)
    {
        if (product != null)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        return product;
    }

    public ComponentDto AddComponent(double count, int goodsId)
    {
        var goods = _context.Goods.FirstOrDefault(i => i.Id == goodsId);

        if (goods != null)
        {
            ComponentDto newComponent = new ComponentDto()
            {
                Count = count,
                Goods = goods
            };
            _context.Components.Add(newComponent);
            goods.Components.Add(newComponent);
            
            _context.SaveChanges();

            return newComponent;
        }
        else
        {
            throw new Exception();
        }
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
        var product = _context.Products.FirstOrDefault(i => i.Id == id);

        if (product != null)
        {
            foreach (var u in _context.OrderPositions.ToList())
            {
                if (u.Product.Id == id)
                {
                    u.Product = null;
                }
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
        }
        else
        {
            throw new Exception();
        }
    }

    public ProductDto UpdateProduct(int id, ProductDto product)
    {
        var updateProduct = _context.Products.FirstOrDefault(i => i.Id == product.Id);

        if (updateProduct != null)
        {
            updateProduct.Name = product.Name;
            updateProduct.Price = product.Price;
            updateProduct.Count = product.Count;

            _context.SaveChanges();

            return updateProduct;
        }
        else
        {
            throw new Exception("Не удалось изменить!");
        }
    }
}