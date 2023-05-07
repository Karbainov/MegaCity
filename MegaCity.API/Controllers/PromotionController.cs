using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        [HttpGet("All-Promotions")]
        public IActionResult GetAllPromotions()
        {
            List<PromotionOutputModel> allPromotions = new List<PromotionOutputModel>()
            {
                new PromotionOutputModel
                {
                    Name = "PromotionOne",
                    Day = 10
                },

                new PromotionOutputModel
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
            PromotionOutputModel promotion = new PromotionOutputModel()
            {
                Name = "PromotionOne",
                Month = 1,
                Description = "It is promotion for our clients"
            };

            return Ok(promotion);
        }

        [HttpPost()]
        public IActionResult AddPromotion(PromotionInputModel promotion)
        {
            PromotionInputModel newPromotion = new PromotionInputModel()
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
        public IActionResult UpdatePromotion(int id, PromotionInputModel promotion)
        {
            PromotionOutputModel promotionOutput = new PromotionOutputModel()
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
