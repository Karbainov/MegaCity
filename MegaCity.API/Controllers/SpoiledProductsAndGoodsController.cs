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
            SpoiledProductsAndGoodsModel spoiledModel = _mapper.Map<SpoiledProductsAndGoodsModel>(spoiled);
            _spoiledProductsAndGoodsService.AddSpoiledProductsAndGoods(spoiledModel);
            SpoiledProductsAndGoodsResponseModel newSpoiled = _mapper.Map<SpoiledProductsAndGoodsResponseModel>(spoiledModel);

            return Created(new Uri("SpoiledProductAndGoods", UriKind.Relative), newSpoiled);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSpoiledProductAndGoodsById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSpoiledProductAndGoodsById(int id, SpoiledProductsAndGoodsRequestModel spoiled)
        {
            SpoiledProductsAndGoodsModel spoiledModel = _mapper.Map<SpoiledProductsAndGoodsModel>(spoiled);
            _spoiledProductsAndGoodsService.UpdateSpoiledProductAndGoodsById(id, spoiledModel);
            SpoiledProductsAndGoodsResponseModel spoiledOutput = _mapper.Map<SpoiledProductsAndGoodsResponseModel>(spoiledModel);

            return Ok(spoiledOutput);
        }
    }
}
