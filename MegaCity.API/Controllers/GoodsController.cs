using MegaCity.API.Models;
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

        [HttpGet("{id}")]
        public IActionResult GetGoodsById(int id)
        {
            GoodsOutputModel goods = new GoodsOutputModel()
            {
                Id= id,
                Name = "Potato",
                Price = 17
            };

            return Ok("goods");
        }
    }
}
