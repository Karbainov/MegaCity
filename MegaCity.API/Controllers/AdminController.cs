using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        [HttpGet("All-Admins")]
        public IActionResult GetAllAdmins()
        {
            List<AdminOutputModel> admins = new List<AdminOutputModel>()
            {
                new AdminOutputModel()
                {
                    Id=5,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123456
                },

                new AdminOutputModel()
                {
                    Id=6,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123452
                },

                new AdminOutputModel()
                {
                    Id=44,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=50,
                    PhoneNumber=123458
                }
            };

            return Ok(admins);
        }

        [HttpGet("{id}")]
        public IActionResult GetAdminById(int id)
        {
            AdminOutputModel admin = new AdminOutputModel()
            {
                Id = 9,
                FirstName = "FirstName",
                LastName = "LastName",
                Age = 35,
                PhoneNumber = 123451
            };

            return Ok(admin);
        }

        [HttpPost()]
        public IActionResult AddAdmin(AdminInputModel admin)
        {
            AdminOutputModel newAdmin = new AdminOutputModel()
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
        public IActionResult UpdateAdmin(int id, AdminInputModel admin)
        {
            AdminOutputModel adminOutput = new AdminOutputModel()
            {
                Id = id,
                FirstName = admin.FirstName,
                LastName = admin.LastName
            };

            return Ok(adminOutput);
        }
    }
}
