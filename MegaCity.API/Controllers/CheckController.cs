using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        [HttpGet()]
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

        [HttpGet("{id}")]
        public IActionResult GetCheck(int id)
        {
            CheckResponseModel check = new CheckResponseModel()
            {
                Sum = 165672
            };

            return Ok(check);
        }
    }
}
