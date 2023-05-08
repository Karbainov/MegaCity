using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CashboxController : ControllerBase
    {
        [HttpGet("All-Cashboxes")]
        public IActionResult GetAllCashboxes()
        {
            List<CashboxOutputModel> cashboxes = new List<CashboxOutputModel>()
            {
                new CashboxOutputModel()
                {
                    Cash = 20000,
                    Card = 17890
                },

                new CashboxOutputModel()
                {
                    Cash = 20000,
                    Card = 17890
                }
            };
            return Ok(cashboxes);
        }

        [HttpGet()]
        public IActionResult GetCashbox()
        {
            CashboxOutputModel cashbox = new CashboxOutputModel()
            {
                Cash = 20000,
                Card = 17890
            };
            return Ok(cashbox);
        }

        [HttpPost()]
        public IActionResult AddCashbox(CashboxOutputModel cashbox)
        {
            CashboxOutputModel addCashbox = new CashboxOutputModel()
            {
                Cash = cashbox.Cash,
                Card = cashbox.Card
            };

            return Created("Cashbox", "NewCashbox");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCashbox(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCashbox(int id, CashboxOutputModel cashbox)
        {
            CashboxOutputModel cashboxOutput = new CashboxOutputModel()
            {
                Cash = cashbox.Cash,
                Card = cashbox.Card
            };

            return Ok(cashboxOutput);
        }
    }
}
