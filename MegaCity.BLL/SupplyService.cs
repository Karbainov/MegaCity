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
    public class SupplyService
    {
        private IMapper _mapper;
        private SupplyRepository _supplyRepository;

        public SupplyService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _supplyRepository = new SupplyRepository();
        }

        public List<StorageChangeModel> GetAllSupply()
        {
            List<StorageChangeModel> supply = new List<StorageChangeModel>()
            {
                new StorageChangeModel()
                {
                    Name = "productOne",
                    Price = 100,
                    Count=150,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new StorageChangeModel()
                {
                    Name = "productTwo",
                    Price = 200,
                    Count=60,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new StorageChangeModel()
                {
                    Name = "productThree",
                    Price = 300,
                    Count=50,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                }
            };

            return supply;
        }

        public void AddSupply(StorageChangeModel spoiled)
        {
            StorageChangeModel newSupply = new StorageChangeModel()
            {
                Name = "productTwo",
                Price = 200,
                Count = 60,
                DataWriteOff = "11/12/12",
                ReasonWriteOff = "lalala"
            };
        }

        public void DeleteSupplyById(int id)
        {
            _supplyRepository.DeleteSupplyById(id);
        }
    }
}
