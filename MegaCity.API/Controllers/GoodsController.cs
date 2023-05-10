using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        [HttpGet()]
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
    }
}
