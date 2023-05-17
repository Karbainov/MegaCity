using AutoMapper;
using MegaCity.BLL.Models;
using MegaCity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL
{
    public class CheckService
    {
        private IMapper _mapper;
        private CheckRepository _checkRepository;

        public CheckService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _checkRepository = new CheckRepository();
        }

        public List<CheckModel> GetAllChecks()
        {
            List<CheckModel> check_models = new List<CheckModel>()
            {
                new CheckModel()
                {
                    Sum = 171
                },

                new CheckModel()
                {
                    Sum = 187.50
                },
            };
            return check_models;
        }

        public CheckModel GetCheckById()
        {
            CheckModel check = new CheckModel()
            {
                Sum = 165672
            };

            return check;
        }

        public void DeleteCheckById(int id)
        {
            _checkRepository.DeleteByid(id);
        }
    }
}
