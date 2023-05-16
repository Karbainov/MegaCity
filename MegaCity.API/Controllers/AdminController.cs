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
            List<AdminModel> admins = _adminService.GetAllAdmins();

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAdminById(int id)
        {
            AdminModel admin = _adminService.GetAdminById();

            return Ok(admin);
        }

        [HttpPost()]
        public IActionResult AddAdmin(AdminRequestModel admin)
        {
            AdminResponseModel newAdmin = new AdminResponseModel()
            {
                Id = 9,
                FirstName = admin.FirstName,
                LastName = admin.LastName
            };

            return Created("Admin", "NewAdmin");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdminById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdminById(int id, AdminRequestModel admin)
        {
            AdminResponseModel adminOutput = new AdminResponseModel()
            {
                Id = id,
                FirstName = admin.FirstName,
                LastName = admin.LastName
            };

            return Ok(adminOutput);
        }
    }
}
