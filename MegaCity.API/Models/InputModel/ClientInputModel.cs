using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Models.InputModel
{
    public class ClientInputModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Date { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
