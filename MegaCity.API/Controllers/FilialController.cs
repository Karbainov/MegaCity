using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilialController : ControllerBase
    {
        FilialService _filialService;
        Mapper _mapper;

        public FilialController()
        {
            _filialService = new FilialService();
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet]
        public IActionResult GetAllFilials()
        {
            List<FilialModel> filials = _filialService.GetAllFilials();

            return Ok(filials);
        }

        [HttpGet("{id}")]
        public IActionResult GetFilialbyId(int id)
        {
            FilialModel filial = _filialService.GetFilialById();

            return Ok(filial);
        }

        [HttpPost()]
        public IActionResult AddFilialbiId(FilialRequestModel filial)
        {
            FilialResponseModel filialModel = new FilialResponseModel
            {
                Name = filial.Name,
                Adress = filial.Adress
            };

            return Ok(filialModel);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFilialById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFilialbyId(int id, FilialRequestModel filial)
        {
            FilialResponseModel OutPutfilial = new FilialResponseModel
            {
                Name = filial.Name,
                Adress = filial.Adress

            };

            return Ok(OutPutfilial);
        }
    }
}