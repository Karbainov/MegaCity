using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CashboxController : ControllerBase
    {
        CashboxService _cashboxService;
        Mapper _mapper;

        public CashboxController()
        {
            _cashboxService = new CashboxService();
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet]
        public IActionResult GetAllCashboxes()
        {
            List<CashboxModel> cashboxes = _cashboxService.GetAllCashboxes();

            return Ok(cashboxes);
        }

        [HttpGet("{id}")]
        public IActionResult GetCashboxById(int id)
        {
            CashboxModel cashbox = _cashboxService.GetCashboxById();

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
