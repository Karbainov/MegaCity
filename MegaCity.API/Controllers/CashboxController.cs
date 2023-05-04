using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashboxController : ControllerBase
    {
        [HttpGet("cashbox")]
        public IActionResult GetCashbox()
        {
            CashboxOutputModel cashbox = new CashboxOutputModel()
            {
                Cash = 20000,
                Card = 17890
            };
            return Ok(cashbox);
        }
    }
}
