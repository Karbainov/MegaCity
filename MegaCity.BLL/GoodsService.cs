﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;

namespace MegaCity.BLL
{
    public class GoodsService
    {
        public List<GoodsModel> GetAllGoods()
        {
            List<GoodsModel> goods = new List<GoodsModel>
            {
                new GoodsModel
                {
                    Name = "goodsOne",
                    Price = 12.6
                },

                new GoodsModel
                {
                    Name = "goodsTwo",
                    Price = 19
                }
            };

            return goods;
        }

        public GoodsModel GetGoodsById()
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
