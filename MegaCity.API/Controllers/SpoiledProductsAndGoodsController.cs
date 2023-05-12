using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SpoiledProductsAndGoodsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllSpoiledProductAndGoods()
        {
            List<SpoiledProductAndGoodsResponseModel> spoiled = new List<SpoiledProductAndGoodsResponseModel>()
            {
                new SpoiledProductAndGoodsResponseModel()
                {
                    Id=5,
                    Name = "productOne",
                    Price = 100,
                    Count=150,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductAndGoodsResponseModel()
                {
                    Id=8,
                    Name = "productTwo",
                    Price = 200,
                    Count=60,
                    DataWriteOff="11/12/12",
                    ReasonWriteOff="lalala"
                },

                new SpoiledProductAndGoodsResponseModel()
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

        [HttpPost]
        public IActionResult AddSpoiledProductAndGoods(SpoiledProductAndGoodsRequestModel spoiled)
        {
            SpoiledProductAndGoodsResponseModel newspoiledProductAndGoods = new SpoiledProductAndGoodsResponseModel()
            {
                Id = 9,
                Name = "productTwo",
                Price = 200,
                Count = 60,
                DataWriteOff = "11/12/12",
                ReasonWriteOff = "lalala"
            };

            return Created(new Uri("SpoiledProductAndGoods", UriKind.Relative), newspoiledProductAndGoods);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSpoiledProductAndGoodsById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSpoiledProductAndGoodsById(int id, SpoiledProductAndGoodsRequestModel spoiled)
        {
            SpoiledProductAndGoodsResponseModel spoiledProductAndGoodsOutput = new SpoiledProductAndGoodsResponseModel();
            {
                int Id = id;
                string Name = spoiled.Name;
                double price = spoiled.Price;
                int Count = spoiled.Count;
                string DataWriteOff = spoiled.DataWriteOff;
                string ReasonWriteOff = spoiled.ReasonWriteOff;
            }

            return Ok(spoiledProductAndGoodsOutput);
        }
    }
}
