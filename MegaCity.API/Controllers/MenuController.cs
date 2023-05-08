using MegaCity.API.Models;
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
            List<MenuOutputModel> allMenu = new List<MenuOutputModel>()
            {
                new MenuOutputModel()
                {
                    Name = "MenuOne",
                    Consist = "",
                    Portion = 1
                },

                new MenuOutputModel()
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
            MenuOutputModel menu = new MenuOutputModel()
            {
                Name = "MenuOne",
                Consist = "",
                Portion = 1
            };

            return Ok(menu);
        }

        [HttpPost()]
        public IActionResult AddMenu(MenuInputModel menu)
        {
            MenuOutputModel newModel = new MenuOutputModel()
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
        public IActionResult UpdateMenu(int id, MenuInputModel menu)
        {
            MenuOutputModel menuOutput = new MenuOutputModel()
            {
                Name = menu.Name,
                Consist = menu.Consist,
                Portion = menu.Portion
            };

            return Ok(menuOutput);
        }
    }
}
