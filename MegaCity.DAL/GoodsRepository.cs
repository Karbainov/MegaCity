using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

namespace MegaCity.DAL
{
    public class GoodsRepository
    {
        private MegaCityDbContext _context;

        public GoodsRepository()
        {
            _context = new MegaCityDbContext();
        }

        public GoodsDto AddProduct(GoodsDto goods)
        {
            if (goods != null)
            {
                _context.Goods.Add(goods);
                _context.SaveChanges();
            }

            return goods;
        }

        public ComponentDto AddComponent(double count, int goodsId, int productId)
        {
            var goods = _context.Goods.FirstOrDefault(i => i.Id == goodsId);
            var product = _context.Products.FirstOrDefault(i => i.Id == productId);

            if (goods != null && product != null)
            {
                ComponentDto newComponent = new ComponentDto()
                {
                    Count = count,
                    Goods = goods,
                    Product = product
                };
                _context.Components.Add(newComponent);
                goods.Components.Add(newComponent);
                product.Components.Add(newComponent);
                _context.SaveChanges();

                return newComponent;
            }
            else
            {
                throw new Exception();
            }
        }

        public GoodsDto GetGoodsById(int id)
        {
            return _context.Goods.FirstOrDefault(i => i.Id == id);
        }

        public void DeleteGoodsById(int id)
        {
            var Goods = _context.Goods.FirstOrDefault(i => i.Id == id);
            if(Goods!=null)
            {
                _context.Goods.Remove(Goods);
                _context.SaveChanges();
            }
        }

        public GoodsDto UpdateGoods(GoodsDto Goods)
        {
            var u = _context.Goods.FirstOrDefault(i => i.Id == Goods.Id);
            u.Name = Goods.Name;
            u.Cost = Goods.Cost;
            u.Count = Goods.Count;
            _context.SaveChanges();
            return u;
        }
    }
}
