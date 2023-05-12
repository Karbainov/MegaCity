using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CashboxController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllCashboxes()
        {
            List<CashboxResponseModel> cashboxes = new List<CashboxResponseModel>()
            {
                new CashboxResponseModel()
                {
                    Cash = 20000,
                    Card = 17890
                },

                new CashboxResponseModel()
                {
                    Cash = 20000,
                    Card = 17890
                }
            };
            return Ok(cashboxes);
        }

        [HttpGet("{id}")]
        public IActionResult GetCashbox()
        {
            CashboxResponseModel cashbox = new CashboxResponseModel()
            {
                Cash = 20000,
                Card = 17890
            };
            return Ok(cashbox);
        }

        [HttpPost()]
        public IActionResult AddCashbox(CashboxResponseModel cashbox)
        {
            CashboxResponseModel addCashbox = new CashboxResponseModel()
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
        public IActionResult UpdateCashboxById(int id, CashboxResponseModel cashbox)
        {
            CashboxResponseModel cashboxOutput = new CashboxResponseModel()
            {
                Cash = cashbox.Cash,
                Card = cashbox.Card
            };

            return Ok(cashboxOutput);
        }
    }
}
