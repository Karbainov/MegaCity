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

        public GoodsDto AddGoods(GoodsDto goods)
        {
            if (goods != null)
            {
                _context.Goods.Add(goods);
                _context.SaveChanges();
            }

            return goods;
        }




        public void GetGoodsInformationById(int id)
        {
            _context.Users.ToList();
            return;
        }
        //public void GetRemainingCountGoodsByEmail(int email)
        //{
        //    _context.
        //}




        public GoodsDto GetGoodsById(int id)
        {
            return _context.Goods.FirstOrDefault(i => i.Id == id);
        }

        public void DeleteGoodsById(int id)
        {
            var goods = _context.Goods.FirstOrDefault(i => i.Id == id);

            if (goods != null)
            {
                _context.Goods.Remove(goods);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Не удалось удалить!");
            }
        }

        public GoodsDto UpdateGoods(int id, GoodsDto goods)
        {
            var goodsId = _context.Goods.FirstOrDefault(i => i.Id == goods.Id);

            if (goodsId != null)
            {
                goodsId.Name = goods.Name;
                goodsId.Cost = goods.Cost;
                goodsId.Count = goods.Count;

                _context.SaveChanges();

                return goodsId;
            }
            else
            {
                throw new Exception("Не удалось изменить!");
            }
        }
    }
}
