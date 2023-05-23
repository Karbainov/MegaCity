﻿using System;
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
            List<StorageChangeModel> writeOff = new List<StorageChangeModel>()
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

            return writeOff;
        }

        public void AddWriteOff(StorageChangeModel spoiled)
        {
            StorageChangeModel newWriteOff = new StorageChangeModel()
            {
                Name = "productTwo",
                Price = 200,
                Count = 60,
                DataWriteOff = "11/12/12",
                ReasonWriteOff = "lalala"
            };
        }

        public void DeleteWriteOffById(int id)
        {
            _writeOffRepository.DeleteWriteOffById(id);
        }
    }
}
