using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class PromotionRepository
    {
        private MegaCityDbContext _context;

        public PromotionRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllpromotions()
        {
            _context.Promotions.ToList();
        }

        public PromotionDto GetPromotionById(int id)
        {
            return _context.Promotions.FirstOrDefault(i => i.Id == id);
        }

        public void AddPromotion(PromotionDto promotion)
        {
            _context.Promotions.Add(promotion);
            _context.SaveChanges();
        }

        public void DeletePromotionById(int id)
        {
            //_context.Promotions.Remove();
        }
    }
}
