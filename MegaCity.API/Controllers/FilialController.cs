using MegaCity.API.Models.InputModels;
using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilialController : ControllerBase
    {
        [HttpGet("All-Filial")]
        public IActionResult GetAllFilials()
        {
            List<FilialResponseModel> filials = new List<FilialResponseModel>()
            {
                new FilialResponseModel()
                {
                    Id=1,
                    Adress="Nizami str.68"
                },
            };
            return Ok(filials);
        }

        [HttpGet("{id}")]
        public IActionResult GetFilialbyId()
        {
            FilialResponseModel filial = new FilialResponseModel();
            {
                string Adress = "Heydar A.str.str.10";
            };

            return Ok(filial);
        }
        [HttpPost()]
        public IActionResult AddFilialbiId(FilialRequestModel filial1)
        {
            FilialResponseModel filial = new FilialResponseModel
            {
                Id = filial1.Id,
                Adress = filial1.Adress,
            };

            return Ok(filial);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFilialById(int id)
        {
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateFilialbyId(int id, FilialRequestModel filial1)
        {
            FilialResponseModel OutPutfilial = new FilialResponseModel
            {
                Id = filial1.Id,
                Adress = filial1.Adress,

            };

            return Ok(OutPutfilial);
        }

    }
}