using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using MegaCity.API.Models.RequestModels;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SpoiledProductsAndGoodsController : ControllerBase
    {
        SpoiledProductsAndGoodsService _spoiledProductsAndGoodsService;
        Mapper _mapper;

        public SpoiledProductsAndGoodsController()
        {
            _spoiledProductsAndGoodsService = new SpoiledProductsAndGoodsService();

            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperApiProfile());
            });
            _mapper = new Mapper(configuration);
        }
         [HttpGet]
        public IActionResult GetAllSpoiledProductsAndGoods()
        {
            List<SpoiledProductsAndGoodsModel> spoiledProductsAndGoods = _spoiledProductsAndGoodsService.GetAllSpoiledProductsAndGoods();
            List<SpoiledProductsAndGoodsResponseModel> SpoiledProductAndGoods = _mapper.Map<List<SpoiledProductsAndGoodsResponseModel>>(spoiledProductsAndGoods);
            return Ok(SpoiledProductAndGoods);
        }

        [HttpPost]
        public IActionResult AddSpoiledProductsAndGoods(SpoiledProductsAndGoodsRequestModel spoiled)
        {
            SpoiledProductsAndGoodsResponseModel newspoiledProductAndGoods = new SpoiledProductsAndGoodsResponseModel()
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
        public IActionResult UpdateSpoiledProductAndGoodsById(int id, SpoiledProductsAndGoodsRequestModel spoiled)
        {
            SpoiledProductsAndGoodsResponseModel spoiledProductAndGoodsOutput = new SpoiledProductsAndGoodsResponseModel();
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
