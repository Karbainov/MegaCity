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
            List<FilialResponseModel> allFilials = _mapper.Map<List<FilialResponseModel>>(filials);

            return Ok(allFilials);
        }

        [HttpGet("{id}")]
        public IActionResult GetFilialbyId(int id)
        {
            FilialModel filial = _filialService.GetFilialById();
            FilialResponseModel filialId = _mapper.Map<FilialResponseModel>(filial);

            return Ok(filialId);
        }

        [HttpPost()]
        public IActionResult AddFilialbiId(FilialRequestModel filial)
        {
            FilialModel filialModel = _mapper.Map<FilialModel>(filial);
            _filialService.AddFilial(filialModel);

            FilialResponseModel newFilial = _mapper.Map<FilialResponseModel>(filialModel);

            return Created(new Uri("Filial", UriKind.Relative), newFilial);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFilialById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFilialbyId(int id, FilialRequestModel filial)
        {
            FilialModel filialModel = _mapper.Map<FilialModel>(filial);
            _filialService.UpdateFilialById(id, filialModel);

            FilialResponseModel filialOutput = _mapper.Map<FilialResponseModel>(filialModel);

            return Ok(filialOutput);
        }
    }
}