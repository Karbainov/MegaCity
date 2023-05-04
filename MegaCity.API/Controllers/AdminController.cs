using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        [HttpGet()]
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
    }
}
