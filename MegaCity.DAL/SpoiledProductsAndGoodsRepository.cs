﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class SpoiledProductsAndGoodsRepository
    {
        private MegaCityDbContext _context;

        public SpoiledProductsAndGoodsRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllSpoiledProductsAndPromotions()
        {
            _context.SpoiledProductsAndGoods.ToList();
        }

        public void AddSpoiledProductsAndGoods(SpoiledProductsAndGoodsDto spoiled)
        {
            _context.SpoiledProductsAndGoods.Add(spoiled);
            _context.SaveChanges();
        }

        public void DeleteSpoiledProductsAndGoodsById(int id)
        {
            var spoiled = _context.SpoiledProductsAndGoods.FirstOrDefault(i => i.Id == id);
            if (spoiled != null)
            {
                _context.SpoiledProductsAndGoods.Remove(spoiled);
                _context.SaveChanges();
            }
        }
    }
}
