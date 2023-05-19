using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;
using AutoMapper;
using MegaCity.DAL;
using MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

namespace MegaCity.BLL
{
    public class GoodsService
    {

        private IMapper _mapper;
        private GoodsRepository _goodsRepository;

        public GoodsService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _goodsRepository = new GoodsRepository();
        }

        public List<GoodsModel> GetAllGoods()
        {
            /// return _mapper.Map<GoodsModel>(_goodsRepository.());
            return null;
        }

        public GoodsModel UpdateGoods(GoodsModel goodsModel)
        {
            var goods = _mapper.Map<GoodsDto>(goodsModel);
            return _mapper.Map<GoodsModel>(_goodsRepository.UpdateGoods(goods));
        }

        public void DeleteGoodsById(int id)
        {
            _goodsRepository.DeleteGoodsById(id);
        }

        public GoodsModel AddGoods(int userId, GoodsModel goodsModel)
        {
            var goods = _mapper.Map<GoodsDto>(goodsModel);
            return _mapper.Map<GoodsModel>(_goodsRepository.AddGoods(userId, goods));
        }

        public GoodsModel GetGoodsById(int id)
        {
            GoodsModel goods = new GoodsModel()
            {
                Name = "Potato",
                Price = 17
            };

            return goods;
        }

        public void AddGoods(GoodsModel model)
        {
            GoodsModel goods = new GoodsModel()
            {
                Name = model.Name,
                Price = model.Price,
                Count = model.Count
            };
        }

        public void UpdateGoodsById(int id, GoodsModel goods)
        {
            GoodsModel modelOutput = new GoodsModel()
            {
                Name = goods.Name,
                Price = goods.Price,
                Count = goods.Count
            };
        }
    }
}
