using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetAllManagers()
        {
            List<ManagerOutputModel> managers = new List<ManagerOutputModel>()
            {
                new ManagerOutputModel()
                {
                    Id=5,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123456
                },

                new ManagerOutputModel()
                {
                    Id=6,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123452
                },

                new ManagerOutputModel()
                {
                    Id=44,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123458
                }
            };

            return Ok(managers);
        }

        [HttpGet("{id}")]
        public IActionResult GetManagerById(int id)
        {
            ManagerOutputModel manager = new ManagerOutputModel()
            {
                Id = 9,
                FirstName = "FirstName",
                LastName = "LastName",
                Age = 150,
                PhoneNumber = 123451
            };

            return Ok(manager);
        }
    }
}
