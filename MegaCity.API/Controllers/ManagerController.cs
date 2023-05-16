using AutoMapper;
using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using MegaCity.BLL;
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
    public class ManagerController : ControllerBase
    {
        ManagerService _managerService;
        Mapper _mapper;

        public ManagerController()
        {
            _managerService = new ManagerService();
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet]
        public IActionResult GetAllManagers()
        {
            List<ManagerModel> managers = _managerService.GetAllManagers();
            List<ManagerResponseModel> allManagers = _mapper.Map<List<ManagerResponseModel>>(managers);

            return Ok(allManagers);
        }

        [HttpGet("{id}")]
        public IActionResult GetManagerById(int id)
        {
            ManagerModel manager = _managerService.GetManagerById();
            ManagerResponseModel managerId = _mapper.Map<ManagerResponseModel>(manager);

            return Ok(managerId);
        }

        [HttpPost()]
        public IActionResult AddManager(ManagerRequestModel manager)
        {
            ManagerModel managerModel = _mapper.Map<ManagerModel>(manager);
            _managerService.AddManager(managerModel);

            ManagerResponseModel newManager = _mapper.Map<ManagerResponseModel>(managerModel);

            return Created(new Uri("Manager", UriKind.Relative), newManager);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteManagerById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateManagerById(int id, ManagerRequestModel manager)
        {
            ManagerModel managerModel = _mapper.Map<ManagerModel>(manager);
            _managerService.UpdateManagerById(id, managerModel);

            ManagerResponseModel managerOutput = _mapper.Map<ManagerResponseModel>(managerModel);

            return Ok(managerOutput);
        }
    }
}
