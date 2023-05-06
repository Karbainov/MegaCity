using MegaCity.API.Models.OutputModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        [HttpGet("{id}")]
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

        [HttpGet("Sppiled")]
        public IActionResult GetSpoiledGoods()
        {
            List<ProductOutputModel> SpoiledGoods = new List<ProductOutputModel>()
            {
                new ProductOutputModel()
                {
                    Name = "productOne",
                    Count = 11
                },

                new ProductOutputModel()
                {
                    Name = "productTwo",
                    Count = 17
                }
            };

            return Ok(SpoiledGoods);
        }
    }
}
