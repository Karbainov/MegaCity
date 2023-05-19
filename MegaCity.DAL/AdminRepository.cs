using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class AdminRepository
    {
        private MegaCityDbContext _context;

        public AdminRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllAdmins()
        {
            _context.Admins.ToList();
        }

        public UserDto GetAdminById(int id)
        {
            return _context.Admins.FirstOrDefault(i => i.Id == id);
        }

        public UserDto AddAdmin(UserDto admin)
        {
            var adminUser = _context.Users.FirstOrDefault();

            if (admin != null)
            {
                _context.Admins.Add(admin);
                _context.SaveChanges();
            }

            return adminUser;
        }

        public void DeleteById(int id)
        {
            var admin = _context.Admins.FirstOrDefault(i => i.Id == id);
            if (admin != null)
            {
                _context.Admins.Remove(admin);
                _context.SaveChanges();
            }
        }
    }
}
