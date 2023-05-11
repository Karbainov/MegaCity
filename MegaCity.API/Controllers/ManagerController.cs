using MegaCity.API.Models.ModelsInput;
using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        [HttpGet("All-Managers")]
        public IActionResult GetAllManagers()
        {
            List<ManagerResponseModel> managers = new List<ManagerResponseModel>()
            {
                new ManagerResponseModel()
                {
                    Id=5,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123456
                },

                new ManagerResponseModel()
                {
                    Id=6,
                    FirstName = "FirstName",
                    LastName = "LastName",
                    Age=150,
                    PhoneNumber=123452
                },

                new ManagerResponseModel()
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
            ManagerResponseModel manager = new ManagerResponseModel()
            {
                Id = 9,
                FirstName = "FirstName",
                LastName = "LastName",
                Age = 150,
                PhoneNumber = 123451
            };

            return Ok(manager);
        }

        [HttpPost()]
        public IActionResult AddManager(ManagerRequestModel manager)
        {
            ManagerResponseModel addManager = new ManagerResponseModel()
            {
                FirstName = manager.FirstName,
                LastName = manager.LastName
            };

            return Created("Manager", "NewManager");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteManagerById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateManager(int id, ManagerRequestModel manager)
        {
            ManagerResponseModel managerOutput = new ManagerResponseModel()
            {
                FirstName = manager.FirstName,
                LastName = manager.LastName,
                PhoneNumber = manager.PhoneNumber,
                Email = manager.Email
            };

            return Ok(managerOutput);
        }
    }
}
