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
            List<CheckResponseModel> check_models = new List<CheckResponseModel>()
            {
                new CheckResponseModel()
                {
                    Sum = 171
                },

                new CheckResponseModel()
                {
                    Sum = 187.50
                },
            };
            return Ok(check_models);
        }
    }
}
