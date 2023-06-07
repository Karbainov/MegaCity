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
            List<StorageChangeModel> supply = new List<StorageChangeModel>();

            return supply;
        }

        public StorageChangeModel GetSupplyById()
        {
            StorageChangeModel storageChange = new StorageChangeModel();

            return storageChange;
        }

        public StorageChangeModel AddSupply(StorageChangeModel spoiled)
        {
            StorageChangeModel newSupply = new StorageChangeModel();

            return newSupply;
        }

        public void DeleteSupplyById(int id)
        {
            _supplyRepository.DeleteSupplyById(id);
        }

        public StorageChangeModel UpdateSupplyById(StorageChangeModel supply)
        {
            return (supply);
        }
    }
}
