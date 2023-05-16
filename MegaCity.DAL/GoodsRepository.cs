using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class GoodsRepository
    {
        private MegaCityDbContext _context;

        public GoodsRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllGoods()
        {
            _context.Goods.ToList();
        }

        public GoodsDto GetGoodsById(int id)
        {
            return _context.Goods.FirstOrDefault(i => i.Id == id);
        }

        public void AddGoods(GoodsDto goods)
        {
            _context.Goods.Add(goods);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            
        }
    }
}
