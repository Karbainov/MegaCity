using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using MegaCity.API.Models.RequestModels;

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
            List<CheckResponseModel> allChecks = _mapper.Map<List<CheckResponseModel>>(checks);

            return Ok(allChecks);
        }

        [HttpGet("{id}")]
        public IActionResult GetCheckById(int id)
        {
            CheckModel check = _checkService.GetCheckById();
            CheckResponseModel checkId = _mapper.Map<CheckResponseModel>(check);

            return Ok(checkId);
        }

        [HttpPost]
        public IActionResult AddCheck(int userId, CheckRequestModel check)
        {
            CheckModel checkModel = _mapper.Map<CheckModel>(check);
            CheckModel newCheck = _checkService.AddCheck(userId, checkModel);
            CheckResponseModel result = _mapper.Map<CheckResponseModel>(newCheck);

            return Created(new Uri("newCheck", UriKind.Relative), result);
        }
    }
}
