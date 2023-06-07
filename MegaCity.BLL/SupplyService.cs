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
            return _mapper.Map<List<StorageChangeModel>>(_supplyRepository.GetAllSupply());
        }

        public StorageChangeModel GetSupplyById(int id)
        {
            return _mapper.Map<StorageChangeModel>(_supplyRepository.GetSupplyById(id));
        }

        public StorageChangeModel AddSupply(int userId, StorageChangeModel spoiled)
        {
            var newSupply = _mapper.Map<StorageChangeDto>(spoiled);

            return _mapper.Map<StorageChangeModel>(_supplyRepository.AddSupply(userId, newSupply));
        }

        public void DeleteSupplyById(int id)
        {
            _supplyRepository.DeleteSupplyById(id);
        }

        public StorageChangeModel UpdateSupplyById(int id, StorageChangeModel supply)
        {
            var updateSupply = _mapper.Map<StorageChangeDto>(supply);

            return _mapper.Map<StorageChangeModel>(_supplyRepository.UpdateSupplyById(id, updateSupply));
        }
    }
}
