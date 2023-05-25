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
            List<ManagerModel> managers = new List<ManagerModel>();
            return managers;
        }

        public ManagerModel GetManagerById()
        {
            ManagerModel manager = new ManagerModel();

            return manager;
        }

        public ManagerModel AddManager(int userId,ManagerModel manager)
        {
            var model = _mapper.Map<UserDto>(manager);
            return _mapper.Map<ManagerModel>(_managerRepository.AddManager(userId, model));
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
