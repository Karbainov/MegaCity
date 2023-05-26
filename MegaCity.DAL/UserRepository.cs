using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class UserRepository
    {
        private MegaCityDbContext _context;

        public UserRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllUsers()
        {
            _context.Users.ToList();
        }

        public UserDto GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(i => i.Id == id);
        }

        public UserDto AddUser(int userId, UserDto admin)
        {
            var user = _context.Users.FirstOrDefault(i => i.Id == admin.Id);
            
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

        public void DeleteUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(i => i.Id == id);

            foreach (var o in _context.Orders.ToList())
            {
                if (o.User.Id == id)
                {
                    o.User = null;
                }
            }
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public UserDto UpdateUserById(int id, UserDto user)
        {
            var userId = _context.Users.FirstOrDefault(i => i.Id == user.Id);

            if (userId != null)
            {
                userId.FirstName = user.FirstName;
                userId.LastName = user.LastName;
                userId.Email = user.Email;
                userId.Password = user.Password;
                userId.Role = user.Role;

                _context.SaveChanges();

                return userId;
            }
            else
            {
                throw new Exception("Не удалось изменить!");
            }
        }
    }
}
