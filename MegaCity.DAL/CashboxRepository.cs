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

        public CashboxDto GetCashboxById(int id)
        {
            return _context.Cashboxes.FirstOrDefault(i => i.Id == id);
        }

        public void AddAdmin(CashboxDto cashbox)
        {
            _context.Cashboxes.Add(cashbox);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            //_context.Cashboxes.Remove();
            _context.SaveChanges();
        }
    }
}
