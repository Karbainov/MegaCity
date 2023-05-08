using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.API.Models.ModelsOutput;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetAllChecks()
        {
            List<CheckOutputModel> check_models = new List<CheckOutputModel>()
            {
                new CheckOutputModel()
                {
                    Sum = 171
                },

                new CheckOutputModel()
                {
                    Sum = 187.50
                },
            };
            return Ok(check_models);
        }
    }
}
