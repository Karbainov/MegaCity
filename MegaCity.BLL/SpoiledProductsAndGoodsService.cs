using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;

namespace MegaCity.BLL
{
    public class SpoiledProductsAndGoodsService
    {
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
    }
}
