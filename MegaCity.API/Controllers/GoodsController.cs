using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        [HttpGet("All-Goods")]
        public IActionResult GetAllGoods()
        {
            List<GoodsOutputModel> allGoods = new List<GoodsOutputModel>
            {
                new GoodsOutputModel
                {
                    Name = "goodsOne",
                    Price = 12.6
                },

                new GoodsOutputModel
                {
                    Name = "goodsTwo",
                    Price = 19
                }
            };

            return Ok(allGoods);
        }

        [HttpGet("goods")]
        public IActionResult GetGoods()
        {
            GoodsOutputModel goods = new GoodsOutputModel()
            {
                Name = "Potato",
                Price = 17
            };

            return Ok("goods");
        }
    }
}
