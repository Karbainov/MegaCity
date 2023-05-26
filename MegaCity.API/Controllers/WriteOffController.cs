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
using Microsoft.EntityFrameworkCore.Query;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WriteOffController : ControllerBase
    {
        WriteOffService _writeOffService;
        Mapper _mapper;

        public WriteOffController()
        {
            _writeOffService = new WriteOffService();
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperApiProfile());
            });
            _mapper = new Mapper(configuration);
        }
         [HttpGet]
        public IActionResult GetAllWriteOffByDate()
        {
            List<StorageChangeModel> writeOff = _writeOffService.GetAllWriteOffByDate();
            List<StorageChangeResponseModel> newWriteOff = _mapper.Map<List<StorageChangeResponseModel>>(writeOff);

            return Ok(newWriteOff);
        }

        [HttpPost]
        public IActionResult AddWriteOff(StorageChangeRequestModel writeOff)
        {
            StorageChangeModel writeOffModel = _mapper.Map<StorageChangeModel>(writeOff);
            _writeOffService.AddWriteOff(writeOffModel);
            StorageChangeResponseModel result = _mapper.Map<StorageChangeResponseModel>(writeOffModel);

            return Created(new Uri("SpoiledProductAndGoods", UriKind.Relative), result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSpoiledProductAndGoodsById(int id)
        {
            return NoContent();
        }
    }
}
