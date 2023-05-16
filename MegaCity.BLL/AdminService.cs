using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;

namespace MegaCity.BLL
{
    public class AdminService
    {
        public List<AdminModel> GetAllAdmins()
        {
            List<AdminModel> admins = new List<AdminModel>()
            {
                new AdminModel()
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123456
                },

                new AdminModel()
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123452
                },

                new AdminModel()
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=50,
                    PhoneNumber=123458
                }
            };

            return admins;
        }

        public AdminModel GetAdminById()
        {
            AdminModel admin = new AdminModel()
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Age = 35,
                PhoneNumber = 123451
            };

            return admin;
        }
    }
}
