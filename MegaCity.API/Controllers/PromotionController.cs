using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllPromotions()
        {
            List<PromotionResponseModel> allPromotions = new List<PromotionResponseModel>()
            {
                new PromotionResponseModel
                {
                    Name = "PromotionOne",
                    Day = 10
                },

                new PromotionResponseModel
                {
                    Name = "PromotionTwo",
                    Month = 3
                }
            };

            return Ok(allPromotions);
        }

        [HttpGet("{id}")]
        public IActionResult GetPromotion()
        {
            PromotionResponseModel promotion = new PromotionResponseModel()
            {
                Name = "PromotionOne",
                Month = 1,
                Description = "It is promotion for our clients"
            };

            return Ok(promotion);
        }

        [HttpPost]
        public IActionResult AddPromotion(PromotionRequestModel promotion)
        {
            PromotionRequestModel newPromotion = new PromotionRequestModel()
            {
                Name = promotion.Name,
                Month = promotion.Month,
                Description = promotion.Description
            };

            return Created("newPromotion", "Promotion");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePromotionById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePromotionById(int id, PromotionRequestModel promotion)
        {
            PromotionResponseModel promotionOutput = new PromotionResponseModel()
            {
                Id = id,
                Name = promotion.Name,
                Month = promotion.Month,
                Description = promotion.Description
            };

            return Ok(promotionOutput);
        }
    }
}
