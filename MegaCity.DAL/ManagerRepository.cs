using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class ManagerRepository
    {
        private MegaCityDbContext _context;

        public ManagerRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllManagers()
        {
            _context.Managers.ToList();
            _context.SaveChanges();
        }

        public ManagerDto GetMnagerById(int id)
        {
            return _context.Managers.FirstOrDefault(i => i.Id == id);
        }

        public void AddManager(ManagerDto manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
        }

        public void DeleteMnaagerById(int id)
        {
            
        }
    }
}
