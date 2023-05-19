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
            _context.Users.ToList();
            _context.SaveChanges();
        }

        public UserDto GetMnagerById(int id)
        {
            return _context.Users.FirstOrDefault(i => i.Id == id);
        }

        public UserDto AddManager(UserDto manager)
        {
            var managerUser = _context.Users.FirstOrDefault();

            if (manager != null)
            {
                _context.Users.Add(manager);
                _context.SaveChanges();
            }

            return managerUser;
        }

        public void DeleteMnaagerById(int id)
        {
            var manager = _context.Users.FirstOrDefault(i => i.Id == id);
            if (manager != null)
            {
                _context.Users.Remove(manager);
                _context.SaveChanges();
            }
        }
    }
}
