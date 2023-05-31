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

        public void GetAllUsersByRole(string role)
        {
            _context.Users.Where(u => u.Role == role).ToList();
        }

        public UserDto GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(i => i.Id == id);
        }

        public UserDto AddUser(UserDto user)
        {
            if (user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return user;
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
            foreach (var u in _context.StorageChanges.ToList())
            {
                if (u.User.Id == id)
                {
                    u.User = null;
                }
            }
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Не удалось удалить");
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
}﻿