using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class CheckRepository
    {
        private MegaCityDbContext _context;

        public CheckRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllChecks()
        {
            _context.Checks.ToList();
        }

        public OrderDto GetCheckById(int id)
        {
            return _context.Checks.FirstOrDefault(i => i.Id == id);
        }

        public OrderDto AddCheck(int userId, OrderDto check)
        {
            var newCheck = _context.Checks.FirstOrDefault();

            if (check != null)
            {
                _context.Checks.Add(check);

                //newCheck.Orders.Add(check);
                //check.User = newCheck;

                _context.SaveChanges();
            }

            return newCheck;
        }

        public void DeleteByid(int id)
        {
            var check = _context.Checks.FirstOrDefault(i => i.Id == id);
            if (check != null)
            {
                _context.Checks.Remove(check);
                _context.SaveChanges();
            }
        }
    }
}
