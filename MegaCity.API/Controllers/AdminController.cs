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
    public class AdminController : ControllerBase
    {
        AdminService _adminService;
        Mapper _mapper;

        public AdminController()
        {
            _adminService = new AdminService();
            MapperConfiguration configuration  = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet]
        public IActionResult GetAllAdmins()
        {
            List<UserModel> admins = _adminService.GetAllAdmins();
            List<UserResponseModel> allAdmins= _mapper.Map<List<UserResponseModel>>(admins);

            return Ok(allAdmins);
        }

        [HttpGet("{id}")]
        public IActionResult GetAdminById(int id)
        {
            UserModel admin = _adminService.GetAdminById();
            UserResponseModel adminId = _mapper.Map<UserResponseModel>(admin);

            return Ok(adminId);
        }

        [HttpPost()]
        public IActionResult AddAdmin(int userId,UserRequestModel model)
        {
            UserModel adminModel = _mapper.Map<UserModel>(model);
            UserModel newAdmin = _adminService.AddAdmin(userId,adminModel);
            UserResponseModel result = _mapper.Map<UserResponseModel>(newAdmin);

            return Created(new Uri("Admin", UriKind.Relative), result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdminById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdminById(int id, UserRequestModel admin)
        {
            UserModel adminModel = _mapper.Map<UserModel>(admin);
            _adminService.UpdateAdminById(id, adminModel);
            UserResponseModel adminOutput = _mapper.Map<UserResponseModel>(adminModel);

            return Ok(adminOutput);
        }
    }
}
