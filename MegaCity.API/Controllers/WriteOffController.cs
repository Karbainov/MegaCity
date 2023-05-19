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
    public class WriteOffController : ControllerBase
    {
        WriteOffService _spoiledProductsAndGoodsService;
        Mapper _mapper;

        public WriteOffController()
        {
            _spoiledProductsAndGoodsService = new WriteOffService();
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperApiProfile());
            });
            _mapper = new Mapper(configuration);
        }
         [HttpGet]
        public IActionResult GetAllSpoiledProductsAndGoods()
        {
            List<WriteOffModel> spoiledProductsAndGoods = _spoiledProductsAndGoodsService.GetAllSpoiledProductsAndGoods();
            List<WriteOffResponseModel> SpoiledProductAndGoods = _mapper.Map<List<WriteOffResponseModel>>(spoiledProductsAndGoods);

            return Ok(SpoiledProductAndGoods);
        }

        [HttpPost]
        public IActionResult AddSpoiledProductsAndGoods(WriteOffRequestModel spoiled)
        {
            WriteOffModel spoiledModel = _mapper.Map<WriteOffModel>(spoiled);
            _spoiledProductsAndGoodsService.AddSpoiledProductsAndGoods(spoiledModel);
            WriteOffResponseModel newSpoiled = _mapper.Map<WriteOffResponseModel>(spoiledModel);

            return Created(new Uri("SpoiledProductAndGoods", UriKind.Relative), newSpoiled);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSpoiledProductAndGoodsById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSpoiledProductAndGoodsById(int id, WriteOffRequestModel spoiled)
        {
            WriteOffModel spoiledModel = _mapper.Map<WriteOffModel>(spoiled);
            _spoiledProductsAndGoodsService.UpdateSpoiledProductAndGoodsById(id, spoiledModel);
            WriteOffResponseModel spoiledOutput = _mapper.Map<WriteOffResponseModel>(spoiledModel);

            return Ok(spoiledOutput);
        }
    }
}
