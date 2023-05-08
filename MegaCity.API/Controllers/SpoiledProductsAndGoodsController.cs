using MegaCity.API.Models.ModelsInput;
using MegaCity.API.Models.ModelsOutput;
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

        [HttpPost()]
        public IActionResult AddSpoiledProductAndGoods(SpoiledProductAndGoodsInputModel spoiled)
        {
            SpoiledProductAndGoodsOutputModel newspoiledProductAndGoods = new SpoiledProductAndGoodsOutputModel()
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
        public IActionResult DeleteSpoiledProductAndGoods(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSpoiledProductAndGoods(int id, SpoiledProductAndGoodsInputModel spoiled)
        {
            SpoiledProductAndGoodsOutputModel spoiledProductAndGoodsOutput = new SpoiledProductAndGoodsOutputModel();
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
