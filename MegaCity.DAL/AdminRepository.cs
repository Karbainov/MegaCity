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
            _context.Users.ToList();
        }

        public UserDto GetAdminById(int id)
        {
            return _context.Users.FirstOrDefault(i => i.Id == id);
        }

        public UserDto AddAdmin(UserDto admin)
        {
            if (admin != null)
            {
                UserDto newAdmin = new UserDto()
                {
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Email = admin.Email,
                    Password = admin.Password,
                    Role = admin.Role
                };
                _context.Users.Add(newAdmin);
                _context.SaveChanges();

                return newAdmin;
            }
            else
            {
                throw new Exception("Админ не создан!");
            }
        }

        public void DeleteById(int id)
        {
            var admin = _context.Users.FirstOrDefault(i => i.Id == id);
            if (admin != null)
            {
                _context.Users.Remove(admin);
                _context.SaveChanges();
            }
        }
    }
}
