using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilialController : ControllerBase
    {
        [HttpGet("{id}")]
        public  IActionResult GetAllFilials()
        {
            List<FilialOutputModel> filials = new List<FilialOutputModel>()
            {
                new FilialOutputModel()
                {
                    Id=1,
                    Adress="Nizami str.68"
                },
            };
            return Ok(filials);
        }
    }
}
