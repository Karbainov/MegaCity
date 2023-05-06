using MegaCity.API.Models.OutputModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SpoiledProductsAndGoodsController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetAllSpoiledProductAndGoods()
        {
            List<SpoiledProductAndGoodsOutputModel> spoiled = new List<SpoiledProductAndGoodsOutputModel>()
            {
                new SpoiledProductAndGoodsOutputModel()
                {
                    Id=5,
                    Name = "productOne",
                    Price = 100,
                    Count=150,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductAndGoodsOutputModel()
                {
                    Id=8,
                    Name = "productTwo",
                    Price = 200,
                    Count=60,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductAndGoodsOutputModel()
                {
                    Id=3,
                    Name = "productThree",
                    Price = 300,
                    Count=50,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                }
            };
            return Ok(spoiled);
        }
    }
}
