using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;

namespace MegaCity.BLL
{
    public class ManagerService
    {
        public List<ManagerModel> GetAllManagers()
        {
            List<ManagerModel> managers = new List<ManagerModel>()
            {
                new ManagerModel()
                {
                    Id=5,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123456
                },

                new ManagerModel()
                {
                    Id=6,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123452
                },

                new ManagerModel()
                {
                    Id=44,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123458
                }
            };

            return managers;
        }

        public ManagerModel GetManagerById()
        {
            ManagerModel manager = new ManagerModel()
            {
                Id = 9,
                FirstName = "FirstName",
                LastName = "LastName",
                Age = 150,
                PhoneNumber = 123451
            };

            return manager;
        }

        public void AddManager(ManagerModel manager)
        {
            ManagerModel addManager = new ManagerModel()
            {
                FirstName = manager.FirstName,
                LastName = manager.LastName
            };
        }

        public void UpdateManagerById(int id, ManagerModel manager)
        {
            ManagerModel managerOutput = new ManagerModel()
            {
                FirstName = manager.FirstName,
                LastName = manager.LastName,
                PhoneNumber = manager.PhoneNumber,
                Email = manager.Email
            };
        }
    }
}
