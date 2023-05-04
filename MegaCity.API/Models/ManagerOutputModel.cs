using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Models
{
    [Route("[controller]")]
    [ApiController]
    public class ManagerOutputModel : ControllerBase
    {
        public int Id { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }
              
        public int Age { get; set; }

        public int PhoneNumber { get; set; }

    }
}
