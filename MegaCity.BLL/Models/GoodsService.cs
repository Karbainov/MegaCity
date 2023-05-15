using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
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
    }
}
