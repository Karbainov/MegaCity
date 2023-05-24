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
    public class WriteOffService
    {
        private IMapper _mapper;
        private WriteOffRepository _writeOffRepository;

        public WriteOffService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _writeOffRepository = new WriteOffRepository();
        }

        public List<StorageChangeModel> GetAllWriteOff()
        {
            List<StorageChangeModel> writeOff = new List<StorageChangeModel>();

            return writeOff;
        }

        public void AddWriteOff(StorageChangeModel spoiled)
        {
            StorageChangeModel newWriteOff = new StorageChangeModel();
        }

        public void DeleteWriteOffById(int id)
        {
            _writeOffRepository.DeleteWriteOffById(id);
        }
    }
}
