using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;

namespace MegaCity.BLL
{
    public class PromotionService
    {
        public List<PromotionModel> GetAllPromotions()
        {
            List<PromotionModel> allPromotions = new List<PromotionModel>()
            {
                new PromotionModel
                {
                    Name = "PromotionOne",
                    Day = 10
                },

                new PromotionModel
                {
                    Name = "PromotionTwo",
                    Month = 3
                }
            };

            return allPromotions;
        }

        public PromotionModel GetPromotionById()
        {

            PromotionModel promotion = new PromotionModel()
            {
                Name = "PromotionOne",
                Month = 1,
                Description = "It is promotion for our clients"
            };

            return promotion;
        }

        public void AddPromotion(PromotionModel promotion)
        {
            PromotionModel newPromotion = new PromotionModel()
            {
                Name = promotion.Name,
                Month = promotion.Month,
                Description = promotion.Description
            };
        }
    }
}
