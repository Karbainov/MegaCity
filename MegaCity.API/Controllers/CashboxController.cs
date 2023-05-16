using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using System.Security.Cryptography.Xml;

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
            List<CashboxResponseModel> allCashboxes = _mapper.Map<List<CashboxResponseModel>>(cashboxes);

            return Ok(allCashboxes);
        }

        [HttpGet("{id}")]
        public IActionResult GetCashboxById(int id)
        {
            CashboxModel cashbox = _cashboxService.GetCashboxById();
            CashboxResponseModel cashboxId = _mapper.Map<CashboxResponseModel>(cashbox);

            return Ok(cashboxId);
        }

        [HttpPost()]
        public IActionResult AddCashbox(CashboxResponseModel cashbox)
        {
            CashboxModel cashboxModel = _mapper.Map<CashboxModel>(cashbox);
            _cashboxService.AddCashbox(cashboxModel);

            CashboxResponseModel newCashbox = _mapper.Map<CashboxResponseModel>(cashboxModel);

            return Created(new Uri("Cashbox", UriKind.Relative), newCashbox);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCashbox(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCashboxById(int id, CashboxResponseModel cashbox)
        {
            CashboxModel cashboxModel = _mapper.Map<CashboxModel>(cashbox);
            _cashboxService.UpdateCashboxById(id, cashboxModel);

            CashboxResponseModel cashboxOutput = _mapper.Map<CashboxResponseModel>(cashboxModel);

            return Ok(cashboxOutput);
        }
    }
}
