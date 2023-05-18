using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< Updated upstream
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
=======
<<<<<<< HEAD
using MegaCity.API.Models.ModelsOutput;
=======
using MegaCity.API.Models.OutputModel;
>>>>>>> 1.16AddEndPointsForFilial
>>>>>>> Stashed changes

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
    }
}
