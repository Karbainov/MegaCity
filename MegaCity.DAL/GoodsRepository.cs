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

        public GoodsDto AddGoods(int productId,GoodsDto Goods)
        {
            var model = _context.Products.FirstOrDefault(i => i.Id == productId);

            if(model!=null)
            {
                _context.Goods.Add(Goods);
                model.Goods.Add(Goods);
                Goods.Product = model;
                _context.SaveChanges();

            }
            return Goods;
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
            u.Price = Goods.Price;
            u.Count = Goods.Count;
            _context.SaveChanges();
            return u;
        }
    }
}
