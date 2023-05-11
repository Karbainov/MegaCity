using MegaCity.API.Models.ModelsInput;
using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        [HttpGet("All-Menu")]
        public IActionResult GetAllMenu()
        {
            List<MenuResponseModel> allMenu = new List<MenuResponseModel>()
            {
                new MenuResponseModel()
                {
                    Name = "MenuOne",
                    Consist = "",
                    Portion = 1
                },

                new MenuResponseModel()
                {
                    Name = "MenuTwo",
                    Consist = "",
                    Portion = 2
                }
            };

            return Ok(allMenu);
        }

        [HttpGet()]
        public IActionResult GetMenu()
        {
            MenuResponseModel menu = new MenuResponseModel()
            {
                Name = "MenuOne",
                Consist = "",
                Portion = 1
            };

            return Ok(menu);
        }

        [HttpPost()]
        public IActionResult AddMenu(MenuRequestModel menu)
        {
            MenuResponseModel newModel = new MenuResponseModel()
            {
                Name = menu.Name,
                Consist = ""
            };

            return Created("Menu", "AddMenu");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMenu(int id)
        {
            return NoContent();
        }

        [HttpPut()]
        public IActionResult UpdateMenu(int id, MenuRequestModel menu)
        {
            MenuResponseModel menuOutput = new MenuResponseModel()
            {
                Name = menu.Name,
                Consist = menu.Consist,
                Portion = menu.Portion
            };

            return Ok(menuOutput);
        }
    }
}
