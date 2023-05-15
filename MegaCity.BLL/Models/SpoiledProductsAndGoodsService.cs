using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class SpoiledProductsAndGoodsService
    {
        public List<SpoiledProductsAndGoodsModel> GetAllSpoiledProductsAndGoods()
        {
            List<SpoiledProductsAndGoodsModel> spoiled = new List<SpoiledProductsAndGoodsModel>()
            {
                new SpoiledProductsAndGoodsModel()
                {
                    Id=5,
                    Name = "productOne",
                    Price = 100,
                    Count=150,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductsAndGoodsModel()
                {
                    Id=8,
                    Name = "productTwo",
                    Price = 200,
                    Count=60,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductsAndGoodsModel()
                {
                    Id=3,
                    Name = "productThree",
                    Price = 300,
                    Count=50,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                }
            };

            return spoiled;
        }
    }
}
