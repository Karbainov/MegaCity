using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class CashboxRepository
    {
        private MegaCityDbContext _context;

        public CashboxRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllCashboxes()
        {
            _context.Cashboxes.ToList();
        }

        public void DeleteById(int id)
        {
            var cashbox = _context.Cashboxes.FirstOrDefault(i => i.Id == id);
            if (cashbox != null)
            {
                _context.Cashboxes.Remove(cashbox);
                _context.SaveChanges();
            }
        }
    }
}
