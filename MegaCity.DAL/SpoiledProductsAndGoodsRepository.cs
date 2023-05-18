using System;
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
            _context.StorageChanges.ToList();
        }

        public void AddSpoiledProductsAndGoods(StorageChangeDto spoiled)
        {
            _context.StorageChanges.Add(spoiled);
            _context.SaveChanges();
        }

        public void DeleteSpoiledProductsAndGoodsById(int id)
        {
            var spoiled = _context.StorageChanges.FirstOrDefault(i => i.Id == id);
            if (spoiled != null)
            {
                _context.StorageChanges.Remove(spoiled);
                _context.SaveChanges();
            }
        }
    }
}
