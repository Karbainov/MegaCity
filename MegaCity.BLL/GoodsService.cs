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

        public List<GoodsModel> GetGoodsById()
        {
            List<GoodsModel> goods = new List<GoodsModel>();
            return goods;
        }

        public void UpdateGoodsById(int id, GoodsModel goods)
        {
            GoodsModel goodsOutput = new GoodsModel();
        }

        public void DeleteGoodsById(int id)
        {
            _goodsRepository.DeleteGoodsById(id);
        }

        public GoodsModel AddGoods(List<ComponentModel> components)
        {
            GoodsDto goodsDto = new GoodsDto();

            var newGoodsDto = _goodsRepository.AddProduct(goodsDto);

            if (newGoodsDto != null)
            {
                foreach (var component in components)
                {
                    _goodsRepository.AddComponent(component.Count, component.GoodsId, component.ProductId);
                }

                GoodsModel newGoods = _mapper.Map<GoodsModel>(newGoodsDto);

                return newGoods;
            }
            else
            {
                throw new Exception("Продукт не создан!");
            }
        }
    }
}
