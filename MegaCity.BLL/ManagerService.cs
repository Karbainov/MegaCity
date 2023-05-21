using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MegaCity.BLL.Models;
using MegaCity.DAL;
using MegaCity.DAL.Dots;

namespace MegaCity.BLL
{
    public class ManagerService
    {
        private IMapper _mapper;
        private ManagerRepository _managerRepository;

        public ManagerService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _managerRepository = new ManagerRepository();
        }

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

        public ManagerModel AddManager(ManagerModel manager)
        {
            UserDto managerDto = new UserDto();

            var managerUser = _managerRepository.AddManager(managerDto);

            if (managerUser != null)
            {
                ManagerModel newManagerUser = _mapper.Map<ManagerModel>(managerUser);

                return newManagerUser;
            }
            else
            {
                throw new Exception("Админ не создан!");
            }
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

        public void DeleteManagerById(int id)
        {
            _managerRepository.DeleteMnaagerById(id);
        }
    }
}
