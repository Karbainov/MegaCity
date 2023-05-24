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
        }

        public UserDto GetManagerById(int id)
        {
            return _context.Users.FirstOrDefault(i => i.Id == id);
        }

        public UserDto AddManager(int userId,UserDto manager)
        {
            var user = _context.Users.FirstOrDefault(i => i.Id == manager.Id);
            
            if (manager != null)
            {
                UserDto newManager = new UserDto()
                {
                    FirstName = manager.FirstName,
                    LastName = manager.LastName,
                    Email = manager.Email,
                    Password = manager.Password,
                    Role = manager.Role
                };
                _context.Users.Add(newManager);
                _context.SaveChanges();

                return newManager;
            }
            else
            {
                throw new Exception("Админ не создан!");
            }
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
