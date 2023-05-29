﻿namespace MegaCity.API.Models.ResponseModel
{
    public class UserResponseModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
