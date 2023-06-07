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

        [HttpGet("{id}")]
        public IActionResult GetSupplyById(int id)
        {
            var a = _supplyService.GetSupplyById();
            var supply = _mapper.Map<StorageChangeResponseModel>(a);

            return Ok(supply);
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
        public IActionResult DeleteWriteOffById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSupplyById(int id, StorageChangeRequestModel supply)
        {
            StorageChangeModel storageChangeModel = _mapper.Map<StorageChangeModel>(supply);
            storageChangeModel.Id = id;
            StorageChangeModel newSupply = _supplyService.UpdateSupplyById(storageChangeModel);
            StorageChangeResponseModel supplyOut = _mapper.Map<StorageChangeResponseModel>(newSupply);

            return Ok(supply);
        }
    }
}
