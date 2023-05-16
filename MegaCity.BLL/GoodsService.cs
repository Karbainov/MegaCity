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

        public GoodsModel GetGoodsById(int id)
        {
            return _mapper.Map<GoodsModel>(_goodsRepository.GetGoodsById(id));

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

        public GoodsModel AddGoods(int productId,GoodsModel goodsModel)
        {
            var goods = _mapper.Map<GoodsDto>(goodsModel);
            return _mapper.Map<GoodsModel>(_goodsRepository.AddGoods(productId, goods));
        }
    }
}
