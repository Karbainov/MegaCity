using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet("clients")]
        public IActionResult GetAllClients()
        {
            List<ClientOutputModel> clients = new List<ClientOutputModel>()
            {
                new ClientOutputModel
                {
                    FirstName = "Aysel",
                    LastName = "Memmedova",
                    Date = "11.05.1992"
                },

                 new ClientOutputModel
                {
                    FirstName = "Emin",
                    LastName = "Memmedov",
                    Date = "07.03.1994"
                }
            };

            return Ok(clients);
        }

        [HttpGet("{id}")]
        public IActionResult GetClient()
        {
            ClientOutputModel client = new ClientOutputModel()
            {
                FirstName = "Samire",
                LastName = "Musayeva",
                Date = "03.01.2002"
            };

            return Ok(client);
        }

        [HttpPost()]
        public IActionResult AddClient(ClientInputModel client)
        {
            ClientOutputModel newClient = new ClientOutputModel()
            {
                Id = 127,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Date  = client.Date,
                PhoneNumber = client.PhoneNumber,
                Email = client.Email
            };

            return Created("ClientOne", "client");
        }

        [HttpDelete("/{id}")]
        public IActionResult DeleteCientById(int id)
        {
            return NoContent();
        }

        [HttpPut("/{id}")]
        public IActionResult UpdateClient(int id, ClientInputModel client)
        {
            ClientOutputModel clientOutput = new ClientOutputModel()
            {
                Id = id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Date = client.Date,
                PhoneNumber = client.PhoneNumber,
                Email = client.Email
            };

            return Ok(clientOutput);
        }
    }
}
