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

        public List<GoodsModel> GetAllgoods()
        {
            return _mapper.Map<List<GoodsModel>>(_goodsRepository.GetAllGoods());
        }

        public GoodsModel GetGoodsById(int id)
        {
            var getGoods = _goodsRepository.GetGoodsById(id);

            return _mapper.Map<GoodsModel>(getGoods);
        }

        public GoodsModel AddGoods(GoodsModel goods)
        {
            var newGoods = _mapper.Map<GoodsDto>(goods);

            return _mapper.Map<GoodsModel>(_goodsRepository.AddGoods(newGoods));
        }

        public void DeleteGoodsById(int id)
        {
            _goodsRepository.DeleteGoodsById(id);
        }

        public GoodsModel UpdateGoodsById(int id, GoodsModel goods)
        {
            var updateGoods = _mapper.Map<GoodsDto>(goods);

            return _mapper.Map<GoodsModel>(_goodsRepository.UpdateGoods(id, updateGoods));
        }
    }
}
