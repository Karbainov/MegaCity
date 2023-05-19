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
        private SpoiledProductsAndGoodsRepository _spoiledProductsAndGoodsRepository;

        public WriteOffService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _spoiledProductsAndGoodsRepository = new SpoiledProductsAndGoodsRepository();
        }

        public List<WriteOffModel> GetAllSpoiledProductsAndGoods()
        {
            List<WriteOffModel> spoiled = new List<WriteOffModel>()
            {
                new WriteOffModel()
                {
                    Name = "productOne",
                    Price = 100,
                    Count=150,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new WriteOffModel()
                {
                    Name = "productTwo",
                    Price = 200,
                    Count=60,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new WriteOffModel()
                {
                    Name = "productThree",
                    Price = 300,
                    Count=50,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                }
            };

            return spoiled;
        }

        public void AddSpoiledProductsAndGoods(WriteOffModel spoiled)
        {
            WriteOffModel newspoiledProductAndGoods = new WriteOffModel()
            {
                Name = "productTwo",
                Price = 200,
                Count = 60,
                DataWriteOff = "11/12/12",
                ReasonWriteOff = "lalala"
            };
        }

        public void UpdateSpoiledProductAndGoodsById(int id, WriteOffModel spoiled)
        {
            WriteOffModel spoiledProductAndGoodsOutput = new WriteOffModel();
            {
                string Name = spoiled.Name;
                double price = spoiled.Price;
                int Count = spoiled.Count;
                string DataWriteOff = spoiled.DataWriteOff;
                string ReasonWriteOff = spoiled.ReasonWriteOff;
            };
        }

        public void DeleteById(int id)
        {
            _spoiledProductsAndGoodsRepository.DeleteSpoiledProductsAndGoodsById(id);
        }
    }
}
