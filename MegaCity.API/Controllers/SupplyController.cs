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
    public class SupplyController : ControllerBase
    {
        SupplyService _supplyService;
        Mapper _mapper;

        public SupplyController()
        {
            _supplyService = new SupplyService();
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperApiProfile());
            });
            _mapper = new Mapper(configuration);
        }
         [HttpGet]
        public IActionResult GetAllSupply()
        {
            List<StorageChangeModel> supply = _supplyService.GetAllSupply();
            List<StorageChangeResponseModel> newSupply = _mapper.Map<List<StorageChangeResponseModel>>(supply);

            return Ok(newSupply);
        }

        [HttpPost]
        public IActionResult AddSupply(StorageChangeRequestModel spoiled)
        {
            StorageChangeModel spoiledModel = _mapper.Map<StorageChangeModel>(spoiled);
            _supplyService.AddSupply(spoiledModel);
            StorageChangeResponseModel newSpoiled = _mapper.Map<StorageChangeResponseModel>(spoiledModel);

            return Created(new Uri("SpoiledProductAndGoods", UriKind.Relative), newSpoiled);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSpoiledProductAndGoodsById(int id)
        {
            return NoContent();
        }
    }
}
