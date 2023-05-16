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
    public class CheckController : ControllerBase
    {
        CheckService _checkService;
        Mapper _mapper;

        public CheckController()
        {
            _checkService = new CheckService();
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet()]
        public IActionResult GetAllChecks()
        {
            List<CheckModel> checks = _checkService.GetAllChecks();

            return Ok(checks);
        }

        [HttpGet("{id}")]
        public IActionResult GetCheckById(int id)
        {
            CheckModel check = _checkService.GetCheckById();

            return Ok(check);
        }
    }
}
