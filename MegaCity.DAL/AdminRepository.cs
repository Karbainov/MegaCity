using System;
using System.Collections.Generic;
using System.Linq;
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

        public AdminDto GetAdminById(int id)
        {
            return _context.Admins.FirstOrDefault(i => i.Id == id);
        }

        public void AddAdmin(AdminDto admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {

        }
    }
}
