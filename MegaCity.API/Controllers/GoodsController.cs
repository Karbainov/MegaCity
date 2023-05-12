using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.RequestModels;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllGoods()
        {
            List<GoodsResponseModel> allGoods = new List<GoodsResponseModel>
            {
                new GoodsResponseModel
                {
                    Name = "goodsOne",
                    Price = 12.6
                },

                new GoodsResponseModel
                {
                    Name = "goodsTwo",
                    Price = 19
                }
            };

            return Ok(allGoods);
        }

        [HttpGet("{id}")]
        public IActionResult GetGoodsById(int id)
        {
            GoodsResponseModel goods = new GoodsResponseModel()
            {
                Id= id,
                Name = "Potato",
                Price = 17
            };

            return Ok("goods");
        }

        [HttpPost()]
        public IActionResult AddGoods(GoodsRequestModel model)
        {
            GoodsResponseModel goods = new GoodsResponseModel()
            {
                Name = model.Name,
                Price = model.Price,
                Count = model.Count
            };

            return Created("Goods", "NewGoods");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGoodsById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateGoodsById(int id, GoodsRequestModel goods)
        {
            GoodsResponseModel modelOutput = new GoodsResponseModel()
            {
                Name = goods.Name,
                Price = goods.Price,
                Count = goods.Count
            };

            return Ok(modelOutput);
        }
    }
}
