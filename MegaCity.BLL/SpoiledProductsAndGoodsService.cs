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
    public class SpoiledProductsAndGoodsService
    {
        private IMapper _mapper;
        private SpoiledProductsAndGoodsRepository _spoiledProductsAndGoodsRepository;

        public SpoiledProductsAndGoodsService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _spoiledProductsAndGoodsRepository = new SpoiledProductsAndGoodsRepository();
        }

        public List<SpoiledProductsAndGoodsModel> GetAllSpoiledProductsAndGoods()
        {
            List<SpoiledProductsAndGoodsModel> spoiled = new List<SpoiledProductsAndGoodsModel>()
            {
                new SpoiledProductsAndGoodsModel()
                {
                    Name = "productOne",
                    Price = 100,
                    Count=150,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductsAndGoodsModel()
                {
                    Name = "productTwo",
                    Price = 200,
                    Count=60,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductsAndGoodsModel()
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

        public void AddSpoiledProductsAndGoods(SpoiledProductsAndGoodsModel spoiled)
        {
            SpoiledProductsAndGoodsModel newspoiledProductAndGoods = new SpoiledProductsAndGoodsModel()
            {
                Name = "productTwo",
                Price = 200,
                Count = 60,
                DataWriteOff = "11/12/12",
                ReasonWriteOff = "lalala"
            };
        }

        public void UpdateSpoiledProductAndGoodsById(int id, SpoiledProductsAndGoodsModel spoiled)
        {
            SpoiledProductsAndGoodsModel spoiledProductAndGoodsOutput = new SpoiledProductsAndGoodsModel();
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
